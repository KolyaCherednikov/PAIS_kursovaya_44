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
    public partial class ADDFormToTypes : Form
    {
        string operation;
        string id, name;
        public ADDFormToTypes(string operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        public ADDFormToTypes(string id, string name, string operation)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.operation = operation;
            название_вида_деталиTextBox.Text = name;
        }

        private void ADDFormToTypes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Виды_деталей". При необходимости она может быть перемещена или удалена.
            this.виды_деталейTableAdapter.Fill(this.storeDBDataSet.Виды_деталей);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Внесение или изменения параметров в таблице Виды деталей
        {
            string name;
            if (название_вида_деталиTextBox.Text != "" && название_вида_деталиTextBox.Text != null)
            {
                name = название_вида_деталиTextBox.Text;
            }
            else
            {
                MessageBox.Show("Заполните название типа детали!");
                return;
            }

            try
            {
                if (operation == "Add")
                {
                    виды_деталейTableAdapter.Insert(name);
                }
                else if (operation == "Edit")
                {
                    виды_деталейTableAdapter.Update(name, Convert.ToInt32(id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
