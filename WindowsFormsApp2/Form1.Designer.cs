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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridComboBoxColumn gridComboBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridComboBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 63);
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
            gridComboBoxColumn1.HeaderText = "Column4";
            gridComboBoxColumn1.MappingName = "Idproductos";
            gridComboBoxColumn1.ValueMember = "Idproductos";
            gridComboBoxColumn1.Width = 300D;
            this.sfDataGrid1.Columns.Add(gridTextColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn2);
            this.sfDataGrid1.Columns.Add(gridComboBoxColumn1);
            this.sfDataGrid1.Location = new System.Drawing.Point(77, 108);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.Size = new System.Drawing.Size(711, 307);
            this.sfDataGrid1.TabIndex = 2;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.Click += new System.EventHandler(this.sfDataGrid1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Descrispcion";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Idproductos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

