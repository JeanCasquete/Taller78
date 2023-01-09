namespace Taller78
{
    partial class FormTransaccion
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
            this.textpass = new System.Windows.Forms.TextBox();
            this.textpuerto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textsaldo1 = new System.Windows.Forms.TextBox();
            this.textsaldo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaldo = new System.Windows.Forms.Button();
            this.textorigen = new System.Windows.Forms.TextBox();
            this.textdestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTransaccionMala = new System.Windows.Forms.Button();
            this.buttonTransaccionBuena = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(455, 15);
            this.textpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(175, 31);
            this.textpass.TabIndex = 0;
            this.textpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textpass.TextChanged += new System.EventHandler(this.textpass_TextChanged);
            // 
            // textpuerto
            // 
            this.textpuerto.Location = new System.Drawing.Point(455, 93);
            this.textpuerto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpuerto.Name = "textpuerto";
            this.textpuerto.Size = new System.Drawing.Size(175, 31);
            this.textpuerto.TabIndex = 1;
            this.textpuerto.Text = "5432";
            this.textpuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña de tu postgreSQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(116, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto de la instancia de PostgreSQL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(332, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaccion Transferencia Bancaria";
            // 
            // textsaldo1
            // 
            this.textsaldo1.Location = new System.Drawing.Point(309, 212);
            this.textsaldo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textsaldo1.Name = "textsaldo1";
            this.textsaldo1.Size = new System.Drawing.Size(155, 31);
            this.textsaldo1.TabIndex = 5;
            // 
            // textsaldo2
            // 
            this.textsaldo2.Location = new System.Drawing.Point(309, 271);
            this.textsaldo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textsaldo2.Name = "textsaldo2";
            this.textsaldo2.Size = new System.Drawing.Size(155, 31);
            this.textsaldo2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(121, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo cuenta ID 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(121, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saldo cuenta ID 2";
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaldo.Location = new System.Drawing.Point(695, 216);
            this.buttonSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(161, 89);
            this.buttonSaldo.TabIndex = 9;
            this.buttonSaldo.Text = "Consultar Saldo";
            this.buttonSaldo.UseVisualStyleBackColor = false;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // textorigen
            // 
            this.textorigen.Location = new System.Drawing.Point(201, 350);
            this.textorigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textorigen.Name = "textorigen";
            this.textorigen.Size = new System.Drawing.Size(153, 31);
            this.textorigen.TabIndex = 10;
            // 
            // textdestino
            // 
            this.textdestino.Location = new System.Drawing.Point(718, 350);
            this.textdestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textdestino.Name = "textdestino";
            this.textdestino.Size = new System.Drawing.Size(153, 31);
            this.textdestino.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(-1, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID de la cuenta origen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(508, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID de la cuenta destino";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(201, 405);
            this.textValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(153, 31);
            this.textValor.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(46, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor a transferir";
            // 
            // buttonTransaccionMala
            // 
            this.buttonTransaccionMala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTransaccionMala.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTransaccionMala.Location = new System.Drawing.Point(85, 464);
            this.buttonTransaccionMala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransaccionMala.Name = "buttonTransaccionMala";
            this.buttonTransaccionMala.Size = new System.Drawing.Size(310, 36);
            this.buttonTransaccionMala.TabIndex = 16;
            this.buttonTransaccionMala.Text = "Transferir (Modo no transaccional)";
            this.buttonTransaccionMala.UseVisualStyleBackColor = false;
            this.buttonTransaccionMala.Click += new System.EventHandler(this.buttonTransaccionMala_Click);
            // 
            // buttonTransaccionBuena
            // 
            this.buttonTransaccionBuena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTransaccionBuena.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTransaccionBuena.Location = new System.Drawing.Point(561, 464);
            this.buttonTransaccionBuena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTransaccionBuena.Name = "buttonTransaccionBuena";
            this.buttonTransaccionBuena.Size = new System.Drawing.Size(310, 36);
            this.buttonTransaccionBuena.TabIndex = 17;
            this.buttonTransaccionBuena.Text = "Transferir (Modo  transaccional)";
            this.buttonTransaccionBuena.UseVisualStyleBackColor = false;
            this.buttonTransaccionBuena.Click += new System.EventHandler(this.buttonTransaccionBuena_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(638, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Puerto tipico de PostgreSQL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(638, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Contraseña segun su instalacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(257, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Usuario de postres";
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(455, 54);
            this.textusuario.Margin = new System.Windows.Forms.Padding(4);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(175, 31);
            this.textusuario.TabIndex = 21;
            this.textusuario.Text = "postgres";
            this.textusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(638, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Usuario tipico de postgres";
            // 
            // FormTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 515);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTransaccionBuena);
            this.Controls.Add(this.buttonTransaccionMala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textdestino);
            this.Controls.Add(this.textorigen);
            this.Controls.Add(this.buttonSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textsaldo2);
            this.Controls.Add(this.textsaldo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpuerto);
            this.Controls.Add(this.textpass);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTransaccion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTransaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox textpass;
        public TextBox textpuerto;
        public TextBox textsaldo1;
        public TextBox textsaldo2;
        public Button buttonSaldo;
        public TextBox textorigen;
        public TextBox textdestino;
        public TextBox textValor;
        public Button buttonTransaccionMala;
        public Button buttonTransaccionBuena;
        private Label label9;
        private Label label10;
        private Label label11;
        public TextBox textusuario;
        private Label label12;
    }
}