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
    public partial class MainForm : Form
    {
        public static Boolean admin = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Dad". При необходимости она может быть перемещена или удалена.
            this.dadTableAdapter.Fill(this.treeDBDataSet.Dad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Mom". При необходимости она может быть перемещена или удалена.
            this.momTableAdapter.Fill(this.treeDBDataSet.Mom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Family". При необходимости она может быть перемещена или удалена.
            this.familyTableAdapter.Fill(this.treeDBDataSet.Family);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Member". При необходимости она может быть перемещена или удалена.
            this.memberTableAdapter.Fill(this.treeDBDataSet.Member);
            dataGridView1.AutoGenerateColumns = true;
            fillMembers();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            update_all_tables();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            label2.Show();
            fillMembers();
            label1.Text = "Members";
            bindingNavigator1.BindingSource = memberBindingSource;
            dataGridView1.DataSource = memberBindingSource;
        }

        private void familyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidefounder();
            update_all_tables();
            label1.Text = "Family";
            bindingNavigator1.BindingSource = familyBindingSource;
            dataGridView1.DataSource = familyBindingSource;
        }

        private void passportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidefounder();
            update_all_tables();
            label1.Text = "Passport";
            bindingNavigator1.BindingSource = passportBindingSource;
            dataGridView1.DataSource = passportBindingSource;
        }

        private void momToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidefounder();
            update_all_tables();
            label1.Text = "Mom";
            bindingNavigator1.BindingSource = momBindingSource;
            dataGridView1.DataSource = momBindingSource;
        }

        private void dadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidefounder();
            update_all_tables();
            label1.Text = "Dad";
            bindingNavigator1.BindingSource = dadBindingSource;
            dataGridView1.DataSource = dadBindingSource;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_all_tables();
            Application.Exit();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                MEdit me = new MEdit();
                me.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void passportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                PEdit pe = new PEdit();
                pe.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void familyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                FEdit fe = new FEdit();
                fe.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void dadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                DadEdit de = new DadEdit();
                de.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void momToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                MomEdit mome = new MomEdit();
                mome.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void relationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreForm pf = new PreForm();
            pf.ShowDialog();
        }

        private void membersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                MAdd ma = new MAdd();
                ma.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void passportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                PAdd pa = new PAdd();
                pa.ShowDialog();
                fill_all_tables();
            }
            else
            {
                AlertForm af = new AlertForm("Вы не вошли как администратор");
                af.ShowDialog();
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admin == false)
            {
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
                if(admin == true)
                {
                    aDDToolStripMenuItem.Enabled = true;
                    editToolStripMenuItem.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                }
            }
            else
            {
                AlertForm af = new AlertForm("Вы уже вошли как администратор");
                af.ShowDialog();
            }
        }

        private void fillMembers() //Заполнение таблицу Комплектующие
        {
            string query = "SELECT * FROM Member";
            fillDataGridViewFromQuery(query);
        }

        private void fillDataGridViewFromQuery(string query) //Заполнить таблицу Комплектующие с запроса(нужно для поиска)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\TreeDB.mdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Member WHERE ФИО LIKE '%" + textBox1.Text + "%'";

            fillDataGridViewFromQuery(query);
        }

        private void fill_all_tables()
        {
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void update_all_tables()
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
        }

        private void hidefounder()
        {
            textBox1.Hide();
            label2.Hide();
        }
    }
}
