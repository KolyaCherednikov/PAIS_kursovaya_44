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

namespace StoreDB
{
    public partial class Basket : Form
    {
        int idProduct, quantityAll, price;
        public Basket(string idProduct, string nameProduct, string quantityAll, string price)
        {
            InitializeComponent();
            комплектующиеTextBox.Text = nameProduct;
            дата_продажиDateTimePicker.Value = DateTime.Today;
            textBox1.Text = price;
            this.quantityAll = Convert.ToInt32(quantityAll);
            label1.Text = "0 UAH";
            this.price = Convert.ToInt32(price);
            this.idProduct = Convert.ToInt32(idProduct);
        }


        private void Basket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.storeDBDataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.storeDBDataSet.Заказ);

        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Внесение в таблицу заказов нового заказа и вычет кол-во товара купили
        {
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                printDocument1.Print();

                try
                {
                    заказTableAdapter.Insert(idProduct,
                        Convert.ToInt32(comboBox1.Text),
                        Convert.ToDateTime(дата_продажиDateTimePicker.Value.ToShortDateString()),
                        Convert.ToInt32(numericUpDown1.Value));
                    комплектующиеTableAdapter1.EditQuantity(Convert.ToInt32(quantityAll - numericUpDown1.Value), idProduct);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Вычесление стоимости товара
        {
            if (numericUpDown1.Value == quantityAll)
            {
                MessageBox.Show("Достигнуто максимальное количество товара!");
            }
            label1.Text = price * numericUpDown1.Value+" UAH";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //Печать чека
        {
            OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\StoreDB.mdb");
            sqlconn.Open();
            OleDbCommand command = new OleDbCommand("SELECT ФИО FROM Заказчик WHERE Код = " + numericUpDown1.Value, sqlconn);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            string FIO = Convert.ToString(reader[0]);
            reader.Close();
            sqlconn.Close();
            var font = new Font("Tahoma", 12, FontStyle.Bold);
            string printText = "Чек\nПродукт: " + комплектующиеTextBox.Text +
                "\n Заказчик: " + FIO +
                "\nКоличество: " + numericUpDown1.Value.ToString() + ", по цене " + textBox1.Text + " UAH" +
                "\nСумма к оплате: " + label1.Text + "\nДата покупки: " + дата_продажиDateTimePicker.Value.ToShortDateString();
            e.Graphics.DrawString(printText, font, Brushes.Black, 0, 0);
        }

    }
}
