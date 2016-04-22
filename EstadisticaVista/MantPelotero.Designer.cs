namespace EstadisticaVista
{
    partial class MantPelotero
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label poncheLabel;
            System.Windows.Forms.Label hitsLabel;
            System.Windows.Forms.Label carrerasLabel;
            System.Windows.Forms.Label homeRunLabel;
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label posicionIDLabel;
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fKJugadoresLigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbestadisticaDataSetVista = new EstadisticaVista.dbestadisticaDataSetVista();
            this.equiposTableAdapter = new EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.EquiposTableAdapter();
            this.jugadoresTableAdapter = new EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.JugadoresTableAdapter();
            this.tableAdapterManager = new EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.TableAdapterManager();
            this.ligasTableAdapter = new EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.LigasTableAdapter();
            this.posicionesTableAdapter = new EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.PosicionesTableAdapter();
            this.estadisticaDbDataSet = new EstadisticaVista.EstadisticaDbDataSet();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter1 = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.JugadoresTableAdapter();
            this.tableAdapterManager1 = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.poncheTextBox = new System.Windows.Forms.TextBox();
            this.hitsTextBox = new System.Windows.Forms.TextBox();
            this.carrerasTextBox = new System.Windows.Forms.TextBox();
            this.homeRunTextBox = new System.Windows.Forms.TextBox();
            this.equipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.posicionIDComboBox = new System.Windows.Forms.ComboBox();
            this.estadisticaDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter1 = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.EquiposTableAdapter();
            this.posicionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posicionesTableAdapter1 = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.PosicionesTableAdapter();
            this.estadisticaDbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligasTableAdapter1 = new EstadisticaVista.EstadisticaDbDataSetTableAdapters.LigasTableAdapter();
            this.ligasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ligasComboBox = new System.Windows.Forms.ComboBox();
            this.ligasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            poncheLabel = new System.Windows.Forms.Label();
            hitsLabel = new System.Windows.Forms.Label();
            carrerasLabel = new System.Windows.Forms.Label();
            homeRunLabel = new System.Windows.Forms.Label();
            equipoIdLabel = new System.Windows.Forms.Label();
            posicionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fKJugadoresLigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbestadisticaDataSetVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(77, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorra
            // 
            this.btnBorra.Location = new System.Drawing.Point(176, 312);
            this.btnBorra.Name = "btnBorra";
            this.btnBorra.Size = new System.Drawing.Size(75, 23);
            this.btnBorra.TabIndex = 1;
            this.btnBorra.Text = "Borrar";
            this.btnBorra.UseVisualStyleBackColor = true;
            this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Agregar Peloteros";
            // 
            // dbestadisticaDataSetVista
            // 
            this.dbestadisticaDataSetVista.DataSetName = "dbestadisticaDataSetVista";
            this.dbestadisticaDataSetVista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquiposTableAdapter = this.equiposTableAdapter;
            this.tableAdapterManager.JuegosTableAdapter = null;
            this.tableAdapterManager.JugadoresTableAdapter = this.jugadoresTableAdapter;
            this.tableAdapterManager.LigasTableAdapter = this.ligasTableAdapter;
            this.tableAdapterManager.PosicionesTableAdapter = this.posicionesTableAdapter;
            this.tableAdapterManager.TipoEstadisticasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EstadisticaVista.dbestadisticaDataSetVistaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ligasTableAdapter
            // 
            this.ligasTableAdapter.ClearBeforeFill = true;
            // 
            // posicionesTableAdapter
            // 
            this.posicionesTableAdapter.ClearBeforeFill = true;
            // 
            // estadisticaDbDataSet
            // 
            this.estadisticaDbDataSet.DataSetName = "EstadisticaDbDataSet";
            this.estadisticaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.estadisticaDbDataSet;
            // 
            // jugadoresTableAdapter1
            // 
            this.jugadoresTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EquiposTableAdapter = this.equiposTableAdapter1;
            this.tableAdapterManager1.JuegosTableAdapter = null;
            this.tableAdapterManager1.JugadoresTableAdapter = this.jugadoresTableAdapter1;
            this.tableAdapterManager1.LigasTableAdapter = this.ligasTableAdapter1;
            this.tableAdapterManager1.PosicionesTableAdapter = this.posicionesTableAdapter1;
            this.tableAdapterManager1.TipoEstadisticasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = EstadisticaVista.EstadisticaDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(69, 65);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 19;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(122, 62);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 20;
            // 
            // poncheLabel
            // 
            poncheLabel.AutoSize = true;
            poncheLabel.Location = new System.Drawing.Point(69, 91);
            poncheLabel.Name = "poncheLabel";
            poncheLabel.Size = new System.Drawing.Size(47, 13);
            poncheLabel.TabIndex = 20;
            poncheLabel.Text = "Ponche:";
            // 
            // poncheTextBox
            // 
            this.poncheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Ponche", true));
            this.poncheTextBox.Location = new System.Drawing.Point(122, 88);
            this.poncheTextBox.Name = "poncheTextBox";
            this.poncheTextBox.Size = new System.Drawing.Size(100, 20);
            this.poncheTextBox.TabIndex = 21;
            // 
            // hitsLabel
            // 
            hitsLabel.AutoSize = true;
            hitsLabel.Location = new System.Drawing.Point(88, 117);
            hitsLabel.Name = "hitsLabel";
            hitsLabel.Size = new System.Drawing.Size(28, 13);
            hitsLabel.TabIndex = 21;
            hitsLabel.Text = "Hits:";
            // 
            // hitsTextBox
            // 
            this.hitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Hits", true));
            this.hitsTextBox.Location = new System.Drawing.Point(122, 114);
            this.hitsTextBox.Name = "hitsTextBox";
            this.hitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.hitsTextBox.TabIndex = 22;
            // 
            // carrerasLabel
            // 
            carrerasLabel.AutoSize = true;
            carrerasLabel.Location = new System.Drawing.Point(67, 143);
            carrerasLabel.Name = "carrerasLabel";
            carrerasLabel.Size = new System.Drawing.Size(49, 13);
            carrerasLabel.TabIndex = 22;
            carrerasLabel.Text = "Carreras:";
            // 
            // carrerasTextBox
            // 
            this.carrerasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Carreras", true));
            this.carrerasTextBox.Location = new System.Drawing.Point(122, 140);
            this.carrerasTextBox.Name = "carrerasTextBox";
            this.carrerasTextBox.Size = new System.Drawing.Size(100, 20);
            this.carrerasTextBox.TabIndex = 23;
            // 
            // homeRunLabel
            // 
            homeRunLabel.AutoSize = true;
            homeRunLabel.Location = new System.Drawing.Point(55, 169);
            homeRunLabel.Name = "homeRunLabel";
            homeRunLabel.Size = new System.Drawing.Size(61, 13);
            homeRunLabel.TabIndex = 23;
            homeRunLabel.Text = "Home Run:";
            // 
            // homeRunTextBox
            // 
            this.homeRunTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "HomeRun", true));
            this.homeRunTextBox.Location = new System.Drawing.Point(122, 166);
            this.homeRunTextBox.Name = "homeRunTextBox";
            this.homeRunTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeRunTextBox.TabIndex = 24;
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Location = new System.Drawing.Point(61, 195);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(55, 13);
            equipoIdLabel.TabIndex = 24;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // equipoIdComboBox
            // 
            this.equipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "EquipoId", true));
            this.equipoIdComboBox.DataSource = this.equiposBindingSource;
            this.equipoIdComboBox.DisplayMember = "Nombre";
            this.equipoIdComboBox.FormattingEnabled = true;
            this.equipoIdComboBox.Location = new System.Drawing.Point(122, 192);
            this.equipoIdComboBox.Name = "equipoIdComboBox";
            this.equipoIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.equipoIdComboBox.TabIndex = 25;
            this.equipoIdComboBox.ValueMember = "Id";
            // 
            // posicionIDLabel
            // 
            posicionIDLabel.AutoSize = true;
            posicionIDLabel.Location = new System.Drawing.Point(52, 222);
            posicionIDLabel.Name = "posicionIDLabel";
            posicionIDLabel.Size = new System.Drawing.Size(64, 13);
            posicionIDLabel.TabIndex = 25;
            posicionIDLabel.Text = "Posicion ID:";
            // 
            // posicionIDComboBox
            // 
            this.posicionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "PosicionID", true));
            this.posicionIDComboBox.DataSource = this.posicionesBindingSource;
            this.posicionIDComboBox.DisplayMember = "Tipo";
            this.posicionIDComboBox.FormattingEnabled = true;
            this.posicionIDComboBox.Location = new System.Drawing.Point(122, 219);
            this.posicionIDComboBox.Name = "posicionIDComboBox";
            this.posicionIDComboBox.Size = new System.Drawing.Size(100, 21);
            this.posicionIDComboBox.TabIndex = 26;
            this.posicionIDComboBox.ValueMember = "Id";
            // 
            // estadisticaDbDataSetBindingSource
            // 
            this.estadisticaDbDataSetBindingSource.DataSource = this.estadisticaDbDataSet;
            this.estadisticaDbDataSetBindingSource.Position = 0;
            // 
            // jugadoresBindingSource1
            // 
            this.jugadoresBindingSource1.DataMember = "Jugadores";
            this.jugadoresBindingSource1.DataSource = this.estadisticaDbDataSet;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.estadisticaDbDataSet;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // posicionesBindingSource
            // 
            this.posicionesBindingSource.DataMember = "Posiciones";
            this.posicionesBindingSource.DataSource = this.estadisticaDbDataSet;
            // 
            // posicionesTableAdapter1
            // 
            this.posicionesTableAdapter1.ClearBeforeFill = true;
            // 
            // estadisticaDbDataSetBindingSource1
            // 
            this.estadisticaDbDataSetBindingSource1.DataSource = this.estadisticaDbDataSet;
            this.estadisticaDbDataSetBindingSource1.Position = 0;
            // 
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.estadisticaDbDataSetBindingSource1;
            // 
            // ligasTableAdapter1
            // 
            this.ligasTableAdapter1.ClearBeforeFill = true;
            // 
            // ligasBindingSource1
            // 
            this.ligasBindingSource1.DataMember = "Ligas";
            this.ligasBindingSource1.DataSource = this.dbestadisticaDataSetVista;
            // 
            // ligasComboBox
            // 
            this.ligasComboBox.DataSource = this.ligasBindingSource2;
            this.ligasComboBox.DisplayMember = "tipo";
            this.ligasComboBox.FormattingEnabled = true;
            this.ligasComboBox.Location = new System.Drawing.Point(122, 246);
            this.ligasComboBox.Name = "ligasComboBox";
            this.ligasComboBox.Size = new System.Drawing.Size(100, 21);
            this.ligasComboBox.TabIndex = 26;
            this.ligasComboBox.ValueMember = "Id";
            // 
            // ligasBindingSource2
            // 
            this.ligasBindingSource2.DataMember = "Ligas";
            this.ligasBindingSource2.DataSource = this.estadisticaDbDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ligas";
            // 
            // MantPelotero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ligasComboBox);
            this.Controls.Add(posicionIDLabel);
            this.Controls.Add(this.posicionIDComboBox);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdComboBox);
            this.Controls.Add(homeRunLabel);
            this.Controls.Add(this.homeRunTextBox);
            this.Controls.Add(carrerasLabel);
            this.Controls.Add(this.carrerasTextBox);
            this.Controls.Add(hitsLabel);
            this.Controls.Add(this.hitsTextBox);
            this.Controls.Add(poncheLabel);
            this.Controls.Add(this.poncheTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorra);
            this.Controls.Add(this.btnAgregar);
            this.Name = "MantPelotero";
            this.Text = "MantPelotero";
            this.Load += new System.EventHandler(this.MantPelotero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKJugadoresLigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbestadisticaDataSetVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDbDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorra;
        private dbestadisticaDataSetVista dbestadisticaDataSetVista;
        private dbestadisticaDataSetVistaTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private dbestadisticaDataSetVistaTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private dbestadisticaDataSetVistaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private dbestadisticaDataSetVistaTableAdapters.PosicionesTableAdapter posicionesTableAdapter;
        private dbestadisticaDataSetVistaTableAdapters.LigasTableAdapter ligasTableAdapter;
        private System.Windows.Forms.BindingSource fKJugadoresLigaBindingSource;
        private EstadisticaDbDataSet estadisticaDbDataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private EstadisticaDbDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter1;
        private EstadisticaDbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private EstadisticaDbDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox poncheTextBox;
        private System.Windows.Forms.TextBox hitsTextBox;
        private System.Windows.Forms.TextBox carrerasTextBox;
        private System.Windows.Forms.TextBox homeRunTextBox;
        private System.Windows.Forms.ComboBox equipoIdComboBox;
        private System.Windows.Forms.BindingSource jugadoresBindingSource1;
        private System.Windows.Forms.ComboBox posicionIDComboBox;
        private System.Windows.Forms.BindingSource estadisticaDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private EstadisticaDbDataSetTableAdapters.PosicionesTableAdapter posicionesTableAdapter1;
        private System.Windows.Forms.BindingSource posicionesBindingSource;
        private EstadisticaDbDataSetTableAdapters.LigasTableAdapter ligasTableAdapter1;
        private System.Windows.Forms.BindingSource estadisticaDbDataSetBindingSource1;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private System.Windows.Forms.BindingSource ligasBindingSource1;
        private System.Windows.Forms.ComboBox ligasComboBox;
        private System.Windows.Forms.BindingSource ligasBindingSource2;
        private System.Windows.Forms.Label label2;
    }
}