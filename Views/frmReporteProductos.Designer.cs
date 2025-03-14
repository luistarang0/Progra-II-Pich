namespace InvSis.Views
{
    partial class frmReporteProductos
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
            lbReporteProductos = new Label();
            dataGridView1 = new DataGridView();
            btnGenerarReporteProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbReporteProductos
            // 
            lbReporteProductos.BackColor = SystemColors.InactiveCaption;
            lbReporteProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbReporteProductos.Location = new Point(12, 9);
            lbReporteProductos.Name = "lbReporteProductos";
            lbReporteProductos.Size = new Size(1458, 47);
            lbReporteProductos.TabIndex = 0;
            lbReporteProductos.Text = "Reporte de productos";
            lbReporteProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1458, 722);
            dataGridView1.TabIndex = 1;
            // 
            // btnGenerarReporteProductos
            // 
            btnGenerarReporteProductos.Location = new Point(1241, 802);
            btnGenerarReporteProductos.Name = "btnGenerarReporteProductos";
            btnGenerarReporteProductos.Size = new Size(156, 29);
            btnGenerarReporteProductos.TabIndex = 2;
            btnGenerarReporteProductos.Text = "Generar reporte";
            btnGenerarReporteProductos.UseVisualStyleBackColor = true;
            // 
            // frmReporteProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(btnGenerarReporteProductos);
            Controls.Add(dataGridView1);
            Controls.Add(lbReporteProductos);
            Name = "frmReporteProductos";
            Text = "frmReporteProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbReporteProductos;
        private DataGridView dataGridView1;
        private Button btnGenerarReporteProductos;
    }
}