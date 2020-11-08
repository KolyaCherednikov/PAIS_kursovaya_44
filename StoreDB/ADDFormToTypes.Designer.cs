namespace StoreDB
{
    partial class ADDFormToTypes
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
            System.Windows.Forms.Label название_вида_деталиLabel;
            this.storeDBDataSet = new StoreDB.StoreDBDataSet();
            this.виды_деталейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виды_деталейTableAdapter = new StoreDB.StoreDBDataSetTableAdapters.Виды_деталейTableAdapter();
            this.tableAdapterManager = new StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager();
            this.название_вида_деталиTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            название_вида_деталиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_деталейBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // название_вида_деталиLabel
            // 
            название_вида_деталиLabel.AutoSize = true;
            название_вида_деталиLabel.Location = new System.Drawing.Point(12, 15);
            название_вида_деталиLabel.Name = "название_вида_деталиLabel";
            название_вида_деталиLabel.Size = new System.Drawing.Size(125, 13);
            название_вида_деталиLabel.TabIndex = 3;
            название_вида_деталиLabel.Text = "Название вида детали:";
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // виды_деталейBindingSource
            // 
            this.виды_деталейBindingSource.DataMember = "Виды_деталей";
            this.виды_деталейBindingSource.DataSource = this.storeDBDataSet;
            // 
            // виды_деталейTableAdapter
            // 
            this.виды_деталейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StoreDB.StoreDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_деталейTableAdapter = this.виды_деталейTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ЗаказчикTableAdapter = null;
            this.tableAdapterManager.КомплектующиеTableAdapter = null;
            this.tableAdapterManager.ФирмыTableAdapter = null;
            // 
            // название_вида_деталиTextBox
            // 
            this.название_вида_деталиTextBox.Location = new System.Drawing.Point(143, 12);
            this.название_вида_деталиTextBox.Name = "название_вида_деталиTextBox";
            this.название_вида_деталиTextBox.Size = new System.Drawing.Size(130, 20);
            this.название_вида_деталиTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADDFormToTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 96);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(название_вида_деталиLabel);
            this.Controls.Add(this.название_вида_деталиTextBox);
            this.Name = "ADDFormToTypes";
            this.Text = "ADDFormToTypes";
            this.Load += new System.EventHandler(this.ADDFormToTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_деталейBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource виды_деталейBindingSource;
        private StoreDBDataSetTableAdapters.Виды_деталейTableAdapter виды_деталейTableAdapter;
        private StoreDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox название_вида_деталиTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}