namespace StoreDB
{
    partial class ADDFormToFactories
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
            System.Windows.Forms.Label название_фирмыLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            this.storeDBDataSet = new StoreDB.StoreDBDataSet();
            this.фирмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фирмыTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.ФирмыTableAdapter();
            this.tableAdapterManager = new StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.название_фирмыTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            название_фирмыLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // название_фирмыLabel
            // 
            название_фирмыLabel.AutoSize = true;
            название_фирмыLabel.Location = new System.Drawing.Point(12, 9);
            название_фирмыLabel.Name = "название_фирмыLabel";
            название_фирмыLabel.Size = new System.Drawing.Size(99, 13);
            название_фирмыLabel.TabIndex = 3;
            название_фирмыLabel.Text = "Название фирмы:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(12, 35);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 5;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 61);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фирмыBindingSource
            // 
            this.фирмыBindingSource.DataMember = "Фирмы";
            this.фирмыBindingSource.DataSource = this.storeDBDataSet;
            // 
            // фирмыTableAdapter
            // 
            this.фирмыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_деталейTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаказчикTableAdapter = null;
            this.tableAdapterManager.КомплектующиеTableAdapter = null;
            this.tableAdapterManager.ФирмыTableAdapter = this.фирмыTableAdapter;
            // 
            // название_фирмыTextBox
            // 
            this.название_фирмыTextBox.Location = new System.Drawing.Point(117, 6);
            this.название_фирмыTextBox.Name = "название_фирмыTextBox";
            this.название_фирмыTextBox.Size = new System.Drawing.Size(175, 20);
            this.название_фирмыTextBox.TabIndex = 4;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Location = new System.Drawing.Point(117, 32);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(175, 20);
            this.адресTextBox.TabIndex = 6;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(117, 58);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(175, 20);
            this.телефонTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADDFormToFactories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(название_фирмыLabel);
            this.Controls.Add(this.название_фирмыTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ADDFormToFactories";
            this.Text = "ADDFormToFactories";
            this.Load += new System.EventHandler(this.ADDFormToFactories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource фирмыBindingSource;
        private StoreDBDataSetTableAdapters.ФирмыTableAdapter фирмыTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox название_фирмыTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}