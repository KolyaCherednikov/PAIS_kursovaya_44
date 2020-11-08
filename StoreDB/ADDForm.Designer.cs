namespace StoreDB
{
    partial class ADDForm
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
            System.Windows.Forms.Label название_деталиLabel;
            System.Windows.Forms.Label вид_деталиLabel;
            System.Windows.Forms.Label кол_во_деталейLabel;
            System.Windows.Forms.Label фирма_деталиLabel;
            System.Windows.Forms.Label цена_деталиLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.storeDBDataSet = new StoreDB.StoreDBDataSet();
            this.комплектующиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комплектующиеTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.КомплектующиеTableAdapter();
            this.tableAdapterManager = new StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.виды_деталейTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.Виды_деталейTableAdapter();
            this.фирмыTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.ФирмыTableAdapter();
            this.название_деталиTextBox = new System.Windows.Forms.TextBox();
            this.кол_во_деталейTextBox = new System.Windows.Forms.TextBox();
            this.цена_деталиTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.фирмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.видыдеталейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            название_деталиLabel = new System.Windows.Forms.Label();
            вид_деталиLabel = new System.Windows.Forms.Label();
            кол_во_деталейLabel = new System.Windows.Forms.Label();
            фирма_деталиLabel = new System.Windows.Forms.Label();
            цена_деталиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыдеталейBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // название_деталиLabel
            // 
            название_деталиLabel.AutoSize = true;
            название_деталиLabel.Location = new System.Drawing.Point(12, 9);
            название_деталиLabel.Name = "название_деталиLabel";
            название_деталиLabel.Size = new System.Drawing.Size(98, 13);
            название_деталиLabel.TabIndex = 19;
            название_деталиLabel.Text = "Название детали:";
            // 
            // вид_деталиLabel
            // 
            вид_деталиLabel.AutoSize = true;
            вид_деталиLabel.Location = new System.Drawing.Point(12, 35);
            вид_деталиLabel.Name = "вид_деталиLabel";
            вид_деталиLabel.Size = new System.Drawing.Size(67, 13);
            вид_деталиLabel.TabIndex = 21;
            вид_деталиLabel.Text = "Вид детали:";
            // 
            // кол_во_деталейLabel
            // 
            кол_во_деталейLabel.AutoSize = true;
            кол_во_деталейLabel.Location = new System.Drawing.Point(12, 61);
            кол_во_деталейLabel.Name = "кол_во_деталейLabel";
            кол_во_деталейLabel.Size = new System.Drawing.Size(88, 13);
            кол_во_деталейLabel.TabIndex = 23;
            кол_во_деталейLabel.Text = "Кол-во деталей:";
            // 
            // фирма_деталиLabel
            // 
            фирма_деталиLabel.AutoSize = true;
            фирма_деталиLabel.Location = new System.Drawing.Point(12, 87);
            фирма_деталиLabel.Name = "фирма_деталиLabel";
            фирма_деталиLabel.Size = new System.Drawing.Size(85, 13);
            фирма_деталиLabel.TabIndex = 25;
            фирма_деталиLabel.Text = "Фирма детали:";
            // 
            // цена_деталиLabel
            // 
            цена_деталиLabel.AutoSize = true;
            цена_деталиLabel.Location = new System.Drawing.Point(12, 113);
            цена_деталиLabel.Name = "цена_деталиLabel";
            цена_деталиLabel.Size = new System.Drawing.Size(74, 13);
            цена_деталиLabel.TabIndex = 27;
            цена_деталиLabel.Text = "Цена детали:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комплектующиеBindingSource
            // 
            this.комплектующиеBindingSource.DataMember = "Комплектующие";
            this.комплектующиеBindingSource.DataSource = this.storeDBDataSet;
            // 
            // комплектующиеTableAdapter
            // 
            this.комплектующиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_деталейTableAdapter = this.виды_деталейTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаказчикTableAdapter = null;
            this.tableAdapterManager.КомплектующиеTableAdapter = this.комплектующиеTableAdapter;
            this.tableAdapterManager.ФирмыTableAdapter = this.фирмыTableAdapter;
            // 
            // виды_деталейTableAdapter
            // 
            this.виды_деталейTableAdapter.ClearBeforeFill = true;
            // 
            // фирмыTableAdapter
            // 
            this.фирмыTableAdapter.ClearBeforeFill = true;
            // 
            // название_деталиTextBox
            // 
            this.название_деталиTextBox.Location = new System.Drawing.Point(116, 6);
            this.название_деталиTextBox.Name = "название_деталиTextBox";
            this.название_деталиTextBox.Size = new System.Drawing.Size(166, 20);
            this.название_деталиTextBox.TabIndex = 20;
            // 
            // кол_во_деталейTextBox
            // 
            this.кол_во_деталейTextBox.Location = new System.Drawing.Point(116, 58);
            this.кол_во_деталейTextBox.Name = "кол_во_деталейTextBox";
            this.кол_во_деталейTextBox.Size = new System.Drawing.Size(166, 20);
            this.кол_во_деталейTextBox.TabIndex = 24;
            // 
            // цена_деталиTextBox
            // 
            this.цена_деталиTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.цена_деталиTextBox.Location = new System.Drawing.Point(116, 110);
            this.цена_деталиTextBox.Name = "цена_деталиTextBox";
            this.цена_деталиTextBox.Size = new System.Drawing.Size(166, 20);
            this.цена_деталиTextBox.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.фирмыBindingSource;
            this.comboBox1.DisplayMember = "Код";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Код";
            // 
            // фирмыBindingSource
            // 
            this.фирмыBindingSource.DataMember = "Фирмы";
            this.фирмыBindingSource.DataSource = this.storeDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.видыдеталейBindingSource;
            this.comboBox2.DisplayMember = "Код";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "Код";
            // 
            // видыдеталейBindingSource
            // 
            this.видыдеталейBindingSource.DataMember = "Виды_деталей";
            this.видыдеталейBindingSource.DataSource = this.storeDBDataSet;
            // 
            // ADDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 197);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(название_деталиLabel);
            this.Controls.Add(this.название_деталиTextBox);
            this.Controls.Add(вид_деталиLabel);
            this.Controls.Add(кол_во_деталейLabel);
            this.Controls.Add(this.кол_во_деталейTextBox);
            this.Controls.Add(фирма_деталиLabel);
            this.Controls.Add(цена_деталиLabel);
            this.Controls.Add(this.цена_деталиTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ADDForm";
            this.Text = "ADDForm";
            this.Load += new System.EventHandler(this.ADDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыдеталейBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource комплектующиеBindingSource;
        private StoreDBDataSetTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StoreDBDataSetTableAdapters.ФирмыTableAdapter фирмыTableAdapter;
        private System.Windows.Forms.TextBox название_деталиTextBox;
        private System.Windows.Forms.TextBox кол_во_деталейTextBox;
        private System.Windows.Forms.TextBox цена_деталиTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource фирмыBindingSource;
        private StoreDBDataSetTableAdapters.Виды_деталейTableAdapter виды_деталейTableAdapter;
        private System.Windows.Forms.BindingSource видыдеталейBindingSource;
    }
}