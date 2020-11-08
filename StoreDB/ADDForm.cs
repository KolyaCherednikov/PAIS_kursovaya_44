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
    public partial class ADDForm : Form
    {
        string operation;

        public ADDForm(string operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        public ADDForm(string idProduct, string nameProduct, string category, string quantity, string factory, string price, string operation)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.category = category;
            this.quantity = quantity;
            this.price = price;
            this.factory = factory;
            this.operation = operation;
            название_деталиTextBox.Text = nameProduct;
            comboBox2.Text = category;
            кол_во_деталейTextBox.Text = quantity;
            comboBox1.Text = factory;
            цена_деталиTextBox.Text = price;
        }

        string idProduct, nameProduct, category, quantity, price, factory;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void комплектующиеBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.комплектующиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e) //Внесение или изменения параметров в таблице Комплектующие
        {
            int idCategory;
            idCategory = Convert.ToInt32(comboBox2.SelectedValue);

            string nameProduct;
            if (название_деталиTextBox.Text != "" && название_деталиTextBox.Text != null)
            {
                nameProduct = название_деталиTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните название продукта!");
                return;
            }

            int quantity;
            if (кол_во_деталейTextBox.Text != "" && кол_во_деталейTextBox.Text != null)
            {
                quantity = Convert.ToInt32(кол_во_деталейTextBox.Text);
            }
            else
            {
                MessageBox.Show("Заполните кол-во продукта!");
                return;
            }

            int price;
            if (Int32.TryParse(цена_деталиTextBox.Text, out price))
            {
                price = Convert.ToInt32(цена_деталиTextBox.Text);
            }
            else
            {
                MessageBox.Show("Некоректная цена продукта!");
                return;
            }

            int factory;
            factory = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                if (operation == "Add")
                {
                    комплектующиеTableAdapter.Insert(nameProduct, idCategory, quantity, factory, price);
                }
                else if (operation == "Edit")
                {
                    комплектующиеTableAdapter.Update(nameProduct, idCategory, quantity, factory, price, Convert.ToInt32(idProduct));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }


        private void комплектующиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комплектующиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void комплектующиеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.комплектующиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void ADDForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Виды_деталей". При необходимости она может быть перемещена или удалена.
            this.виды_деталейTableAdapter.Fill(this.storeDBDataSet.Виды_деталей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Фирмы". При необходимости она может быть перемещена или удалена.
            this.фирмыTableAdapter.Fill(this.storeDBDataSet.Фирмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.storeDBDataSet.Комплектующие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Фирмы". При необходимости она может быть перемещена или удалена.
            this.фирмыTableAdapter.Fill(this.storeDBDataSet.Фирмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Виды_деталей". При необходимости она может быть перемещена или удалена.
            this.виды_деталейTableAdapter.Fill(this.storeDBDataSet.Виды_деталей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.storeDBDataSet.Комплектующие);

        }
    }
}
