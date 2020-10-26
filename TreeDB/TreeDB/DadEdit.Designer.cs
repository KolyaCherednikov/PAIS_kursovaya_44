namespace TreeDB
{
    partial class DadEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadEdit));
            System.Windows.Forms.Label код_отцаLabel;
            System.Windows.Forms.Label код_участникаLabel;
            System.Windows.Forms.Label фИО_отцаLabel;
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.dadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.DadTableAdapter();
            this.tableAdapterManager = new TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager();
            this.dadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_отцаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_отцаTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MemberTableAdapter();
            this.кодотцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучастникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОотцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_отцаLabel = new System.Windows.Forms.Label();
            код_участникаLabel = new System.Windows.Forms.Label();
            фИО_отцаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingNavigator)).BeginInit();
            this.dadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DadTableAdapter = this.dadTableAdapter;
            this.tableAdapterManager.FamilyTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.MomTableAdapter = null;
            this.tableAdapterManager.PassportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dadBindingNavigator
            // 
            this.dadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dadBindingNavigator.BindingSource = this.dadBindingSource;
            this.dadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dadBindingNavigatorSaveItem});
            this.dadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dadBindingNavigator.Name = "dadBindingNavigator";
            this.dadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dadBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.dadBindingNavigator.TabIndex = 0;
            this.dadBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dadBindingNavigatorSaveItem
            // 
            this.dadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dadBindingNavigatorSaveItem.Image")));
            this.dadBindingNavigatorSaveItem.Name = "dadBindingNavigatorSaveItem";
            this.dadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dadBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dadBindingNavigatorSaveItem.Click += new System.EventHandler(this.dadBindingNavigatorSaveItem_Click);
            // 
            // код_отцаLabel
            // 
            код_отцаLabel.AutoSize = true;
            код_отцаLabel.Location = new System.Drawing.Point(12, 31);
            код_отцаLabel.Name = "код_отцаLabel";
            код_отцаLabel.Size = new System.Drawing.Size(55, 13);
            код_отцаLabel.TabIndex = 1;
            код_отцаLabel.Text = "Код отца:";
            // 
            // код_отцаTextBox
            // 
            this.код_отцаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadBindingSource, "Код_отца", true));
            this.код_отцаTextBox.Location = new System.Drawing.Point(101, 28);
            this.код_отцаTextBox.Name = "код_отцаTextBox";
            this.код_отцаTextBox.Size = new System.Drawing.Size(197, 20);
            this.код_отцаTextBox.TabIndex = 2;
            // 
            // код_участникаLabel
            // 
            код_участникаLabel.AutoSize = true;
            код_участникаLabel.Location = new System.Drawing.Point(12, 57);
            код_участникаLabel.Name = "код_участникаLabel";
            код_участникаLabel.Size = new System.Drawing.Size(83, 13);
            код_участникаLabel.TabIndex = 3;
            код_участникаLabel.Text = "Код участника:";
            // 
            // фИО_отцаLabel
            // 
            фИО_отцаLabel.AutoSize = true;
            фИО_отцаLabel.Location = new System.Drawing.Point(12, 83);
            фИО_отцаLabel.Name = "фИО_отцаLabel";
            фИО_отцаLabel.Size = new System.Drawing.Size(63, 13);
            фИО_отцаLabel.TabIndex = 5;
            фИО_отцаLabel.Text = "ФИО отца:";
            // 
            // фИО_отцаTextBox
            // 
            this.фИО_отцаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadBindingSource, "ФИО_отца", true));
            this.фИО_отцаTextBox.Location = new System.Drawing.Point(101, 80);
            this.фИО_отцаTextBox.Name = "фИО_отцаTextBox";
            this.фИО_отцаTextBox.ReadOnly = true;
            this.фИО_отцаTextBox.Size = new System.Drawing.Size(197, 20);
            this.фИО_отцаTextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодотцаDataGridViewTextBoxColumn,
            this.кодучастникаDataGridViewTextBoxColumn,
            this.фИОотцаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(315, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 178);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Подтвердить изменение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dadBindingSource, "Код_участника", true));
            this.comboBox1.DataSource = this.memberBindingSource;
            this.comboBox1.DisplayMember = "Код";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // кодотцаDataGridViewTextBoxColumn
            // 
            this.кодотцаDataGridViewTextBoxColumn.DataPropertyName = "Код_отца";
            this.кодотцаDataGridViewTextBoxColumn.HeaderText = "Код_отца";
            this.кодотцаDataGridViewTextBoxColumn.Name = "кодотцаDataGridViewTextBoxColumn";
            // 
            // кодучастникаDataGridViewTextBoxColumn
            // 
            this.кодучастникаDataGridViewTextBoxColumn.DataPropertyName = "Код_участника";
            this.кодучастникаDataGridViewTextBoxColumn.HeaderText = "Код_участника";
            this.кодучастникаDataGridViewTextBoxColumn.Name = "кодучастникаDataGridViewTextBoxColumn";
            // 
            // фИОотцаDataGridViewTextBoxColumn
            // 
            this.фИОотцаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_отца";
            this.фИОотцаDataGridViewTextBoxColumn.HeaderText = "ФИО_отца";
            this.фИОотцаDataGridViewTextBoxColumn.Name = "фИОотцаDataGridViewTextBoxColumn";
            // 
            // DadEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 231);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(код_отцаLabel);
            this.Controls.Add(this.код_отцаTextBox);
            this.Controls.Add(код_участникаLabel);
            this.Controls.Add(фИО_отцаLabel);
            this.Controls.Add(this.фИО_отцаTextBox);
            this.Controls.Add(this.dadBindingNavigator);
            this.Name = "DadEdit";
            this.Text = "DadEdit";
            this.Load += new System.EventHandler(this.DadEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingNavigator)).EndInit();
            this.dadBindingNavigator.ResumeLayout(false);
            this.dadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource dadBindingSource;
        private TreeDBDataSetTableAdapters.DadTableAdapter dadTableAdapter;
        private TreeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dadBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_отцаTextBox;
        private System.Windows.Forms.TextBox фИО_отцаTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TreeDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодотцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучастникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОотцаDataGridViewTextBoxColumn;
    }
}