namespace StoreDB
{
    partial class Basket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label комплектующиеLabel;
            System.Windows.Forms.Label заказчикLabel;
            System.Windows.Forms.Label дата_продажиLabel;
            System.Windows.Forms.Label кол_воLabel;
            System.Windows.Forms.Label label2;
            this.storeDBDataSet = new StoreDB.StoreDBDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.дата_продажиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.ЗаказчикTableAdapter();
            this.комплектующиеTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.комплектующиеTableAdapter1 = new StoreDB.StoreDBDataSetTableAdapters.КомплектующиеTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            комплектующиеLabel = new System.Windows.Forms.Label();
            заказчикLabel = new System.Windows.Forms.Label();
            дата_продажиLabel = new System.Windows.Forms.Label();
            кол_воLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // комплектующиеLabel
            // 
            комплектующиеLabel.AutoSize = true;
            комплектующиеLabel.Location = new System.Drawing.Point(9, 9);
            комплектующиеLabel.Name = "комплектующиеLabel";
            комплектующиеLabel.Size = new System.Drawing.Size(94, 13);
            комплектующиеLabel.TabIndex = 3;
            комплектующиеLabel.Text = "Комплектующие:";
            // 
            // заказчикLabel
            // 
            заказчикLabel.AutoSize = true;
            заказчикLabel.Location = new System.Drawing.Point(9, 35);
            заказчикLabel.Name = "заказчикLabel";
            заказчикLabel.Size = new System.Drawing.Size(58, 13);
            заказчикLabel.TabIndex = 5;
            заказчикLabel.Text = "Заказчик:";
            // 
            // дата_продажиLabel
            // 
            дата_продажиLabel.AutoSize = true;
            дата_продажиLabel.Location = new System.Drawing.Point(9, 64);
            дата_продажиLabel.Name = "дата_продажиLabel";
            дата_продажиLabel.Size = new System.Drawing.Size(83, 13);
            дата_продажиLabel.TabIndex = 7;
            дата_продажиLabel.Text = "Дата продажи:";
            // 
            // кол_воLabel
            // 
            кол_воLabel.AutoSize = true;
            кол_воLabel.Location = new System.Drawing.Point(9, 87);
            кол_воLabel.Name = "кол_воLabel";
            кол_воLabel.Size = new System.Drawing.Size(44, 13);
            кол_воLabel.TabIndex = 9;
            кол_воLabel.Text = "Кол-во:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 13);
            label2.TabIndex = 16;
            label2.Text = "Цена:";
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.storeDBDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_деталейTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ЗаказчикTableAdapter = null;
            this.tableAdapterManager.КомплектующиеTableAdapter = null;
            this.tableAdapterManager.ФирмыTableAdapter = null;
            // 
            // дата_продажиDateTimePicker
            // 
            this.дата_продажиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата продажи", true));
            this.дата_продажиDateTimePicker.Location = new System.Drawing.Point(112, 58);
            this.дата_продажиDateTimePicker.Name = "дата_продажиDateTimePicker";
            this.дата_продажиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_продажиDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "0 UAH";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.заказчикBindingSource;
            this.comboBox1.DisplayMember = "Код";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Код";
            // 
            // заказчикBindingSource
            // 
            this.заказчикBindingSource.DataMember = "Заказчик";
            this.заказчикBindingSource.DataSource = this.storeDBDataSet;
            // 
            // заказчикTableAdapter
            // 
            this.заказчикTableAdapter.ClearBeforeFill = true;
            // 
            // комплектующиеTextBox
            // 
            this.комплектующиеTextBox.Location = new System.Drawing.Point(112, 6);
            this.комплектующиеTextBox.Name = "комплектующиеTextBox";
            this.комплектующиеTextBox.ReadOnly = true;
            this.комплектующиеTextBox.Size = new System.Drawing.Size(200, 20);
            this.комплектующиеTextBox.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(112, 85);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 17;
            // 
            // комплектующиеTableAdapter1
            // 
            this.комплектующиеTableAdapter1.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 200);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(комплектующиеLabel);
            this.Controls.Add(this.комплектующиеTextBox);
            this.Controls.Add(заказчикLabel);
            this.Controls.Add(дата_продажиLabel);
            this.Controls.Add(this.дата_продажиDateTimePicker);
            this.Controls.Add(кол_воLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Basket";
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private StoreDBDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker дата_продажиDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource заказчикBindingSource;
        private StoreDBDataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private System.Windows.Forms.TextBox комплектующиеTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private StoreDBDataSetTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}