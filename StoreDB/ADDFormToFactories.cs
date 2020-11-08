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
    public partial class ADDFormToFactories : Form
    {
        string operation;

        public ADDFormToFactories(string operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        public ADDFormToFactories(string id, string name, string address, string telephone, string operation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.address = address;
            this.telephone = telephone;
            this.operation = operation;
            название_фирмыTextBox.Text = name;
            адресTextBox.Text = address;
            телефонTextBox.Text = telephone;
        }

        string id, name, address, telephone;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e) //Внесение или изменения параметров в таблице Фирмы
        {

            string name;
            if (название_фирмыTextBox.Text != "" && название_фирмыTextBox.Text != null)
            {
                name = название_фирмыTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните название фирмы!");
                return;
            }

            string address;
            if (адресTextBox.Text != "" && адресTextBox.Text != null)
            {
                address = адресTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните адрес фирмы!");
                return;
            }

            string telephone;
            if (телефонTextBox.Text.Length == 10)
            {
                telephone = телефонTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните телефон фирмы!");
                return;
            }

            try
            {
                if (operation == "Add")
                {
                    фирмыTableAdapter.Insert(name, address, telephone);
                }
                else if (operation == "Edit")
                {
                    фирмыTableAdapter.Update(name, address, telephone, Convert.ToInt32(id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }


        private void ADDFormToFactories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Фирмы". При необходимости она может быть перемещена или удалена.
            this.фирмыTableAdapter.Fill(this.storeDBDataSet.Фирмы);

        }
    }
}

