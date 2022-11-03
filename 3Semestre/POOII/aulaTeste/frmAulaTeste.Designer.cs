namespace aulaTeste
{
    partial class frmAulaTeste
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNP1 = new System.Windows.Forms.Label();
            this.lblNP2 = new System.Windows.Forms.Label();
            this.lblNP3 = new System.Windows.Forms.Label();
            this.lblNP4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNP1 = new System.Windows.Forms.TextBox();
            this.txtNP2 = new System.Windows.Forms.TextBox();
            this.txtNP3 = new System.Windows.Forms.TextBox();
            this.txtNP4 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(273, 259);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(139, 259);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblNP1
            // 
            this.lblNP1.AutoSize = true;
            this.lblNP1.Location = new System.Drawing.Point(19, 25);
            this.lblNP1.Name = "lblNP1";
            this.lblNP1.Size = new System.Drawing.Size(32, 15);
            this.lblNP1.TabIndex = 5;
            this.lblNP1.Text = "NP1:";
            // 
            // lblNP2
            // 
            this.lblNP2.AutoSize = true;
            this.lblNP2.Location = new System.Drawing.Point(19, 68);
            this.lblNP2.Name = "lblNP2";
            this.lblNP2.Size = new System.Drawing.Size(32, 15);
            this.lblNP2.TabIndex = 6;
            this.lblNP2.Text = "NP2:";
            // 
            // lblNP3
            // 
            this.lblNP3.AutoSize = true;
            this.lblNP3.Location = new System.Drawing.Point(19, 115);
            this.lblNP3.Name = "lblNP3";
            this.lblNP3.Size = new System.Drawing.Size(32, 15);
            this.lblNP3.TabIndex = 7;
            this.lblNP3.Text = "NP3:";
            // 
            // lblNP4
            // 
            this.lblNP4.AutoSize = true;
            this.lblNP4.Location = new System.Drawing.Point(19, 158);
            this.lblNP4.Name = "lblNP4";
            this.lblNP4.Size = new System.Drawing.Size(32, 15);
            this.lblNP4.TabIndex = 8;
            this.lblNP4.Text = "NP4:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(19, 203);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtNP1
            // 
            this.txtNP1.Location = new System.Drawing.Point(123, 17);
            this.txtNP1.Name = "txtNP1";
            this.txtNP1.Size = new System.Drawing.Size(100, 23);
            this.txtNP1.TabIndex = 10;
            // 
            // txtNP2
            // 
            this.txtNP2.Location = new System.Drawing.Point(123, 60);
            this.txtNP2.Name = "txtNP2";
            this.txtNP2.Size = new System.Drawing.Size(100, 23);
            this.txtNP2.TabIndex = 11;
            // 
            // txtNP3
            // 
            this.txtNP3.Location = new System.Drawing.Point(123, 107);
            this.txtNP3.Name = "txtNP3";
            this.txtNP3.Size = new System.Drawing.Size(100, 23);
            this.txtNP3.TabIndex = 12;
            // 
            // txtNP4
            // 
            this.txtNP4.Location = new System.Drawing.Point(123, 150);
            this.txtNP4.Name = "txtNP4";
            this.txtNP4.Size = new System.Drawing.Size(100, 23);
            this.txtNP4.TabIndex = 13;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(123, 195);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 14;
            // 
            // frmAulaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 343);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNP4);
            this.Controls.Add(this.txtNP3);
            this.Controls.Add(this.txtNP2);
            this.Controls.Add(this.txtNP1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNP4);
            this.Controls.Add(this.lblNP3);
            this.Controls.Add(this.lblNP2);
            this.Controls.Add(this.lblNP1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "frmAulaTeste";
            this.Text = "Aula Teste";
            this.Load += new System.EventHandler(this.frmAulaTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSair;
        private Button btnLimpar;
        private Button btnCalcular;
        private Label lblNP1;
        private Label lblNP2;
        private Label lblNP3;
        private Label lblNP4;
        private Label lblResultado;
        private TextBox txtNP1;
        private TextBox txtNP2;
        private TextBox txtNP3;
        private TextBox txtNP4;
        private TextBox txtResultado;
    }
}