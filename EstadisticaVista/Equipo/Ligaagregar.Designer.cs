namespace EstadisticaVista.Equipo
{
    partial class Ligaagregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ligaagregar));
            System.Windows.Forms.Label tipoLabel;
            this.estadisticaDbDataSet = new EstadisticaVista.EstadisticaDbDataSet();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligasTableAdapter = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.LigasTableAdapter();
            this.tableAdapterManager = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.TableAdapterManager();
            this.ligasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ligasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingNavigator)).BeginInit();
            this.ligasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // estadisticaDbDataSet
            // 
            this.estadisticaDbDataSet.DataSetName = "EstadisticaDbDataSet";
            this.estadisticaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.estadisticaDbDataSet;
            // 
            // ligasTableAdapter
            // 
            this.ligasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquiposTableAdapter = null;
            this.tableAdapterManager.JuegosTableAdapter = null;
            this.tableAdapterManager.JugadoresTableAdapter = null;
            this.tableAdapterManager.LigasTableAdapter = this.ligasTableAdapter;
            this.tableAdapterManager.PosicionesTableAdapter = null;
            this.tableAdapterManager.TipoEstadisticasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EstadisticaVista.EstadisticaDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ligasBindingNavigator
            // 
            this.ligasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ligasBindingNavigator.BindingSource = this.ligasBindingSource;
            this.ligasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ligasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ligasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ligasBindingNavigatorSaveItem});
            this.ligasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ligasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ligasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ligasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ligasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ligasBindingNavigator.Name = "ligasBindingNavigator";
            this.ligasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ligasBindingNavigator.Size = new System.Drawing.Size(287, 25);
            this.ligasBindingNavigator.TabIndex = 0;
            this.ligasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ligasBindingNavigatorSaveItem
            // 
            this.ligasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ligasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ligasBindingNavigatorSaveItem.Image")));
            this.ligasBindingNavigatorSaveItem.Name = "ligasBindingNavigatorSaveItem";
            this.ligasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ligasBindingNavigatorSaveItem.Text = "Save Data";
            this.ligasBindingNavigatorSaveItem.Click += new System.EventHandler(this.ligasBindingNavigatorSaveItem_Click);
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(59, 83);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(27, 13);
            tipoLabel.TabIndex = 1;
            tipoLabel.Text = "Liga";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(92, 76);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(154, 155);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ligaagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.ligasBindingNavigator);
            this.Name = "Ligaagregar";
            this.Text = "Ligaagregar";
            this.Load += new System.EventHandler(this.Ligaagregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingNavigator)).EndInit();
            this.ligasBindingNavigator.ResumeLayout(false);
            this.ligasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EstadisticaDbDataSet estadisticaDbDataSet;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private EstadisticaDbDataSetTableAdapters.LigasTableAdapter ligasTableAdapter;
        private EstadisticaDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ligasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ligasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnborrar;
    }
}