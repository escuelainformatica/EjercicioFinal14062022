namespace WindowsFormsApp2
{
    partial class Form1
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
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridComboBoxColumn gridComboBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridComboBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInsertar = new System.Windows.Forms.Panel();
            this.panelListado = new System.Windows.Forms.Panel();
            this.sfDataGridListado = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sfDataGridDetalle = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelInsertar.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 1;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowDeleting = true;
            this.sfDataGrid1.AllowGrouping = false;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoGenerateColumns = false;
            gridButtonColumn1.AllowDefaultButtonText = true;
            gridButtonColumn1.AllowGrouping = false;
            gridButtonColumn1.AllowResizing = true;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "Borrar";
            gridButtonColumn1.HeaderText = "Borrar";
            gridButtonColumn1.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.MappingName = "Column4";
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Tipodcto";
            gridTextColumn1.MappingName = "Tipodcto";
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Rut";
            gridTextColumn2.MappingName = "Rut";
            gridComboBoxColumn1.AllowGrouping = false;
            gridComboBoxColumn1.AllowResizing = true;
            gridComboBoxColumn1.DisplayMember = "Descrispcion";
            gridComboBoxColumn1.HeaderText = "Producto";
            gridComboBoxColumn1.MappingName = "Idproductos";
            gridComboBoxColumn1.ValueMember = "Idproductos";
            gridComboBoxColumn1.Width = 300D;
            this.sfDataGrid1.Columns.Add(gridButtonColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn2);
            this.sfDataGrid1.Columns.Add(gridComboBoxColumn1);
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 89);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(1081, 213);
            this.sfDataGrid1.TabIndex = 2;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.sfDataGrid1_CellButtonClick);
            this.sfDataGrid1.Click += new System.EventHandler(this.sfDataGrid1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar detalle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem1.Text = "facturas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarToolStripMenuItem.Text = "listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertarToolStripMenuItem.Text = "insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // panelInsertar
            // 
            this.panelInsertar.Controls.Add(this.textBox1);
            this.panelInsertar.Controls.Add(this.button2);
            this.panelInsertar.Controls.Add(this.textBox2);
            this.panelInsertar.Controls.Add(this.button1);
            this.panelInsertar.Controls.Add(this.sfDataGrid1);
            this.panelInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsertar.Location = new System.Drawing.Point(0, 30);
            this.panelInsertar.Name = "panelInsertar";
            this.panelInsertar.Size = new System.Drawing.Size(1107, 654);
            this.panelInsertar.TabIndex = 6;
            this.panelInsertar.Visible = false;
            // 
            // panelListado
            // 
            this.panelListado.Controls.Add(this.sfDataGridDetalle);
            this.panelListado.Controls.Add(this.textBox3);
            this.panelListado.Controls.Add(this.sfDataGridListado);
            this.panelListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListado.Location = new System.Drawing.Point(0, 30);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(1107, 654);
            this.panelListado.TabIndex = 7;
            // 
            // sfDataGridListado
            // 
            this.sfDataGridListado.AccessibleName = "Table";
            this.sfDataGridListado.Location = new System.Drawing.Point(15, 18);
            this.sfDataGridListado.Name = "sfDataGridListado";
            this.sfDataGridListado.PreviewRowHeight = 35;
            this.sfDataGridListado.Size = new System.Drawing.Size(524, 378);
            this.sfDataGridListado.TabIndex = 0;
            this.sfDataGridListado.Text = "sfDataGrid2";
            this.sfDataGridListado.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.sfDataGridListado_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(611, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // sfDataGridDetalle
            // 
            this.sfDataGridDetalle.AccessibleName = "Table";
            gridTextColumn3.HeaderText = "Column1";
            gridTextColumn3.MappingName = "IdproductosNavigation.Descrispcion";
            this.sfDataGridDetalle.Columns.Add(gridTextColumn3);
            this.sfDataGridDetalle.Location = new System.Drawing.Point(611, 62);
            this.sfDataGridDetalle.Name = "sfDataGridDetalle";
            this.sfDataGridDetalle.PreviewRowHeight = 35;
            this.sfDataGridDetalle.Size = new System.Drawing.Size(309, 302);
            this.sfDataGridDetalle.TabIndex = 2;
            this.sfDataGridDetalle.Text = "sfDataGrid2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 684);
            this.Controls.Add(this.panelListado);
            this.Controls.Add(this.panelInsertar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInsertar.ResumeLayout(false);
            this.panelInsertar.PerformLayout();
            this.panelListado.ResumeLayout(false);
            this.panelListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.Panel panelInsertar;
        private System.Windows.Forms.Panel panelListado;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridListado;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridDetalle;
        private System.Windows.Forms.TextBox textBox3;
    }
}

