namespace Desafio02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbTablas = new ComboBox();
            dgvDatos = new DataGridView();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Tabla:";
            // 
            // cmbTablas
            // 
            cmbTablas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTablas.FormattingEnabled = true;
            cmbTablas.Items.AddRange(new object[] { "Producto", "ProductoVendido", "Usuario", "Venta" });
            cmbTablas.Location = new Point(65, 26);
            cmbTablas.Name = "cmbTablas";
            cmbTablas.Size = new Size(378, 28);
            cmbTablas.TabIndex = 1;
            cmbTablas.SelectedIndexChanged += cmbTablas_SelectedIndexChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(8, 66);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(972, 328);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(458, 23);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 32);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(btnNuevo);
            Controls.Add(dgvDatos);
            Controls.Add(cmbTablas);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos - Desafio 2";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTablas;
        private DataGridView dgvDatos;
        private Button btnNuevo;
    }
}
