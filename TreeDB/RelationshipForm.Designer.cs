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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Брат/Сестра";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(542, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 303);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(265, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(260, 303);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отец/Мать";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сын/Дочь";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 411);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(770, 108);
            this.dataGridView4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Муж/Жена";
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
            this.button1.Location = new System.Drawing.Point(329, 525);
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
            this.ClientSize = new System.Drawing.Size(794, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelationshipForm";
            this.Text = "RelationshipForm";
            this.Load += new System.EventHandler(this.RelationshipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
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