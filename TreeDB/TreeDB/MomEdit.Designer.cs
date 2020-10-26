namespace TreeDB
{
    partial class MomEdit
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
            System.Windows.Forms.Label код_материLabel;
            System.Windows.Forms.Label код_участникаLabel;
            System.Windows.Forms.Label фИО_материLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MomEdit));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.momBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.momTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MomTableAdapter();
            this.tableAdapterManager = new TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager();
            this.memberTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MemberTableAdapter();
            this.momBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.momBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_материTextBox = new System.Windows.Forms.TextBox();
            this.фИО_материTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодматериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучастникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОматериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_материLabel = new System.Windows.Forms.Label();
            код_участникаLabel = new System.Windows.Forms.Label();
            фИО_материLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingNavigator)).BeginInit();
            this.momBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_материLabel
            // 
            код_материLabel.AutoSize = true;
            код_материLabel.Location = new System.Drawing.Point(12, 31);
            код_материLabel.Name = "код_материLabel";
            код_материLabel.Size = new System.Drawing.Size(69, 13);
            код_материLabel.TabIndex = 16;
            код_материLabel.Text = "Код матери:";
            // 
            // код_участникаLabel
            // 
            код_участникаLabel.AutoSize = true;
            код_участникаLabel.Location = new System.Drawing.Point(12, 57);
            код_участникаLabel.Name = "код_участникаLabel";
            код_участникаLabel.Size = new System.Drawing.Size(83, 13);
            код_участникаLabel.TabIndex = 18;
            код_участникаLabel.Text = "Код участника:";
            // 
            // фИО_материLabel
            // 
            фИО_материLabel.AutoSize = true;
            фИО_материLabel.Location = new System.Drawing.Point(12, 83);
            фИО_материLabel.Name = "фИО_материLabel";
            фИО_материLabel.Size = new System.Drawing.Size(77, 13);
            фИО_материLabel.TabIndex = 20;
            фИО_материLabel.Text = "ФИО матери:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Подтвердить изменение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодматериDataGridViewTextBoxColumn,
            this.кодучастникаDataGridViewTextBoxColumn,
            this.фИОматериDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.momBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(304, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 178);
            this.dataGridView1.TabIndex = 14;
            // 
            // treeDBDataSet
            // 
            this.treeDBDataSet.DataSetName = "TreeDBDataSet";
            this.treeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DadTableAdapter = null;
            this.tableAdapterManager.FamilyTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.MomTableAdapter = this.momTableAdapter;
            this.tableAdapterManager.PassportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // momBindingNavigator
            // 
            this.momBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.momBindingNavigator.BindingSource = this.momBindingSource;
            this.momBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.momBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.momBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.momBindingNavigatorSaveItem});
            this.momBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.momBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.momBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.momBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.momBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.momBindingNavigator.Name = "momBindingNavigator";
            this.momBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.momBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.momBindingNavigator.TabIndex = 16;
            this.momBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            // momBindingNavigatorSaveItem
            // 
            this.momBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.momBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("momBindingNavigatorSaveItem.Image")));
            this.momBindingNavigatorSaveItem.Name = "momBindingNavigatorSaveItem";
            this.momBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.momBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.momBindingNavigatorSaveItem.Click += new System.EventHandler(this.momBindingNavigatorSaveItem_Click);
            // 
            // код_материTextBox
            // 
            this.код_материTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.momBindingSource, "Код_матери", true));
            this.код_материTextBox.Location = new System.Drawing.Point(101, 28);
            this.код_материTextBox.Name = "код_материTextBox";
            this.код_материTextBox.Size = new System.Drawing.Size(197, 20);
            this.код_материTextBox.TabIndex = 17;
            // 
            // фИО_материTextBox
            // 
            this.фИО_материTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.momBindingSource, "ФИО_матери", true));
            this.фИО_материTextBox.Location = new System.Drawing.Point(101, 80);
            this.фИО_материTextBox.Name = "фИО_материTextBox";
            this.фИО_материTextBox.ReadOnly = true;
            this.фИО_материTextBox.Size = new System.Drawing.Size(197, 20);
            this.фИО_материTextBox.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.momBindingSource, "Код_участника", true));
            this.comboBox1.DataSource = this.memberBindingSource;
            this.comboBox1.DisplayMember = "Код";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.treeDBDataSet;
            // 
            // кодматериDataGridViewTextBoxColumn
            // 
            this.кодматериDataGridViewTextBoxColumn.DataPropertyName = "Код_матери";
            this.кодматериDataGridViewTextBoxColumn.HeaderText = "Код_матери";
            this.кодматериDataGridViewTextBoxColumn.Name = "кодматериDataGridViewTextBoxColumn";
            // 
            // кодучастникаDataGridViewTextBoxColumn
            // 
            this.кодучастникаDataGridViewTextBoxColumn.DataPropertyName = "Код_участника";
            this.кодучастникаDataGridViewTextBoxColumn.HeaderText = "Код_участника";
            this.кодучастникаDataGridViewTextBoxColumn.Name = "кодучастникаDataGridViewTextBoxColumn";
            // 
            // фИОматериDataGridViewTextBoxColumn
            // 
            this.фИОматериDataGridViewTextBoxColumn.DataPropertyName = "ФИО_матери";
            this.фИОматериDataGridViewTextBoxColumn.HeaderText = "ФИО_матери";
            this.фИОматериDataGridViewTextBoxColumn.Name = "фИОматериDataGridViewTextBoxColumn";
            // 
            // MomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 231);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(код_материLabel);
            this.Controls.Add(this.код_материTextBox);
            this.Controls.Add(код_участникаLabel);
            this.Controls.Add(фИО_материLabel);
            this.Controls.Add(this.фИО_материTextBox);
            this.Controls.Add(this.momBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MomEdit";
            this.Text = "MomEdit";
            this.Load += new System.EventHandler(this.MomEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingNavigator)).EndInit();
            this.momBindingNavigator.ResumeLayout(false);
            this.momBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource momBindingSource;
        private TreeDBDataSetTableAdapters.MomTableAdapter momTableAdapter;
        private TreeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator momBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton momBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_материTextBox;
        private System.Windows.Forms.TextBox фИО_материTextBox;
        private TreeDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодматериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучастникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОматериDataGridViewTextBoxColumn;
    }
}