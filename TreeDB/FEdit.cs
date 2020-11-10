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
    public partial class FEdit : Form
    {
        public FEdit()
        {
            InitializeComponent();
        }

        private void familyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.treeDBDataSet);

        }

        private void FEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Mom". При необходимости она может быть перемещена или удалена.
            this.momTableAdapter.Fill(this.treeDBDataSet.Mom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Dad". При необходимости она может быть перемещена или удалена.
            this.dadTableAdapter.Fill(this.treeDBDataSet.Dad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Family". При необходимости она может быть перемещена или удалена.
            this.familyTableAdapter.Fill(this.treeDBDataSet.Family);

        }

        private void button1_Click(object sender, EventArgs e) //Кнопка которая сохраняет изменения
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения ?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                familyBindingSource.EndEdit();
                familyTableAdapter.Update(treeDBDataSet);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Автоподстановка ФИО
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
                OleDbCommand command = new OleDbCommand("SELECT ФИО_отца FROM Dad WHERE Код_отца = " + comboBox1.Text, sqlconn);
                sqlconn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                фИО_отцаTextBox.Text = Convert.ToString(reader[0]);
                reader.Close();
                sqlconn.Close();
            }
            catch
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Автоподстановка ФИО
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
                OleDbCommand command = new OleDbCommand("SELECT ФИО_матери FROM Mom WHERE Код_матери = " + comboBox2.Text, sqlconn);
                sqlconn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                фИО_материTextBox.Text = Convert.ToString(reader[0]);
                reader.Close();
                sqlconn.Close();
            }
            catch
            {

            }
        }
    }
}
