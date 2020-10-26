namespace TreeDB
{
    partial class PAdd
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
            System.Windows.Forms.Label код_паспортаLabel;
            System.Windows.Forms.Label фИО_владельцаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            this.код_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_владельцаTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.passportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.passportTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.PassportTableAdapter();
            this.tableAdapterManager = new TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            код_паспортаLabel = new System.Windows.Forms.Label();
            фИО_владельцаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // код_паспортаLabel
            // 
            код_паспортаLabel.AutoSize = true;
            код_паспортаLabel.Location = new System.Drawing.Point(6, 15);
            код_паспортаLabel.Name = "код_паспортаLabel";
            код_паспортаLabel.Size = new System.Drawing.Size(79, 13);
            код_паспортаLabel.TabIndex = 1;
            код_паспортаLabel.Text = "Код паспорта:";
            // 
            // фИО_владельцаLabel
            // 
            фИО_владельцаLabel.AutoSize = true;
            фИО_владельцаLabel.Location = new System.Drawing.Point(6, 41);
            фИО_владельцаLabel.Name = "фИО_владельцаLabel";
            фИО_владельцаLabel.Size = new System.Drawing.Size(94, 13);
            фИО_владельцаLabel.TabIndex = 3;
            фИО_владельцаLabel.Text = "ФИО владельца:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(6, 68);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 5;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(6, 93);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 7;
            полLabel.Text = "Пол:";
            // 
            // код_паспортаTextBox
            // 
            this.код_паспортаTextBox.Location = new System.Drawing.Point(106, 12);
            this.код_паспортаTextBox.Name = "код_паспортаTextBox";
            this.код_паспортаTextBox.Size = new System.Drawing.Size(167, 20);
            this.код_паспортаTextBox.TabIndex = 2;
            // 
            // фИО_владельцаTextBox
            // 
            this.фИО_владельцаTextBox.Location = new System.Drawing.Point(106, 38);
            this.фИО_владельцаTextBox.Name = "фИО_владельцаTextBox";
            this.фИО_владельцаTextBox.Size = new System.Drawing.Size(167, 20);
            this.фИО_владельцаTextBox.TabIndex = 4;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(106, 64);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(174, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(12, 124);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(99, 23);
            this.OKbutton.TabIndex = 13;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // passportBindingSource
            // 
            this.passportBindingSource.DataMember = "Passport";
            this.passportBindingSource.DataSource = this.treeDBDataSet;
            // 
            // treeDBDataSet
            // 
            this.treeDBDataSet.DataSetName = "TreeDBDataSet";
            this.treeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passportTableAdapter
            // 
            this.passportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DadTableAdapter = null;
            this.tableAdapterManager.FamilyTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.MomTableAdapter = null;
            this.tableAdapterManager.PassportTableAdapter = this.passportTableAdapter;
            this.tableAdapterManager.UpdateOrder = TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBox1.Location = new System.Drawing.Point(106, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // PAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 159);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(код_паспортаLabel);
            this.Controls.Add(this.код_паспортаTextBox);
            this.Controls.Add(фИО_владельцаLabel);
            this.Controls.Add(this.фИО_владельцаTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Name = "PAdd";
            this.Text = "PAdd";
            this.Load += new System.EventHandler(this.PAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource passportBindingSource;
        private TreeDBDataSetTableAdapters.PassportTableAdapter passportTableAdapter;
        private TreeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_паспортаTextBox;
        private System.Windows.Forms.TextBox фИО_владельцаTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}