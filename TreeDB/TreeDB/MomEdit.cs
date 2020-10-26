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
    public partial class MomEdit : Form
    {
        public MomEdit()
        {
            InitializeComponent();
        }

        private void momBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.momBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.treeDBDataSet);

        }

        private void MomEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Member". При необходимости она может быть перемещена или удалена.
            this.memberTableAdapter.Fill(this.treeDBDataSet.Member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Mom". При необходимости она может быть перемещена или удалена.
            this.momTableAdapter.Fill(this.treeDBDataSet.Mom);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Автоподстановка ФИО
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
                OleDbCommand command = new OleDbCommand("SELECT ФИО FROM Member WHERE Код = " + comboBox1.Text, sqlconn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения ?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                momBindingSource.EndEdit();
                momTableAdapter.Update(treeDBDataSet);
            }
        }
    }
}
