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
    public partial class MEdit : Form
    {
        public MEdit()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.treeDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Passport". При необходимости она может быть перемещена или удалена.
            this.passportTableAdapter.Fill(this.treeDBDataSet.Passport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Family". При необходимости она может быть перемещена или удалена.
            this.familyTableAdapter.Fill(this.treeDBDataSet.Family);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "treeDBDataSet.Member". При необходимости она может быть перемещена или удалена.
            this.memberTableAdapter.Fill(this.treeDBDataSet.Member);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения ?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                memberBindingSource.EndEdit();
                memberTableAdapter.Update(treeDBDataSet);
            }
        }
    }
}
