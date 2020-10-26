using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeDB
{
    public partial class MainForm : Form
    {
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
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
            label1.Text = "Members";
            bindingNavigator1.BindingSource = memberBindingSource;
            dataGridView1.DataSource = memberBindingSource;
        }

        private void familyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
            label1.Text = "Family";
            bindingNavigator1.BindingSource = familyBindingSource;
            dataGridView1.DataSource = familyBindingSource;
        }

        private void passportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
            label1.Text = "Passport";
            bindingNavigator1.BindingSource = passportBindingSource;
            dataGridView1.DataSource = passportBindingSource;
        }

        private void momToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            label1.Text = "Mom";
            bindingNavigator1.BindingSource = momBindingSource;
            dataGridView1.DataSource = momBindingSource;
        }

        private void dadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
            label1.Text = "Dad";
            bindingNavigator1.BindingSource = dadBindingSource;
            dataGridView1.DataSource = dadBindingSource;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberTableAdapter.Update(treeDBDataSet);
            passportTableAdapter.Update(treeDBDataSet);
            familyTableAdapter.Update(treeDBDataSet);
            dadTableAdapter.Update(treeDBDataSet);
            momTableAdapter.Update(treeDBDataSet);
            Application.Exit();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MEdit me = new MEdit();
            me.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void passportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PEdit pe = new PEdit();
            pe.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void familyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FEdit fe = new FEdit();
            fe.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void dadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DadEdit de = new DadEdit();
            de.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void momToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MomEdit mome = new MomEdit();
            mome.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void relationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreForm pf = new PreForm();
            pf.ShowDialog();
        }

        private void membersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MAdd ma = new MAdd();
            ma.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }

        private void passportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PAdd pa = new PAdd();
            pa.ShowDialog();
            memberTableAdapter.Fill(treeDBDataSet.Member);
            passportTableAdapter.Fill(treeDBDataSet.Passport);
            familyTableAdapter.Fill(treeDBDataSet.Family);
            dadTableAdapter.Fill(treeDBDataSet.Dad);
            momTableAdapter.Fill(treeDBDataSet.Mom);
        }
    }
}
