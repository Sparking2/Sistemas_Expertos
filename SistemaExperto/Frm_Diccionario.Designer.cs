﻿namespace SistemaExperto
{
    partial class Frm_Diccionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Diccionario));
            System.Windows.Forms.Label atomoLabel;
            this.txtBox_atomo = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.localDBDataSet = new SistemaExperto.LocalDBDataSet();
            this.atomosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atomosTableAdapter = new SistemaExperto.LocalDBDataSetTableAdapters.AtomosTableAdapter();
            this.tableAdapterManager = new SistemaExperto.LocalDBDataSetTableAdapters.TableAdapterManager();
            this.atomosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.atomosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.atomosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atomoTextBox = new System.Windows.Forms.TextBox();
            atomoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atomosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atomosBindingNavigator)).BeginInit();
            this.atomosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atomosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_atomo
            // 
            this.txtBox_atomo.Location = new System.Drawing.Point(129, 58);
            this.txtBox_atomo.Name = "txtBox_atomo";
            this.txtBox_atomo.Size = new System.Drawing.Size(165, 20);
            this.txtBox_atomo.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(176, 84);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atomosBindingSource
            // 
            this.atomosBindingSource.DataMember = "Atomos";
            this.atomosBindingSource.DataSource = this.localDBDataSet;
            // 
            // atomosTableAdapter
            // 
            this.atomosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtomosTableAdapter = this.atomosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SistemaExperto.LocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // atomosBindingNavigator
            // 
            this.atomosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.atomosBindingNavigator.BindingSource = this.atomosBindingSource;
            this.atomosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.atomosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.atomosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.atomosBindingNavigatorSaveItem});
            this.atomosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.atomosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.atomosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.atomosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.atomosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.atomosBindingNavigator.Name = "atomosBindingNavigator";
            this.atomosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.atomosBindingNavigator.Size = new System.Drawing.Size(422, 25);
            this.atomosBindingNavigator.TabIndex = 2;
            this.atomosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // atomosBindingNavigatorSaveItem
            // 
            this.atomosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atomosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("atomosBindingNavigatorSaveItem.Image")));
            this.atomosBindingNavigatorSaveItem.Name = "atomosBindingNavigatorSaveItem";
            this.atomosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.atomosBindingNavigatorSaveItem.Text = "Save Data";
            this.atomosBindingNavigatorSaveItem.Click += new System.EventHandler(this.atomosBindingNavigatorSaveItem_Click);
            // 
            // atomosDataGridView
            // 
            this.atomosDataGridView.AutoGenerateColumns = false;
            this.atomosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atomosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.atomosDataGridView.DataSource = this.atomosBindingSource;
            this.atomosDataGridView.Location = new System.Drawing.Point(102, 113);
            this.atomosDataGridView.Name = "atomosDataGridView";
            this.atomosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.atomosDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Atomo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Atomo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // atomoLabel
            // 
            atomoLabel.AutoSize = true;
            atomoLabel.Location = new System.Drawing.Point(99, 25);
            atomoLabel.Name = "atomoLabel";
            atomoLabel.Size = new System.Drawing.Size(40, 13);
            atomoLabel.TabIndex = 4;
            atomoLabel.Text = "Atomo:";
            // 
            // atomoTextBox
            // 
            this.atomoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atomosBindingSource, "Atomo", true));
            this.atomoTextBox.Location = new System.Drawing.Point(145, 22);
            this.atomoTextBox.Name = "atomoTextBox";
            this.atomoTextBox.Size = new System.Drawing.Size(100, 20);
            this.atomoTextBox.TabIndex = 5;
            // 
            // Frm_Diccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 353);
            this.Controls.Add(atomoLabel);
            this.Controls.Add(this.atomoTextBox);
            this.Controls.Add(this.atomosDataGridView);
            this.Controls.Add(this.atomosBindingNavigator);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txtBox_atomo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Diccionario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diccionario";
            this.Load += new System.EventHandler(this.Frm_Diccionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atomosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atomosBindingNavigator)).EndInit();
            this.atomosBindingNavigator.ResumeLayout(false);
            this.atomosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atomosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_atomo;
        private System.Windows.Forms.Button btn_Agregar;
        private LocalDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource atomosBindingSource;
        private LocalDBDataSetTableAdapters.AtomosTableAdapter atomosTableAdapter;
        private LocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator atomosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton atomosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView atomosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox atomoTextBox;
    }
}