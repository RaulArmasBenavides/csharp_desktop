namespace CapaPresentacion.View
{
    partial class FrmEquipo
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
            System.Windows.Forms.Label sOLabel;
            System.Windows.Forms.Label procesadorLabel;
            System.Windows.Forms.Label rAMLabel;
            System.Windows.Forms.Label tarjetaMadreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarjetaMadreTextBox = new System.Windows.Forms.TextBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcongresoDataSet = new CapaPresentacion.bdcongresoDataSet();
            this.rAMTextBox = new System.Windows.Forms.TextBox();
            this.procesadorTextBox = new System.Windows.Forms.TextBox();
            this.sOTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.equipoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.equipoTableAdapter = new CapaPresentacion.bdcongresoDataSetTableAdapters.EquipoTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.bdcongresoDataSetTableAdapters.TableAdapterManager();
            this.equipoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.equipoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nombreLabel = new System.Windows.Forms.Label();
            sOLabel = new System.Windows.Forms.Label();
            procesadorLabel = new System.Windows.Forms.Label();
            rAMLabel = new System.Windows.Forms.Label();
            tarjetaMadreLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcongresoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingNavigator)).BeginInit();
            this.equipoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(106, 126);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // sOLabel
            // 
            sOLabel.AutoSize = true;
            sOLabel.Location = new System.Drawing.Point(130, 162);
            sOLabel.Name = "sOLabel";
            sOLabel.Size = new System.Drawing.Size(32, 17);
            sOLabel.TabIndex = 6;
            sOLabel.Text = "SO:";
            // 
            // procesadorLabel
            // 
            procesadorLabel.AutoSize = true;
            procesadorLabel.Location = new System.Drawing.Point(77, 199);
            procesadorLabel.Name = "procesadorLabel";
            procesadorLabel.Size = new System.Drawing.Size(85, 17);
            procesadorLabel.TabIndex = 8;
            procesadorLabel.Text = "Procesador:";
            // 
            // rAMLabel
            // 
            rAMLabel.AutoSize = true;
            rAMLabel.Location = new System.Drawing.Point(120, 235);
            rAMLabel.Name = "rAMLabel";
            rAMLabel.Size = new System.Drawing.Size(42, 17);
            rAMLabel.TabIndex = 10;
            rAMLabel.Text = "RAM:";
            // 
            // tarjetaMadreLabel
            // 
            tarjetaMadreLabel.AutoSize = true;
            tarjetaMadreLabel.Location = new System.Drawing.Point(61, 271);
            tarjetaMadreLabel.Name = "tarjetaMadreLabel";
            tarjetaMadreLabel.Size = new System.Drawing.Size(101, 17);
            tarjetaMadreLabel.TabIndex = 12;
            tarjetaMadreLabel.Text = "Tarjeta Madre:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(511, 427);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(686, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(608, 23);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 54);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(524, 23);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 54);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(435, 23);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 54);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(350, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 54);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tarjetaMadreLabel);
            this.groupBox1.Controls.Add(this.tarjetaMadreTextBox);
            this.groupBox1.Controls.Add(rAMLabel);
            this.groupBox1.Controls.Add(this.rAMTextBox);
            this.groupBox1.Controls.Add(procesadorLabel);
            this.groupBox1.Controls.Add(this.procesadorTextBox);
            this.groupBox1.Controls.Add(sOLabel);
            this.groupBox1.Controls.Add(this.sOTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.equipoDataGridView);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtidentificador);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(82, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1115, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de los Equipos";
            // 
            // tarjetaMadreTextBox
            // 
            this.tarjetaMadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "TarjetaMadre", true));
            this.tarjetaMadreTextBox.Location = new System.Drawing.Point(174, 268);
            this.tarjetaMadreTextBox.Name = "tarjetaMadreTextBox";
            this.tarjetaMadreTextBox.Size = new System.Drawing.Size(100, 22);
            this.tarjetaMadreTextBox.TabIndex = 13;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.bdcongresoDataSet;
            // 
            // bdcongresoDataSet
            // 
            this.bdcongresoDataSet.DataSetName = "bdcongresoDataSet";
            this.bdcongresoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAMTextBox
            // 
            this.rAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "RAM", true));
            this.rAMTextBox.Location = new System.Drawing.Point(174, 235);
            this.rAMTextBox.Name = "rAMTextBox";
            this.rAMTextBox.Size = new System.Drawing.Size(100, 22);
            this.rAMTextBox.TabIndex = 11;
            // 
            // procesadorTextBox
            // 
            this.procesadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Procesador", true));
            this.procesadorTextBox.Location = new System.Drawing.Point(174, 196);
            this.procesadorTextBox.Name = "procesadorTextBox";
            this.procesadorTextBox.Size = new System.Drawing.Size(100, 22);
            this.procesadorTextBox.TabIndex = 9;
            // 
            // sOTextBox
            // 
            this.sOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "SO", true));
            this.sOTextBox.Location = new System.Drawing.Point(174, 159);
            this.sOTextBox.Name = "sOTextBox";
            this.sOTextBox.Size = new System.Drawing.Size(100, 22);
            this.sOTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(174, 121);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 5;
            // 
            // equipoDataGridView
            // 
            this.equipoDataGridView.AutoGenerateColumns = false;
            this.equipoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.equipoDataGridView.DataSource = this.equipoBindingSource;
            this.equipoDataGridView.Location = new System.Drawing.Point(413, 79);
            this.equipoDataGridView.Name = "equipoDataGridView";
            this.equipoDataGridView.RowTemplate.Height = 24;
            this.equipoDataGridView.Size = new System.Drawing.Size(622, 236);
            this.equipoDataGridView.TabIndex = 3;
            this.equipoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEquipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEquipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SO";
            this.dataGridViewTextBoxColumn3.HeaderText = "SO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Procesador";
            this.dataGridViewTextBoxColumn4.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RAM";
            this.dataGridViewTextBoxColumn5.HeaderText = "RAM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TarjetaMadre";
            this.dataGridViewTextBoxColumn6.HeaderText = "TarjetaMadre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtidentificador
            // 
            this.txtidentificador.Location = new System.Drawing.Point(133, 44);
            this.txtidentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(189, 22);
            this.txtidentificador.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Descripcion",
            "Fecha"});
            this.comboBox1.Location = new System.Drawing.Point(29, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipoTableAdapter = this.equipoTableAdapter;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.bdcongresoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // equipoBindingNavigator
            // 
            this.equipoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipoBindingNavigator.BindingSource = this.equipoBindingSource;
            this.equipoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.equipoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.equipoBindingNavigatorSaveItem});
            this.equipoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipoBindingNavigator.Name = "equipoBindingNavigator";
            this.equipoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipoBindingNavigator.Size = new System.Drawing.Size(1210, 27);
            this.equipoBindingNavigator.TabIndex = 8;
            this.equipoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // equipoBindingNavigatorSaveItem
            // 
            this.equipoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equipoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipoBindingNavigatorSaveItem.Image")));
            this.equipoBindingNavigatorSaveItem.Name = "equipoBindingNavigatorSaveItem";
            this.equipoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.equipoBindingNavigatorSaveItem.Text = "Save Data";
            this.equipoBindingNavigatorSaveItem.Click += new System.EventHandler(this.equipoBindingNavigatorSaveItem_Click);
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 574);
            this.Controls.Add(this.equipoBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEquipo";
            this.Text = "MANTENEDOR DE EQUIPOS";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcongresoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingNavigator)).EndInit();
            this.equipoBindingNavigator.ResumeLayout(false);
            this.equipoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.ComboBox comboBox1;
        private bdcongresoDataSet bdcongresoDataSet;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private bdcongresoDataSetTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private bdcongresoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equipoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton equipoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tarjetaMadreTextBox;
        private System.Windows.Forms.TextBox rAMTextBox;
        private System.Windows.Forms.TextBox procesadorTextBox;
        private System.Windows.Forms.TextBox sOTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridView equipoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}