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
        public RelationshipForm(int code, string gender, int familycode)
        {
            InitializeComponent();
            string temp;
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Семья = " + familycode + "AND Код <> " + code, sqlconn);
            sqlconn.Open();
            OleDbCommand command = new OleDbCommand();

            //Брат/Сестра
            if (familycode != 0)
            {
                DataTable dt2 = new DataTable();
                oda.Fill(dt2); //Брат/Сестра
                dataGridView2.DataSource = dt2;
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
                temp = Convert.ToString(reader2[0]); //Код участника
                reader2.Close();
                oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                DataTable dt1 = new DataTable();
                oda.Fill(dt1);
                dataGridView1.DataSource = dt1;
                command = new OleDbCommand("SELECT Код_матери FROM Family WHERE Код_семьи = " + familycode, sqlconn);
                reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код матери
                reader2.Close();
                command = new OleDbCommand("SELECT Код_участника FROM Mom WHERE Код_матери = " + temp, sqlconn);
                reader2 = command.ExecuteReader();
                reader2.Read();
                temp = Convert.ToString(reader2[0]); //Код участника
                reader2.Close();
                oda = new OleDbDataAdapter("SELECT * FROM Member WHERE Код = " + temp, sqlconn);
                oda.Fill(dt1);
                dataGridView1.DataSource = dt1;
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
                    DataTable dt3 = new DataTable();
                    oda.Fill(dt3);
                    dataGridView3.DataSource = dt3;
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
                    DataTable dt4 = new DataTable();
                    oda.Fill(dt4);
                    dataGridView4.DataSource = dt4;
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
                    DataTable dt3 = new DataTable();
                    oda.Fill(dt3);
                    dataGridView3.DataSource = dt3;
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
                    DataTable dt4 = new DataTable();
                    oda.Fill(dt4);
                    dataGridView4.DataSource = dt4;
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
    }
}
