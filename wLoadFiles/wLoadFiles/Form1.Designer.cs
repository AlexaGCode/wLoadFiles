namespace wLoadFiles
{
    partial class frmPlano
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.btnPorLineas = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(58, 77);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(215, 200);
            this.txtArchivo.TabIndex = 0;
            // 
            // dtgGrid
            // 
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgGrid.Location = new System.Drawing.Point(309, 77);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.Size = new System.Drawing.Size(345, 200);
            this.dtgGrid.TabIndex = 1;
            // 
            // btnPorLineas
            // 
            this.btnPorLineas.Location = new System.Drawing.Point(216, 341);
            this.btnPorLineas.Name = "btnPorLineas";
            this.btnPorLineas.Size = new System.Drawing.Size(90, 37);
            this.btnPorLineas.TabIndex = 2;
            this.btnPorLineas.Text = "Linea a Linea";
            this.btnPorLineas.UseVisualStyleBackColor = true;
            this.btnPorLineas.Click += new System.EventHandler(this.btnPorLineas_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(344, 341);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(90, 37);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // frmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 414);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnPorLineas);
            this.Controls.Add(this.dtgGrid);
            this.Controls.Add(this.txtArchivo);
            this.Name = "frmPlano";
            this.Text = "Archivo Plano";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.DataGridView dtgGrid;
        private System.Windows.Forms.Button btnPorLineas;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

