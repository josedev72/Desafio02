namespace Desafio02
{
    partial class FormVenta
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
            txtIdUsuario = new TextBox();
            label4 = new Label();
            txtComentarios = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(274, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 32);
            btnAceptar.TabIndex = 35;
            btnAceptar.Text = "Modificar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(127, 164);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 32);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtIdUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(127, 97);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(248, 27);
            txtIdUsuario.TabIndex = 31;
            txtIdUsuario.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 104);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 24;
            label4.Text = "Id Usuario";
            // 
            // txtComentarios
            // 
            txtComentarios.BorderStyle = BorderStyle.FixedSingle;
            txtComentarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(127, 64);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(248, 27);
            txtComentarios.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 26;
            label2.Text = "Comentarios";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(127, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(101, 27);
            txtId.TabIndex = 27;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 28;
            label1.Text = "Id";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 223);
            Controls.Add(btnAceptar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdUsuario);
            Controls.Add(label4);
            Controls.Add(txtComentarios);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtIdUsuario;
        private Label label4;
        private TextBox txtComentarios;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}