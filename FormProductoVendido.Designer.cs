namespace Desafio02
{
    partial class FormProductoVendido
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
            btnAceptar = new Button();
            btnVolver = new Button();
            label5 = new Label();
            txtIdVenta = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(300, 252);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 32);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Modificar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(153, 252);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 32);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 111);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 9;
            label5.Text = "Stock";
            // 
            // txtIdVenta
            // 
            txtIdVenta.BorderStyle = BorderStyle.FixedSingle;
            txtIdVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVenta.Location = new Point(153, 137);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(175, 27);
            txtIdVenta.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 144);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 10;
            label4.Text = "Id Venta";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(153, 104);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(175, 27);
            txtStock.TabIndex = 16;
            txtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIdProducto
            // 
            txtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            txtIdProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProducto.Location = new Point(153, 71);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(248, 27);
            txtIdProducto.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 78);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 12;
            label2.Text = "Id Producto";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(153, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(101, 27);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 45);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 304);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(txtIdVenta);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormProductoVendido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProductoVendido";
            Load += FormProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private Label label5;
        private TextBox txtIdVenta;
        private Label label4;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}