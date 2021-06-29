namespace FerreteriaDB
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label rIFLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tlfLabel;
            System.Windows.Forms.Label ciudadLabel;
            this.ferreteriaDBDataSet = new FerreteriaDB.FerreteriaDBDataSet();
            this.distribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribuidoresTableAdapter = new FerreteriaDB.FerreteriaDBDataSetTableAdapters.DistribuidoresTableAdapter();
            this.tableAdapterManager = new FerreteriaDB.FerreteriaDBDataSetTableAdapters.TableAdapterManager();
            this.distribuidoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.distribuidoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.distribuidoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIFTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tlfTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            rIFLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tlfLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingNavigator)).BeginInit();
            this.distribuidoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ferreteriaDBDataSet
            // 
            this.ferreteriaDBDataSet.DataSetName = "FerreteriaDBDataSet";
            this.ferreteriaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distribuidoresBindingSource
            // 
            this.distribuidoresBindingSource.DataMember = "Distribuidores";
            this.distribuidoresBindingSource.DataSource = this.ferreteriaDBDataSet;
            // 
            // distribuidoresTableAdapter
            // 
            this.distribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistribuidoresTableAdapter = this.distribuidoresTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FerreteriaDB.FerreteriaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // distribuidoresBindingNavigator
            // 
            this.distribuidoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.distribuidoresBindingNavigator.BindingSource = this.distribuidoresBindingSource;
            this.distribuidoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.distribuidoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.distribuidoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.distribuidoresBindingNavigatorSaveItem});
            this.distribuidoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.distribuidoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.distribuidoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.distribuidoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.distribuidoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.distribuidoresBindingNavigator.Name = "distribuidoresBindingNavigator";
            this.distribuidoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.distribuidoresBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.distribuidoresBindingNavigator.TabIndex = 0;
            this.distribuidoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // distribuidoresBindingNavigatorSaveItem
            // 
            this.distribuidoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.distribuidoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("distribuidoresBindingNavigatorSaveItem.Image")));
            this.distribuidoresBindingNavigatorSaveItem.Name = "distribuidoresBindingNavigatorSaveItem";
            this.distribuidoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.distribuidoresBindingNavigatorSaveItem.Text = "Guardar datos";
            this.distribuidoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.distribuidoresBindingNavigatorSaveItem_Click);
            // 
            // distribuidoresDataGridView
            // 
            this.distribuidoresDataGridView.AutoGenerateColumns = false;
            this.distribuidoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distribuidoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.distribuidoresDataGridView.DataSource = this.distribuidoresBindingSource;
            this.distribuidoresDataGridView.Location = new System.Drawing.Point(340, 28);
            this.distribuidoresDataGridView.Name = "distribuidoresDataGridView";
            this.distribuidoresDataGridView.Size = new System.Drawing.Size(480, 445);
            this.distribuidoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RIF";
            this.dataGridViewTextBoxColumn1.HeaderText = "RIF";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tlf";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tlf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // rIFLabel
            // 
            rIFLabel.AutoSize = true;
            rIFLabel.Location = new System.Drawing.Point(136, 162);
            rIFLabel.Name = "rIFLabel";
            rIFLabel.Size = new System.Drawing.Size(27, 13);
            rIFLabel.TabIndex = 2;
            rIFLabel.Text = "RIF:";
            // 
            // rIFTextBox
            // 
            this.rIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distribuidoresBindingSource, "RIF", true));
            this.rIFTextBox.Location = new System.Drawing.Point(169, 159);
            this.rIFTextBox.Name = "rIFTextBox";
            this.rIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.rIFTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(116, 215);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distribuidoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(169, 212);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // tlfLabel
            // 
            tlfLabel.AutoSize = true;
            tlfLabel.Location = new System.Drawing.Point(141, 272);
            tlfLabel.Name = "tlfLabel";
            tlfLabel.Size = new System.Drawing.Size(22, 13);
            tlfLabel.TabIndex = 6;
            tlfLabel.Text = "Tlf:";
            // 
            // tlfTextBox
            // 
            this.tlfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distribuidoresBindingSource, "Tlf", true));
            this.tlfTextBox.Location = new System.Drawing.Point(169, 269);
            this.tlfTextBox.Name = "tlfTextBox";
            this.tlfTextBox.Size = new System.Drawing.Size(100, 20);
            this.tlfTextBox.TabIndex = 7;
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(120, 331);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 8;
            ciudadLabel.Text = "Ciudad:";
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distribuidoresBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(169, 328);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciudadTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(rIFLabel);
            this.Controls.Add(this.rIFTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tlfLabel);
            this.Controls.Add(this.tlfTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(this.distribuidoresDataGridView);
            this.Controls.Add(this.distribuidoresBindingNavigator);
            this.Name = "Form3";
            this.Text = "Distribuidores";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingNavigator)).EndInit();
            this.distribuidoresBindingNavigator.ResumeLayout(false);
            this.distribuidoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FerreteriaDBDataSet ferreteriaDBDataSet;
        private System.Windows.Forms.BindingSource distribuidoresBindingSource;
        private FerreteriaDBDataSetTableAdapters.DistribuidoresTableAdapter distribuidoresTableAdapter;
        private FerreteriaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator distribuidoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton distribuidoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView distribuidoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox rIFTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox tlfTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}