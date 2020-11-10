using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeDB
{
    public partial class RelationshipForm : Form
    {
        public RelationshipForm(int code, string gender, int familycode) //Формирование и вывод семейных связей
        {
            InitializeComponent();
            string temp;
            int[] parents = new int[6]; //Код участника отца и матери
            int temp_lines = 0;
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + code, sqlconn);
            DataTable dt = new DataTable();
            OleDbCommand command = new OleDbCommand();
            oda.Fill(dt);
            dt.Columns.Add();
            dt.Columns[5].ColumnName = "Отношение";
            dt.Rows[0].Delete();   
            oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Семья = " + familycode + "AND Код <> " + code, sqlconn);
            sqlconn.Open();
            temp_lines = dt.Rows.Count;


            //Брат/Сестра
            if (familycode != 0)
            {
                oda.Fill(dt); //Брат/Сестра
                for (int i = temp_lines; i < dt.Rows.Count; i++)
                    if (Convert.ToString(dt.Rows[i][2]) == "М")
                        dt.Rows[i][5] = "Брат";
                    else
                        dt.Rows[i][5] = "Сестра";
            }

            //Отец/Мать
            try
            {
                command = new OleDbCommand("SELECT Код_отца FROM Family WHERE Код_семьи = " + familycode, sqlconn);
                OleDbDataReader reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код отца
                reader2.Close();
                command = new OleDbCommand("SELECT Код_участника FROM Dad WHERE Код_отца = " + temp, sqlconn);
                reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код участника отца
                parents[0] = Convert.ToInt32(reader2[0]);
                reader2.Close();
                oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                temp_lines = dt.Rows.Count;
                oda.Fill(dt);
                for (int i = temp_lines; i < dt.Rows.Count; i++)
                     dt.Rows[i][5] = "Отец";
                dataGridView1.DataSource = dt;
                command = new OleDbCommand("SELECT Код_матери FROM Family WHERE Код_семьи = " + familycode, sqlconn);
                reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код матери
                reader2.Close();
                command = new OleDbCommand("SELECT Код_участника FROM Mom WHERE Код_матери = " + temp, sqlconn);
                reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код участника матери
                parents[1] = Convert.ToInt32(reader2[0]);
                reader2.Close();
                oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                temp_lines = dt.Rows.Count;
                oda.Fill(dt);
                for (int i = temp_lines; i < dt.Rows.Count; i++)
                    dt.Rows[i][5] = "Мать";
                dataGridView1.DataSource = dt;

                for (int y = 0; y < 2; y++)
                {
                    command = new OleDbCommand("SELECT Семья FROM Member WHERE Код = " + parents[y], sqlconn);
                    reader2 = command.ExecuteReader();
                    reader2.Read();
                    temp = Convert.ToString(reader2[0]); //Код семьи
                    reader2.Close();
                    Console.WriteLine(temp);
                    if (temp == "0")
                        continue;
                    else
                    {
                        command = new OleDbCommand("SELECT Код_отца FROM Family WHERE Код_семьи = " + temp, sqlconn);
                        reader2 = command.ExecuteReader();
                        reader2.Read();
                        temp = Convert.ToString(reader2[0]); //Код отца дедушки
                        reader2.Close();
                        command = new OleDbCommand("SELECT Код_участника FROM Dad WHERE Код_отца = " + temp, sqlconn);
                        reader2 = command.ExecuteReader();
                        reader2.Read();
                        temp = Convert.ToString(reader2[0]); //Код участника дедушки
                        reader2.Close();
                        oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                        temp_lines = dt.Rows.Count;
                        oda.Fill(dt);
                        for (int i = temp_lines; i < dt.Rows.Count; i++)
                            dt.Rows[i][5] = "Дедушка";
                        dataGridView1.DataSource = dt;
                        command = new OleDbCommand("SELECT Семья FROM Member WHERE Код = " + parents[y], sqlconn);
                        reader2 = command.ExecuteReader();
                        Console.WriteLine(1);
                        reader2.Read();
                        temp = Convert.ToString(reader2[0]); //Код семьи
                        reader2.Close();
                        command = new OleDbCommand("SELECT Код_матери FROM Family WHERE Код_семьи = " + temp, sqlconn);
                        reader2 = command.ExecuteReader();
                        reader2.Read();
                        temp = Convert.ToString(reader2[0]); //Код матери бабушки
                        reader2.Close();
                        command = new OleDbCommand("SELECT Код_участника FROM Mom WHERE Код_матери = " + temp, sqlconn);
                        reader2 = command.ExecuteReader();
                        reader2.Read();
                        temp = Convert.ToString(reader2[0]); //Код участника бабушки
                        reader2.Close();
                        oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                        temp_lines = dt.Rows.Count;
                        oda.Fill(dt);
                        for (int i = temp_lines; i < dt.Rows.Count; i++)
                            dt.Rows[i][5] = "Бабушка";
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch
            {

            }


            if (gender == "М")
            {
                //Сын/Дочь только для мужчины
                try
                {
                    command = new OleDbCommand("SELECT Код_отца FROM Dad WHERE Код_участника = " + code, sqlconn);
                    OleDbDataReader reader1 = command.ExecuteReader();
                    reader1.Read();
                    temp = Convert.ToString(reader1[0]); //Код отца
                    reader1.Close();
                    command = new OleDbCommand("SELECT Код_семьи FROM Family WHERE Код_отца = " + temp, sqlconn);
                    reader1 = command.ExecuteReader();
                    reader1.Read();
                    temp = Convert.ToString(reader1[0]); //Код семьи
                    reader1.Close();
                    oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Семья = " + temp, sqlconn);
                    temp_lines = dt.Rows.Count;
                    oda.Fill(dt);
                    for (int i = temp_lines; i < dt.Rows.Count; i++)
                        if (Convert.ToString(dt.Rows[i][2]) == "М")
                            dt.Rows[i][5] = "Сын";
                        else
                            dt.Rows[i][5] = "Дочь";
                    dataGridView1.DataSource = dt;
                }
                catch
                {

                }

                //Жена
                try
                {
                    command = new OleDbCommand("SELECT Код_отца FROM Dad WHERE Код_участника = " + code, sqlconn);
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код отца
                    reader.Close();
                    command = new OleDbCommand("SELECT Код_матери FROM Family WHERE Код_отца = " + temp, sqlconn);
                    reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код матери
                    reader.Close();
                    command = new OleDbCommand("SELECT Код_участника FROM Mom WHERE Код_матери = " + temp, sqlconn);
                    reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код участника матери
                    reader.Close();
                    oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                    temp_lines = dt.Rows.Count;
                    oda.Fill(dt);
                    for (int i = temp_lines; i < dt.Rows.Count; i++)
                        dt.Rows[i][5] = "Жена";
                    dataGridView1.DataSource = dt;
                }
                catch
                {

                }
            }
            else
            {
                //Сын/Дочь только для женщины
                try
                {
                    command = new OleDbCommand("SELECT Код_матери FROM Mom WHERE Код_участника = " + code, sqlconn);
                    OleDbDataReader reader1 = command.ExecuteReader();
                    reader1.Read();
                    temp = Convert.ToString(reader1[0]); //Код отца
                    reader1.Close();
                    command = new OleDbCommand("SELECT Код_семьи FROM Family WHERE Код_матери = " + temp, sqlconn);
                    reader1 = command.ExecuteReader();
                    reader1.Read();
                    temp = Convert.ToString(reader1[0]); //Код семьи
                    reader1.Close();
                    oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Семья = " + temp, sqlconn);
                    temp_lines = dt.Rows.Count;
                    oda.Fill(dt);
                    for (int i = temp_lines; i < dt.Rows.Count; i++)
                        if (Convert.ToString(dt.Rows[i][2]) == "М")
                            dt.Rows[i][5] = "Сын";
                        else
                            dt.Rows[i][5] = "Дочь";
                    dataGridView1.DataSource = dt;
                }
                catch
                {

                }

                //Муж
                try
                {
                    command = new OleDbCommand("SELECT Код_матери FROM Mom WHERE Код_участника = " + code, sqlconn);
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код отца
                    reader.Close();
                    command = new OleDbCommand("SELECT Код_отца FROM Family WHERE Код_матери = " + temp, sqlconn);
                    reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код матери
                    reader.Close();
                    command = new OleDbCommand("SELECT Код_участника FROM Dad WHERE Код_отца = " + temp, sqlconn);
                    reader = command.ExecuteReader();
                    reader.Read();
                    temp = Convert.ToString(reader[0]); //Код участника матери
                    reader.Close();    
                    oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                    temp_lines = dt.Rows.Count;
                    oda.Fill(dt);
                    for (int i = temp_lines; i < dt.Rows.Count; i++)
                        dt.Rows[i][5] = "Жена";
                    dataGridView1.DataSource = dt;
                }
                catch
                {

                }
            }
            sqlconn.Close();
        }

        private void RelationshipForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Mom". При необходимости она может быть перемещена или удалена.
            this.momTableAdapter.Fill(this.treeDBDataSet.Mom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Member". При необходимости она может быть перемещена или удалена.
            this.memberTableAdapter.Fill(this.treeDBDataSet.Member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Family". При необходимости она может быть перемещена или удалена.
            this.familyTableAdapter.Fill(this.treeDBDataSet.Family);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Dad". При необходимости она может быть перемещена или удалена.
            this.dadTableAdapter.Fill(this.treeDBDataSet.Dad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
