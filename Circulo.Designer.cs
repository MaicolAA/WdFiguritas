
namespace WdFiguritas
{
    partial class Circulo
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
            this.btnCalcularCrl = new System.Windows.Forms.Button();
            this.btnDibujarCrl = new System.Windows.Forms.Button();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtAreaCrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularCrl
            // 
            this.btnCalcularCrl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcularCrl.Location = new System.Drawing.Point(107, 276);
            this.btnCalcularCrl.Name = "btnCalcularCrl";
            this.btnCalcularCrl.Size = new System.Drawing.Size(134, 44);
            this.btnCalcularCrl.TabIndex = 0;
            this.btnCalcularCrl.Text = "Calcular";
            this.btnCalcularCrl.UseVisualStyleBackColor = false;
            this.btnCalcularCrl.Click += new System.EventHandler(this.btnCalcularCrl_Click);
            // 
            // btnDibujarCrl
            // 
            this.btnDibujarCrl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDibujarCrl.Location = new System.Drawing.Point(107, 172);
            this.btnDibujarCrl.Name = "btnDibujarCrl";
            this.btnDibujarCrl.Size = new System.Drawing.Size(134, 46);
            this.btnDibujarCrl.TabIndex = 1;
            this.btnDibujarCrl.Text = "Dibujar";
            this.btnDibujarCrl.UseVisualStyleBackColor = false;
            this.btnDibujarCrl.Click += new System.EventHandler(this.btnDibujarCrl_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(107, 80);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(134, 20);
            this.txtRadio.TabIndex = 2;
            this.txtRadio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(41, 80);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 3;
            this.lblRadio.Text = "Radio";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(66, 364);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            this.lblArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAreaCrl
            // 
            this.txtAreaCrl.Location = new System.Drawing.Point(125, 364);
            this.txtAreaCrl.Name = "txtAreaCrl";
            this.txtAreaCrl.Size = new System.Drawing.Size(100, 20);
            this.txtAreaCrl.TabIndex = 5;
            this.txtAreaCrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAreaCrl);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.btnDibujarCrl);
            this.Controls.Add(this.btnCalcularCrl);
            this.Name = "Circulo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCrl;
        private System.Windows.Forms.Button btnDibujarCrl;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAreaCrl;
    }
}