using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDB
{
    public partial class ADDFormToBuyers : Form
    {
        string operation;

        public ADDFormToBuyers(string operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        public ADDFormToBuyers(string id, string name, string telephone, string mail, string operation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.mail = mail;
            this.telephone = telephone;
            this.operation = operation;
            фИОTextBox.Text = name;
            телефонTextBox.Text = telephone;
            почтаTextBox.Text = mail;
        }

        string id, name, mail, telephone;

        private void button1_Click(object sender, EventArgs e) //Внесение или изменения параметров в таблице Покупатели
        {
            string name;
            if (фИОTextBox.Text != "" && фИОTextBox.Text != null)
            {
                name = фИОTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните ФИО покупателя!");
                return;
            }

            string telephone;
            if (телефонTextBox.Text.Length == 10)
            {
                telephone = телефонTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните телефон покупателя!");
                return;
            }

            string mail;
            if (почтаTextBox.Text != "" && почтаTextBox.Text != null)
            {
                mail = почтаTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните адрес почты покупателя!");
                return;
            }

            try
            {
                if (operation == "Add")
                {
                    заказчикTableAdapter.Insert(name, telephone, mail);
                }
                else if (operation == "Edit")
                {
                    заказчикTableAdapter.Update(name, telephone, mail, Convert.ToInt32(id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void заказчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void ADDFormToBuyers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.storeDBDataSet.Заказчик);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
