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
            this.SuspendLayout();
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(363, 24);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(141, 27);
            this.textpass.TabIndex = 0;
            this.textpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textpuerto
            // 
            this.textpuerto.Location = new System.Drawing.Point(363, 63);
            this.textpuerto.Name = "textpuerto";
            this.textpuerto.Size = new System.Drawing.Size(141, 27);
            this.textpuerto.TabIndex = 1;
            this.textpuerto.Text = "5432";
            this.textpuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(142, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña de tu postgreSQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(93, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto de la instancia de PostgreSQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(266, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaccion Transferencia Bancaria";
            // 
            // textsaldo1
            // 
            this.textsaldo1.Location = new System.Drawing.Point(247, 170);
            this.textsaldo1.Name = "textsaldo1";
            this.textsaldo1.Size = new System.Drawing.Size(125, 27);
            this.textsaldo1.TabIndex = 5;
            // 
            // textsaldo2
            // 
            this.textsaldo2.Location = new System.Drawing.Point(247, 217);
            this.textsaldo2.Name = "textsaldo2";
            this.textsaldo2.Size = new System.Drawing.Size(125, 27);
            this.textsaldo2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(97, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo cuenta ID 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(97, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saldo cuenta ID 2";
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaldo.Location = new System.Drawing.Point(556, 173);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(129, 71);
            this.buttonSaldo.TabIndex = 9;
            this.buttonSaldo.Text = "Consultar Saldo";
            this.buttonSaldo.UseVisualStyleBackColor = false;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // textorigen
            // 
            this.textorigen.Location = new System.Drawing.Point(161, 280);
            this.textorigen.Name = "textorigen";
            this.textorigen.Size = new System.Drawing.Size(123, 27);
            this.textorigen.TabIndex = 10;
            // 
            // textdestino
            // 
            this.textdestino.Location = new System.Drawing.Point(574, 280);
            this.textdestino.Name = "textdestino";
            this.textdestino.Size = new System.Drawing.Size(123, 27);
            this.textdestino.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(-1, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID de la cuenta origen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(406, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID de la cuenta destino";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(161, 324);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(123, 27);
            this.textValor.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(37, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor a transferir";
            // 
            // buttonTransaccionMala
            // 
            this.buttonTransaccionMala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTransaccionMala.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTransaccionMala.Location = new System.Drawing.Point(68, 371);
            this.buttonTransaccionMala.Name = "buttonTransaccionMala";
            this.buttonTransaccionMala.Size = new System.Drawing.Size(248, 29);
            this.buttonTransaccionMala.TabIndex = 16;
            this.buttonTransaccionMala.Text = "Transferir (Modo no transaccional)";
            this.buttonTransaccionMala.UseVisualStyleBackColor = false;
            this.buttonTransaccionMala.Click += new System.EventHandler(this.buttonTransaccionMala_Click);
            // 
            // buttonTransaccionBuena
            // 
            this.buttonTransaccionBuena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTransaccionBuena.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTransaccionBuena.Location = new System.Drawing.Point(449, 371);
            this.buttonTransaccionBuena.Name = "buttonTransaccionBuena";
            this.buttonTransaccionBuena.Size = new System.Drawing.Size(248, 29);
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
            this.label9.Location = new System.Drawing.Point(510, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Puerto tipico de PostgreSQL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(510, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Contraseña segun su instalacion";
            // 
            // FormTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 412);
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
    }
}