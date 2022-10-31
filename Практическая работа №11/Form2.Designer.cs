
namespace Практическая_работа__11
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDObslyjivanieclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tovar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практика_accessDataSet = new Практическая_работа__11.Практика_accessDataSet();
            this.ID_Proverka_tovara = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.проверкаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Clients = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Predlojenie_pered_pokypkoi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.предложенияПередПокупкойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обслуживаниеКлиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обслуживание_клиентовTableAdapter = new Практическая_работа__11.Практика_accessDataSetTableAdapters.Обслуживание_клиентовTableAdapter();
            this.товарTableAdapter = new Практическая_работа__11.Практика_accessDataSetTableAdapters.ТоварTableAdapter();
            this.проверка_товараTableAdapter = new Практическая_работа__11.Практика_accessDataSetTableAdapters.Проверка_товараTableAdapter();
            this.клиентыTableAdapter = new Практическая_работа__11.Практика_accessDataSetTableAdapters.КлиентыTableAdapter();
            this.предложения_перед_покупкойTableAdapter = new Практическая_работа__11.Практика_accessDataSetTableAdapters.Предложения_перед_покупкойTableAdapter();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика_accessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проверкаТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предложенияПередПокупкойBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеКлиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обслуживание клиентов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObslyjivanieclientsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.ID_Tovar,
            this.ID_Proverka_tovara,
            this.ID_Clients,
            this.ID_Predlojenie_pered_pokypkoi});
            this.dataGridView1.DataSource = this.обслуживаниеКлиентовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDObslyjivanieclientsDataGridViewTextBoxColumn
            // 
            this.iDObslyjivanieclientsDataGridViewTextBoxColumn.DataPropertyName = "ID_Obslyjivanie_clients";
            this.iDObslyjivanieclientsDataGridViewTextBoxColumn.HeaderText = "ID_Obslyjivanie_clients";
            this.iDObslyjivanieclientsDataGridViewTextBoxColumn.Name = "iDObslyjivanieclientsDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // ID_Tovar
            // 
            this.ID_Tovar.DataPropertyName = "ID_Tovar";
            this.ID_Tovar.DataSource = this.товарBindingSource;
            this.ID_Tovar.DisplayMember = "Naimenovanie tovara";
            this.ID_Tovar.HeaderText = "ID_Tovar";
            this.ID_Tovar.Name = "ID_Tovar";
            this.ID_Tovar.ValueMember = "ID_Tovar";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.практика_accessDataSet;
            // 
            // практика_accessDataSet
            // 
            this.практика_accessDataSet.DataSetName = "Практика_accessDataSet";
            this.практика_accessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Proverka_tovara
            // 
            this.ID_Proverka_tovara.DataPropertyName = "ID_Proverka_tovara";
            this.ID_Proverka_tovara.DataSource = this.проверкаТовараBindingSource;
            this.ID_Proverka_tovara.DisplayMember = "Proverka tovara pered prodajey";
            this.ID_Proverka_tovara.HeaderText = "ID_Proverka_tovara";
            this.ID_Proverka_tovara.Name = "ID_Proverka_tovara";
            this.ID_Proverka_tovara.ValueMember = "ID_Proverka_tovara";
            // 
            // проверкаТовараBindingSource
            // 
            this.проверкаТовараBindingSource.DataMember = "Проверка товара";
            this.проверкаТовараBindingSource.DataSource = this.практика_accessDataSet;
            // 
            // ID_Clients
            // 
            this.ID_Clients.DataPropertyName = "ID_Clients";
            this.ID_Clients.DataSource = this.клиентыBindingSource;
            this.ID_Clients.DisplayMember = "FIO";
            this.ID_Clients.HeaderText = "ID_Clients";
            this.ID_Clients.Name = "ID_Clients";
            this.ID_Clients.ValueMember = "ID_Clients";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.практика_accessDataSet;
            // 
            // ID_Predlojenie_pered_pokypkoi
            // 
            this.ID_Predlojenie_pered_pokypkoi.DataPropertyName = "ID_Predlojenie_pered_pokypkoi";
            this.ID_Predlojenie_pered_pokypkoi.DataSource = this.предложенияПередПокупкойBindingSource;
            this.ID_Predlojenie_pered_pokypkoi.DisplayMember = "Dopolnenya";
            this.ID_Predlojenie_pered_pokypkoi.HeaderText = "ID_Predlojenie_pered_pokypkoi";
            this.ID_Predlojenie_pered_pokypkoi.Name = "ID_Predlojenie_pered_pokypkoi";
            this.ID_Predlojenie_pered_pokypkoi.ValueMember = "ID_Predlojenie_pered_pokypkoi";
            // 
            // предложенияПередПокупкойBindingSource
            // 
            this.предложенияПередПокупкойBindingSource.DataMember = "Предложения перед покупкой";
            this.предложенияПередПокупкойBindingSource.DataSource = this.практика_accessDataSet;
            // 
            // обслуживаниеКлиентовBindingSource
            // 
            this.обслуживаниеКлиентовBindingSource.DataMember = "Обслуживание клиентов";
            this.обслуживаниеКлиентовBindingSource.DataSource = this.практика_accessDataSet;
            // 
            // обслуживание_клиентовTableAdapter
            // 
            this.обслуживание_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // проверка_товараTableAdapter
            // 
            this.проверка_товараTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // предложения_перед_покупкойTableAdapter
            // 
            this.предложения_перед_покупкойTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.обслуживаниеКлиентовBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(5, 197);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(604, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(68, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Доп.Информация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Обслуживание клиентов";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практика_accessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проверкаТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предложенияПередПокупкойBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеКлиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Практика_accessDataSet практика_accessDataSet;
        private System.Windows.Forms.BindingSource обслуживаниеКлиентовBindingSource;
        private Практика_accessDataSetTableAdapters.Обслуживание_клиентовTableAdapter обслуживание_клиентовTableAdapter;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Практика_accessDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.BindingSource проверкаТовараBindingSource;
        private Практика_accessDataSetTableAdapters.Проверка_товараTableAdapter проверка_товараTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Практика_accessDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource предложенияПередПокупкойBindingSource;
        private Практика_accessDataSetTableAdapters.Предложения_перед_покупкойTableAdapter предложения_перед_покупкойTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObslyjivanieclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tovar;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Proverka_tovara;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Clients;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Predlojenie_pered_pokypkoi;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}