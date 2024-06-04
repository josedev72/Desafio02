namespace Desafio02
{
    partial class FormProducto
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
            label1 = new Label();
            txtId = new TextBox();
            btnVolver = new Button();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            txtPrecioVenta = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtIdUsuario = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(127, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(101, 27);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(127, 238);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 32);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(127, 57);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(248, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 97);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 0;
            label3.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(127, 90);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(175, 27);
            txtCosto.TabIndex = 2;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 130);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 0;
            label4.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(127, 123);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(175, 27);
            txtPrecioVenta.TabIndex = 3;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 163);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 0;
            label5.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(127, 156);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(101, 27);
            txtStock.TabIndex = 4;
            txtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 196);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 0;
            label6.Text = "Id Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtIdUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(127, 189);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(101, 27);
            txtIdUsuario.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(274, 238);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 32);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Modificar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 315);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label4);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProducto";
            Load += FormProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnVolver;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtCosto;
        private Label label4;
        private TextBox txtPrecioVenta;
        private Label label5;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnAceptar;
    }
}