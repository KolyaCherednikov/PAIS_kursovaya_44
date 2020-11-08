namespace StoreDB
{
    partial class ADDFormToBuyers
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label почтаLabel;
            this.storeDBDataSet = new StoreDB.StoreDBDataSet();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.ЗаказчикTableAdapter();
            this.tableAdapterManager = new StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_деталейTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаказчикTableAdapter = this.заказчикTableAdapter;
            this.tableAdapterManager.КомплектующиеTableAdapter = null;
            this.tableAdapterManager.ФирмыTableAdapter = null;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 9);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Location = new System.Drawing.Point(73, 6);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(184, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 35);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(73, 32);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(184, 20);
            this.телефонTextBox.TabIndex = 6;
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(12, 61);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(40, 13);
            почтаLabel.TabIndex = 7;
            почтаLabel.Text = "Почта:";
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.Location = new System.Drawing.Point(73, 58);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(184, 20);
            this.почтаTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADDFormToBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 121);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ADDFormToBuyers";
            this.Text = "ADDFormToBuyers";
            this.Load += new System.EventHandler(this.ADDFormToBuyers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource заказчикBindingSource;
        private StoreDBDataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}