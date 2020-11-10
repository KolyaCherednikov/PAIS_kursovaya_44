namespace TreeDB
{
    partial class RelationshipForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.dadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.DadTableAdapter();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.FamilyTableAdapter();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MemberTableAdapter();
            this.momBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.momTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MomTableAdapter();
            this.passportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.PassportTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сімейні зв\'язки";
            // 
            // treeDBDataSet
            // 
            this.treeDBDataSet.DataSetName = "TreeDBDataSet";
            this.treeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadBindingSource
            // 
            this.dadBindingSource.DataMember = "Dad";
            this.dadBindingSource.DataSource = this.treeDBDataSet;
            // 
            // dadTableAdapter
            // 
            this.dadTableAdapter.ClearBeforeFill = true;
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.treeDBDataSet;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.treeDBDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // momBindingSource
            // 
            this.momBindingSource.DataMember = "Mom";
            this.momBindingSource.DataSource = this.treeDBDataSet;
            // 
            // momTableAdapter
            // 
            this.momTableAdapter.ClearBeforeFill = true;
            // 
            // passportBindingSource
            // 
            this.passportBindingSource.DataMember = "Passport";
            this.passportBindingSource.DataSource = this.treeDBDataSet;
            // 
            // passportTableAdapter
            // 
            this.passportTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelationshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelationshipForm";
            this.Text = "RelationshipForm";
            this.Load += new System.EventHandler(this.RelationshipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource dadBindingSource;
        private TreeDBDataSetTableAdapters.DadTableAdapter dadTableAdapter;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private TreeDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private TreeDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource momBindingSource;
        private TreeDBDataSetTableAdapters.MomTableAdapter momTableAdapter;
        private System.Windows.Forms.BindingSource passportBindingSource;
        private TreeDBDataSetTableAdapters.PassportTableAdapter passportTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}