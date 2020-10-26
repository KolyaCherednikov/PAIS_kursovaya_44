namespace TreeDB
{
    partial class FEdit
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
            System.Windows.Forms.Label код_семьиLabel;
            System.Windows.Forms.Label код_отцаLabel;
            System.Windows.Forms.Label фИО_отцаLabel;
            System.Windows.Forms.Label код_материLabel;
            System.Windows.Forms.Label фИО_материLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEdit));
            this.treeDBDataSet = new TreeDB.TreeDBDataSet();
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.FamilyTableAdapter();
            this.tableAdapterManager = new TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager();
            this.dadTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.DadTableAdapter();
            this.momTableAdapter = new TreeDB.TreeDBDataSetTableAdapters.MomTableAdapter();
            this.familyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.familyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_семьиTextBox = new System.Windows.Forms.TextBox();
            this.фИО_материTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодсемьиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодотцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОотцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодматериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОматериDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фИО_отцаTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.momBindingSource = new System.Windows.Forms.BindingSource(this.components);
            код_семьиLabel = new System.Windows.Forms.Label();
            код_отцаLabel = new System.Windows.Forms.Label();
            фИО_отцаLabel = new System.Windows.Forms.Label();
            код_материLabel = new System.Windows.Forms.Label();
            фИО_материLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingNavigator)).BeginInit();
            this.familyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_семьиLabel
            // 
            код_семьиLabel.AutoSize = true;
            код_семьиLabel.Location = new System.Drawing.Point(12, 34);
            код_семьиLabel.Name = "код_семьиLabel";
            код_семьиLabel.Size = new System.Drawing.Size(64, 13);
            код_семьиLabel.TabIndex = 1;
            код_семьиLabel.Text = "Код семьи:";
            // 
            // код_отцаLabel
            // 
            код_отцаLabel.AutoSize = true;
            код_отцаLabel.Location = new System.Drawing.Point(12, 60);
            код_отцаLabel.Name = "код_отцаLabel";
            код_отцаLabel.Size = new System.Drawing.Size(55, 13);
            код_отцаLabel.TabIndex = 3;
            код_отцаLabel.Text = "Код отца:";
            // 
            // фИО_отцаLabel
            // 
            фИО_отцаLabel.AutoSize = true;
            фИО_отцаLabel.Location = new System.Drawing.Point(12, 86);
            фИО_отцаLabel.Name = "фИО_отцаLabel";
            фИО_отцаLabel.Size = new System.Drawing.Size(63, 13);
            фИО_отцаLabel.TabIndex = 5;
            фИО_отцаLabel.Text = "ФИО отца:";
            // 
            // код_материLabel
            // 
            код_материLabel.AutoSize = true;
            код_материLabel.Location = new System.Drawing.Point(12, 112);
            код_материLabel.Name = "код_материLabel";
            код_материLabel.Size = new System.Drawing.Size(69, 13);
            код_материLabel.TabIndex = 7;
            код_материLabel.Text = "Код матери:";
            // 
            // фИО_материLabel
            // 
            фИО_материLabel.AutoSize = true;
            фИО_материLabel.Location = new System.Drawing.Point(12, 138);
            фИО_материLabel.Name = "фИО_материLabel";
            фИО_материLabel.Size = new System.Drawing.Size(77, 13);
            фИО_материLabel.TabIndex = 9;
            фИО_материLabel.Text = "ФИО матери:";
            // 
            // treeDBDataSet
            // 
            this.treeDBDataSet.DataSetName = "TreeDBDataSet";
            this.treeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DadTableAdapter = this.dadTableAdapter;
            this.tableAdapterManager.FamilyTableAdapter = this.familyTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.MomTableAdapter = this.momTableAdapter;
            this.tableAdapterManager.PassportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TreeDB.TreeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dadTableAdapter
            // 
            this.dadTableAdapter.ClearBeforeFill = true;
            // 
            // momTableAdapter
            // 
            this.momTableAdapter.ClearBeforeFill = true;
            // 
            // familyBindingNavigator
            // 
            this.familyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.familyBindingNavigator.BindingSource = this.familyBindingSource;
            this.familyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.familyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.familyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.familyBindingNavigatorSaveItem});
            this.familyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.familyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.familyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.familyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.familyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.familyBindingNavigator.Name = "familyBindingNavigator";
            this.familyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.familyBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.familyBindingNavigator.TabIndex = 0;
            this.familyBindingNavigator.Text = "bindingNavigator1";
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
            // familyBindingNavigatorSaveItem
            // 
            this.familyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.familyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("familyBindingNavigatorSaveItem.Image")));
            this.familyBindingNavigatorSaveItem.Name = "familyBindingNavigatorSaveItem";
            this.familyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.familyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.familyBindingNavigatorSaveItem.Click += new System.EventHandler(this.familyBindingNavigatorSaveItem_Click);
            // 
            // код_семьиTextBox
            // 
            this.код_семьиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyBindingSource, "Код_семьи", true));
            this.код_семьиTextBox.Location = new System.Drawing.Point(95, 31);
            this.код_семьиTextBox.Name = "код_семьиTextBox";
            this.код_семьиTextBox.Size = new System.Drawing.Size(197, 20);
            this.код_семьиTextBox.TabIndex = 2;
            // 
            // фИО_материTextBox
            // 
            this.фИО_материTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyBindingSource, "ФИО_матери", true));
            this.фИО_материTextBox.Location = new System.Drawing.Point(95, 135);
            this.фИО_материTextBox.Name = "фИО_материTextBox";
            this.фИО_материTextBox.ReadOnly = true;
            this.фИО_материTextBox.Size = new System.Drawing.Size(197, 20);
            this.фИО_материTextBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсемьиDataGridViewTextBoxColumn,
            this.кодотцаDataGridViewTextBoxColumn,
            this.фИОотцаDataGridViewTextBoxColumn,
            this.кодматериDataGridViewTextBoxColumn,
            this.фИОматериDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.familyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(315, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 178);
            this.dataGridView1.TabIndex = 11;
            // 
            // кодсемьиDataGridViewTextBoxColumn
            // 
            this.кодсемьиDataGridViewTextBoxColumn.DataPropertyName = "Код_семьи";
            this.кодсемьиDataGridViewTextBoxColumn.HeaderText = "Код_семьи";
            this.кодсемьиDataGridViewTextBoxColumn.Name = "кодсемьиDataGridViewTextBoxColumn";
            // 
            // кодотцаDataGridViewTextBoxColumn
            // 
            this.кодотцаDataGridViewTextBoxColumn.DataPropertyName = "Код_отца";
            this.кодотцаDataGridViewTextBoxColumn.HeaderText = "Код_отца";
            this.кодотцаDataGridViewTextBoxColumn.Name = "кодотцаDataGridViewTextBoxColumn";
            // 
            // фИОотцаDataGridViewTextBoxColumn
            // 
            this.фИОотцаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_отца";
            this.фИОотцаDataGridViewTextBoxColumn.HeaderText = "ФИО_отца";
            this.фИОотцаDataGridViewTextBoxColumn.Name = "фИОотцаDataGridViewTextBoxColumn";
            // 
            // кодматериDataGridViewTextBoxColumn
            // 
            this.кодматериDataGridViewTextBoxColumn.DataPropertyName = "Код_матери";
            this.кодматериDataGridViewTextBoxColumn.HeaderText = "Код_матери";
            this.кодматериDataGridViewTextBoxColumn.Name = "кодматериDataGridViewTextBoxColumn";
            // 
            // фИОматериDataGridViewTextBoxColumn
            // 
            this.фИОматериDataGridViewTextBoxColumn.DataPropertyName = "ФИО_матери";
            this.фИОматериDataGridViewTextBoxColumn.HeaderText = "ФИО_матери";
            this.фИОматериDataGridViewTextBoxColumn.Name = "фИОматериDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Подтвердить изменение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyBindingSource, "Код_отца", true));
            this.comboBox1.DataSource = this.dadBindingSource;
            this.comboBox1.DisplayMember = "Код_отца";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Код_отца";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dadBindingSource
            // 
            this.dadBindingSource.DataMember = "Dad";
            this.dadBindingSource.DataSource = this.treeDBDataSet;
            // 
            // фИО_отцаTextBox
            // 
            this.фИО_отцаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyBindingSource, "ФИО_отца", true));
            this.фИО_отцаTextBox.Location = new System.Drawing.Point(95, 83);
            this.фИО_отцаTextBox.Name = "фИО_отцаTextBox";
            this.фИО_отцаTextBox.ReadOnly = true;
            this.фИО_отцаTextBox.Size = new System.Drawing.Size(197, 20);
            this.фИО_отцаTextBox.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyBindingSource, "Код_матери", true));
            this.comboBox2.DataSource = this.momBindingSource;
            this.comboBox2.DisplayMember = "Код_матери";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "Код_матери";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // momBindingSource
            // 
            this.momBindingSource.DataMember = "Mom";
            this.momBindingSource.DataSource = this.treeDBDataSet;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 231);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(код_семьиLabel);
            this.Controls.Add(this.код_семьиTextBox);
            this.Controls.Add(код_отцаLabel);
            this.Controls.Add(фИО_отцаLabel);
            this.Controls.Add(this.фИО_отцаTextBox);
            this.Controls.Add(код_материLabel);
            this.Controls.Add(фИО_материLabel);
            this.Controls.Add(this.фИО_материTextBox);
            this.Controls.Add(this.familyBindingNavigator);
            this.Name = "FEdit";
            this.Text = "FEdit";
            this.Load += new System.EventHandler(this.FEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingNavigator)).EndInit();
            this.familyBindingNavigator.ResumeLayout(false);
            this.familyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeDBDataSet treeDBDataSet;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private TreeDBDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private TreeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator familyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton familyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_семьиTextBox;
        private System.Windows.Forms.TextBox фИО_материTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсемьиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодотцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОотцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодматериDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОматериDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private TreeDBDataSetTableAdapters.DadTableAdapter dadTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dadBindingSource;
        private System.Windows.Forms.TextBox фИО_отцаTextBox;
        private TreeDBDataSetTableAdapters.MomTableAdapter momTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource momBindingSource;
    }
}