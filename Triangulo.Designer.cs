
namespace WdFiguritas
{
    partial class Triangulo
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
            this.btnCalcularTrg = new System.Windows.Forms.Button();
            this.btnDibujarTrg = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.txtBaseTrg = new System.Windows.Forms.TextBox();
            this.txtAreaTrg = new System.Windows.Forms.TextBox();
            this.txtAlturaTrg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularTrg
            // 
            this.btnCalcularTrg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcularTrg.Location = new System.Drawing.Point(49, 245);
            this.btnCalcularTrg.Name = "btnCalcularTrg";
            this.btnCalcularTrg.Size = new System.Drawing.Size(142, 48);
            this.btnCalcularTrg.TabIndex = 0;
            this.btnCalcularTrg.Text = "Calcular Area";
            this.btnCalcularTrg.UseVisualStyleBackColor = false;
            this.btnCalcularTrg.Click += new System.EventHandler(this.btnCalcularTrg_Click);
            // 
            // btnDibujarTrg
            // 
            this.btnDibujarTrg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDibujarTrg.Location = new System.Drawing.Point(461, 245);
            this.btnDibujarTrg.Name = "btnDibujarTrg";
            this.btnDibujarTrg.Size = new System.Drawing.Size(174, 47);
            this.btnDibujarTrg.TabIndex = 1;
            this.btnDibujarTrg.Text = "Dibujar";
            this.btnDibujarTrg.UseVisualStyleBackColor = false;
            this.btnDibujarTrg.Click += new System.EventHandler(this.btnDibujarTrg_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(104, 109);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(429, 109);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Location = new System.Drawing.Point(238, 262);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(29, 13);
            this.lblCalcular.TabIndex = 4;
            this.lblCalcular.Text = "Aréa";
            // 
            // txtBaseTrg
            // 
            this.txtBaseTrg.BackColor = System.Drawing.SystemColors.Info;
            this.txtBaseTrg.Location = new System.Drawing.Point(178, 109);
            this.txtBaseTrg.Name = "txtBaseTrg";
            this.txtBaseTrg.Size = new System.Drawing.Size(100, 20);
            this.txtBaseTrg.TabIndex = 5;
            // 
            // txtAreaTrg
            // 
            this.txtAreaTrg.BackColor = System.Drawing.SystemColors.Info;
            this.txtAreaTrg.Location = new System.Drawing.Point(285, 259);
            this.txtAreaTrg.Name = "txtAreaTrg";
            this.txtAreaTrg.Size = new System.Drawing.Size(100, 20);
            this.txtAreaTrg.TabIndex = 7;
            // 
            // txtAlturaTrg
            // 
            this.txtAlturaTrg.BackColor = System.Drawing.SystemColors.Info;
            this.txtAlturaTrg.Location = new System.Drawing.Point(493, 106);
            this.txtAlturaTrg.Name = "txtAlturaTrg";
            this.txtAlturaTrg.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaTrg.TabIndex = 8;
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlturaTrg);
            this.Controls.Add(this.txtAreaTrg);
            this.Controls.Add(this.txtBaseTrg);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnDibujarTrg);
            this.Controls.Add(this.btnCalcularTrg);
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularTrg;
        private System.Windows.Forms.Button btnDibujarTrg;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.TextBox txtBaseTrg;
        private System.Windows.Forms.TextBox txtAreaTrg;
        private System.Windows.Forms.TextBox txtAlturaTrg;
    }
}