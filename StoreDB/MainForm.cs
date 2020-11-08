using StoreDB.StoreDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreDB
{
    public partial class MainForm : Form //Основная форма
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Прогрузка основной формы
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView3.AutoGenerateColumns = true;
            dataGridView4.AutoGenerateColumns = true;
            dataGridView5.AutoGenerateColumns = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.storeDBDataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.storeDBDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Виды_деталей". При необходимости она может быть перемещена или удалена.
            this.виды_деталейTableAdapter.Fill(this.storeDBDataSet.Виды_деталей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Фирмы". При необходимости она может быть перемещена или удалена.
            this.фирмыTableAdapter.Fill(this.storeDBDataSet.Фирмы);
            fillProducts(); //Заполнить таблицу Комплектующие
        }

        private void fillProducts() //Заполнение таблицу Комплектующие
        {
            string query = "SELECT * FROM Комплектующие";
            fillDataGridViewFromQuery(query);
        }

        private void fillDataGridViewFromQuery(string query) //Заполнить таблицу Комплектующие с запроса(нужно для поиска)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\StoreDB.mdb");
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

        private void toolStripButton2_Click(object sender, EventArgs e) //Вернуть таблицу Комплектующие в первоначальное положение
        {
            fillProducts();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Комплектующие WHERE Название_детали LIKE '%" + toolStripTextBox1.Text + "%'"; //Поиск и создание запроса для поиска в таблице Комплектующие
            fillDataGridViewFromQuery(query);
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //Открытие формы добавления в таблицу Комплектующие
        {
            ADDForm ap = new ADDForm("Add");
            ap.ShowDialog();
            fillProducts();

        }

        private void toolStripButton6_Click(object sender, EventArgs e) //Открытие формы Покупки
        {
            Basket b = new Basket(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
            dataGridView1.CurrentRow.Cells[1].Value.ToString(),
            dataGridView1.CurrentRow.Cells[3].Value.ToString(),
            dataGridView1.CurrentRow.Cells[5].Value.ToString());
            b.ShowDialog();

        }

        private void toolStripButton4_Click(object sender, EventArgs e) //Открытие формы изменения в таблицу Комплектующие
        {
            ADDForm ap = new ADDForm(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
            dataGridView1.CurrentRow.Cells[1].Value.ToString(),
            dataGridView1.CurrentRow.Cells[2].Value.ToString(),
            dataGridView1.CurrentRow.Cells[3].Value.ToString(),
            dataGridView1.CurrentRow.Cells[4].Value.ToString(),
            dataGridView1.CurrentRow.Cells[5].Value.ToString(),
            "Edit");
            ap.ShowDialog();
            fillProducts();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) //Удаление строки из таблицы Комплектующие
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\StoreDB.mdb");
                sqlconn.Open();
                string query = "DELETE FROM Комплектующие WHERE Код = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                sqlconn.Close();
                fillProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fillProducts();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Открытие формы добавления в таблицу Фирмы
        {
            ADDFormToFactories aftf = new ADDFormToFactories("Add");
            aftf.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e) //Открытие формы изменения в таблицу Фирмы
        {
            ADDFormToFactories aftf = new ADDFormToFactories(dataGridView2.CurrentRow.Cells[0].Value.ToString(),
            dataGridView2.CurrentRow.Cells[1].Value.ToString(),
            dataGridView2.CurrentRow.Cells[2].Value.ToString(),
            dataGridView2.CurrentRow.Cells[3].Value.ToString(),
            "Edit");
            aftf.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e) //Удаление строки из таблицы Фирмы
        {
            try
            {
                фирмыTableAdapter.Delete(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e) //Открытие формы добавления в таблицу Видов деталей
        {
            ADDFormToTypes aftt = new ADDFormToTypes("Add");
            aftt.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e) //Открытие формы изменения в таблицу Видов деталей
        {
            ADDFormToTypes aftt = new ADDFormToTypes(dataGridView3.CurrentRow.Cells[0].Value.ToString(),
            dataGridView3.CurrentRow.Cells[1].Value.ToString(),
            "Edit");
            aftt.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //Удаление строки из таблицы Виды деталей
        {
            try
            {
                виды_деталейTableAdapter.Delete(Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton8_Click(object sender, EventArgs e) //Открытие формы добавления в таблицу Покупатели
        {
            ADDFormToBuyers aftb = new ADDFormToBuyers("Add");
            aftb.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton9_Click(object sender, EventArgs e) //Открытие формы изменения в таблицу Покупатели
        {
            ADDFormToBuyers aftb = new ADDFormToBuyers(dataGridView5.CurrentRow.Cells[0].Value.ToString(),
            dataGridView5.CurrentRow.Cells[1].Value.ToString(),
            dataGridView5.CurrentRow.Cells[2].Value.ToString(),
            dataGridView5.CurrentRow.Cells[3].Value.ToString(),
            "Edit");
            aftb.ShowDialog();
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }

        private void toolStripButton10_Click(object sender, EventArgs e) //Удаление строки из таблицы Покупатели
        {
            try
            {
                заказчикTableAdapter.Delete(Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            фирмыTableAdapter.Update(storeDBDataSet);
            заказTableAdapter.Update(storeDBDataSet);
            заказчикTableAdapter.Update(storeDBDataSet);
            виды_деталейTableAdapter.Update(storeDBDataSet);
            Application.Restart();
        }
    }
}
