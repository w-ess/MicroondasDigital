namespace MicroondasDigitalDesktop
{
    partial class Form1
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
            this.btnIniciaPausa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCronometro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicia = new System.Windows.Forms.Button();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciaPausa
            // 
            this.btnIniciaPausa.Location = new System.Drawing.Point(223, 115);
            this.btnIniciaPausa.Name = "btnIniciaPausa";
            this.btnIniciaPausa.Size = new System.Drawing.Size(113, 38);
            this.btnIniciaPausa.TabIndex = 1;
            this.btnIniciaPausa.Text = "Pausa/Retomar";
            this.btnIniciaPausa.UseVisualStyleBackColor = true;
            this.btnIniciaPausa.Click += new System.EventHandler(this.btnIniciaPausa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lbCronometro);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 99);
            this.panel1.TabIndex = 3;
            // 
            // lbCronometro
            // 
            this.lbCronometro.AutoSize = true;
            this.lbCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.Location = new System.Drawing.Point(7, 25);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(182, 46);
            this.lbCronometro.TabIndex = 3;
            this.lbCronometro.Text = "00:00:00";
            this.lbCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCronometro.Click += new System.EventHandler(this.lbCronometro_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 43);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Microondas";
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(223, 65);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(113, 38);
            this.btnInicia.TabIndex = 8;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(12, 179);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(67, 20);
            this.txtMinutos.TabIndex = 9;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(94, 179);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(67, 20);
            this.txtSegundos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 269);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciaPausa);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciaPausa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
    }
}

