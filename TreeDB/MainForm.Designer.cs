namespace TreeDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MemberTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.momToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.passportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.passportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.momToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.PassportTableAdapter();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.FamilyTableAdapter();
            this.momBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.momTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MomTableAdapter();
            this.dadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.DadTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.treeDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // treeDBDataSet
            // 
            this.treeDBDataSet.DataSetName = "TreeDBDataSet";
            this.treeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.bindingSource1;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.aDDToolStripMenuItem,
            this.editToolStripMenuItem,
            this.relationshipToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.logInToolStripMenuItem.Text = "LogIn";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.familyToolStripMenuItem,
            this.passportToolStripMenuItem,
            this.momToolStripMenuItem,
            this.dadToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // familyToolStripMenuItem
            // 
            this.familyToolStripMenuItem.Name = "familyToolStripMenuItem";
            this.familyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.familyToolStripMenuItem.Text = "Family";
            this.familyToolStripMenuItem.Click += new System.EventHandler(this.familyToolStripMenuItem_Click);
            // 
            // passportToolStripMenuItem
            // 
            this.passportToolStripMenuItem.Name = "passportToolStripMenuItem";
            this.passportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.passportToolStripMenuItem.Text = "Passport";
            this.passportToolStripMenuItem.Click += new System.EventHandler(this.passportToolStripMenuItem_Click);
            // 
            // momToolStripMenuItem
            // 
            this.momToolStripMenuItem.Name = "momToolStripMenuItem";
            this.momToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.momToolStripMenuItem.Text = "Mom";
            this.momToolStripMenuItem.Click += new System.EventHandler(this.momToolStripMenuItem_Click);
            // 
            // dadToolStripMenuItem
            // 
            this.dadToolStripMenuItem.Name = "dadToolStripMenuItem";
            this.dadToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dadToolStripMenuItem.Text = "Dad";
            this.dadToolStripMenuItem.Click += new System.EventHandler(this.dadToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem2,
            this.passportToolStripMenuItem2});
            this.aDDToolStripMenuItem.Enabled = false;
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // membersToolStripMenuItem2
            // 
            this.membersToolStripMenuItem2.Name = "membersToolStripMenuItem2";
            this.membersToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.membersToolStripMenuItem2.Text = "Members";
            this.membersToolStripMenuItem2.Click += new System.EventHandler(this.membersToolStripMenuItem2_Click);
            // 
            // passportToolStripMenuItem2
            // 
            this.passportToolStripMenuItem2.Name = "passportToolStripMenuItem2";
            this.passportToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.passportToolStripMenuItem2.Text = "Passport";
            this.passportToolStripMenuItem2.Click += new System.EventHandler(this.passportToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem1,
            this.familyToolStripMenuItem1,
            this.passportToolStripMenuItem1,
            this.momToolStripMenuItem1,
            this.dadToolStripMenuItem1});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // membersToolStripMenuItem1
            // 
            this.membersToolStripMenuItem1.Name = "membersToolStripMenuItem1";
            this.membersToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.membersToolStripMenuItem1.Text = "Members";
            this.membersToolStripMenuItem1.Click += new System.EventHandler(this.membersToolStripMenuItem1_Click);
            // 
            // familyToolStripMenuItem1
            // 
            this.familyToolStripMenuItem1.Name = "familyToolStripMenuItem1";
            this.familyToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.familyToolStripMenuItem1.Text = "Family";
            this.familyToolStripMenuItem1.Click += new System.EventHandler(this.familyToolStripMenuItem1_Click);
            // 
            // passportToolStripMenuItem1
            // 
            this.passportToolStripMenuItem1.Name = "passportToolStripMenuItem1";
            this.passportToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.passportToolStripMenuItem1.Text = "Passport";
            this.passportToolStripMenuItem1.Click += new System.EventHandler(this.passportToolStripMenuItem1_Click);
            // 
            // momToolStripMenuItem1
            // 
            this.momToolStripMenuItem1.Name = "momToolStripMenuItem1";
            this.momToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.momToolStripMenuItem1.Text = "Mom";
            this.momToolStripMenuItem1.Click += new System.EventHandler(this.momToolStripMenuItem1_Click);
            // 
            // dadToolStripMenuItem1
            // 
            this.dadToolStripMenuItem1.Name = "dadToolStripMenuItem1";
            this.dadToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.dadToolStripMenuItem1.Text = "Dad";
            this.dadToolStripMenuItem1.Click += new System.EventHandler(this.dadToolStripMenuItem1_Click);
            // 
            // relationshipToolStripMenuItem
            // 
            this.relationshipToolStripMenuItem.Name = "relationshipToolStripMenuItem";
            this.relationshipToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.relationshipToolStripMenuItem.Text = "Relationship";
            this.relationshipToolStripMenuItem.Click += new System.EventHandler(this.relationshipToolStripMenuItem_Click);
            // 
            // passportBindingSource
            // 
            this.passportBindingSource.DataMember = "Passport";
            this.passportBindingSource.DataSource = this.bindingSource1;
            // 
            // passportTableAdapter
            // 
            this.passportTableAdapter.ClearBeforeFill = true;
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.bindingSource1;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // momBindingSource
            // 
            this.momBindingSource.DataMember = "Mom";
            this.momBindingSource.DataSource = this.bindingSource1;
            // 
            // momTableAdapter
            // 
            this.momTableAdapter.ClearBeforeFill = true;
            // 
            // dadBindingSource
            // 
            this.dadBindingSource.DataMember = "Dad";
            this.dadBindingSource.DataSource = this.bindingSource1;
            // 
            // dadTableAdapter
            // 
            this.dadTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.memberBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 476);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(804, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 418);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Members";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пошук:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private TreeDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem momToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadToolStripMenuItem;
        private System.Windows.Forms.BindingSource passportBindingSource;
        private TreeDBDataSetTableAdapters.PassportTableAdapter passportTableAdapter;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private TreeDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.BindingSource momBindingSource;
        private TreeDBDataSetTableAdapters.MomTableAdapter momTableAdapter;
        private System.Windows.Forms.BindingSource dadBindingSource;
        private TreeDBDataSetTableAdapters.DadTableAdapter dadTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem passportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem familyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem momToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relationshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem passportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

