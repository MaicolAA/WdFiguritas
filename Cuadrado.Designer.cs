
namespace WdFiguritas
{
    partial class Cuadrado
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
            this.btnDibujarCdr = new System.Windows.Forms.Button();
            this.btnCalcularCdr = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtAreaCdr = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDibujarCdr
            // 
            this.btnDibujarCdr.Location = new System.Drawing.Point(81, 178);
            this.btnDibujarCdr.Name = "btnDibujarCdr";
            this.btnDibujarCdr.Size = new System.Drawing.Size(130, 42);
            this.btnDibujarCdr.TabIndex = 0;
            this.btnDibujarCdr.Text = "Dibujar";
            this.btnDibujarCdr.UseVisualStyleBackColor = true;
            this.btnDibujarCdr.Click += new System.EventHandler(this.btnDibujarCdr_Click);
            // 
            // btnCalcularCdr
            // 
            this.btnCalcularCdr.Location = new System.Drawing.Point(81, 263);
            this.btnCalcularCdr.Name = "btnCalcularCdr";
            this.btnCalcularCdr.Size = new System.Drawing.Size(130, 46);
            this.btnCalcularCdr.TabIndex = 1;
            this.btnCalcularCdr.Text = "Calcular Area";
            this.btnCalcularCdr.UseVisualStyleBackColor = true;
            this.btnCalcularCdr.Click += new System.EventHandler(this.btnCalcularCdr_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(63, 101);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(100, 101);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 3;
            // 
            // txtAreaCdr
            // 
            this.txtAreaCdr.Location = new System.Drawing.Point(100, 341);
            this.txtAreaCdr.Name = "txtAreaCdr";
            this.txtAreaCdr.Size = new System.Drawing.Size(100, 20);
            this.txtAreaCdr.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(46, 344);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtAreaCdr);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnCalcularCdr);
            this.Controls.Add(this.btnDibujarCdr);
            this.Name = "Cuadrado";
            this.Text = "Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujarCdr;
        private System.Windows.Forms.Button btnCalcularCdr;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtAreaCdr;
        private System.Windows.Forms.Label lblArea;
    }
}