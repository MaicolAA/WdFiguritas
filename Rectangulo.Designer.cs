
namespace WdFiguritas
{
    partial class Rectangulo
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
            this.txtAlturaRtg = new System.Windows.Forms.TextBox();
            this.btnCalcularRtg = new System.Windows.Forms.Button();
            this.btnDibujarRtg = new System.Windows.Forms.Button();
            this.txtBaseRtg = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtAreaRtg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAlturaRtg
            // 
            this.txtAlturaRtg.Location = new System.Drawing.Point(105, 163);
            this.txtAlturaRtg.Name = "txtAlturaRtg";
            this.txtAlturaRtg.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaRtg.TabIndex = 0;
            // 
            // btnCalcularRtg
            // 
            this.btnCalcularRtg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcularRtg.Location = new System.Drawing.Point(96, 324);
            this.btnCalcularRtg.Name = "btnCalcularRtg";
            this.btnCalcularRtg.Size = new System.Drawing.Size(129, 39);
            this.btnCalcularRtg.TabIndex = 1;
            this.btnCalcularRtg.Text = "Calcular Area";
            this.btnCalcularRtg.UseVisualStyleBackColor = false;
            this.btnCalcularRtg.Click += new System.EventHandler(this.btnCalcularRtg_Click);
            // 
            // btnDibujarRtg
            // 
            this.btnDibujarRtg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDibujarRtg.Location = new System.Drawing.Point(427, 324);
            this.btnDibujarRtg.Name = "btnDibujarRtg";
            this.btnDibujarRtg.Size = new System.Drawing.Size(146, 40);
            this.btnDibujarRtg.TabIndex = 2;
            this.btnDibujarRtg.Text = "Dibujar";
            this.btnDibujarRtg.UseVisualStyleBackColor = false;
            this.btnDibujarRtg.Click += new System.EventHandler(this.btnDibujarRtg_Click);
            // 
            // txtBaseRtg
            // 
            this.txtBaseRtg.Location = new System.Drawing.Point(105, 100);
            this.txtBaseRtg.Name = "txtBaseRtg";
            this.txtBaseRtg.Size = new System.Drawing.Size(100, 20);
            this.txtBaseRtg.TabIndex = 3;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(68, 101);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base";
            this.lblBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(65, 166);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(295, 324);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // txtAreaRtg
            // 
            this.txtAreaRtg.Location = new System.Drawing.Point(259, 343);
            this.txtAreaRtg.Name = "txtAreaRtg";
            this.txtAreaRtg.Size = new System.Drawing.Size(100, 20);
            this.txtAreaRtg.TabIndex = 7;
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAreaRtg);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBaseRtg);
            this.Controls.Add(this.btnDibujarRtg);
            this.Controls.Add(this.btnCalcularRtg);
            this.Controls.Add(this.txtAlturaRtg);
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlturaRtg;
        private System.Windows.Forms.Button btnCalcularRtg;
        private System.Windows.Forms.Button btnDibujarRtg;
        private System.Windows.Forms.TextBox txtBaseRtg;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAreaRtg;
    }
}