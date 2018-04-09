﻿namespace MicroondasDigitalDesktop
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
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPotencia = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.listBoxProgramas = new System.Windows.Forms.ListBox();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciaPausa
            // 
            this.btnIniciaPausa.Location = new System.Drawing.Point(189, 115);
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
            this.panel1.Size = new System.Drawing.Size(171, 99);
            this.panel1.TabIndex = 3;
            // 
            // lbCronometro
            // 
            this.lbCronometro.AutoSize = true;
            this.lbCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.Location = new System.Drawing.Point(22, 25);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(43, 46);
            this.lbCronometro.TabIndex = 3;
            this.lbCronometro.Text = "0";
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
            this.panel2.Size = new System.Drawing.Size(653, 43);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Micro-ondas";
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(189, 65);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(113, 38);
            this.btnInicia.TabIndex = 8;
            this.btnInicia.Text = "Iniciar/Reiniciar  (Início rápido)";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // txtBoxString
            // 
            this.txtBoxString.Location = new System.Drawing.Point(12, 237);
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.Size = new System.Drawing.Size(407, 20);
            this.txtBoxString.TabIndex = 10;
            this.txtBoxString.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Potência:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Segundos:";
            // 
            // numPotencia
            // 
            this.numPotencia.Location = new System.Drawing.Point(13, 195);
            this.numPotencia.Name = "numPotencia";
            this.numPotencia.Size = new System.Drawing.Size(64, 20);
            this.numPotencia.TabIndex = 15;
            this.numPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPotencia.ValueChanged += new System.EventHandler(this.numPotencia_ValueChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(435, 49);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(67, 35);
            this.btnPesquisa.TabIndex = 17;
            this.btnPesquisa.Text = "Pesquisa Programa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // listBoxProgramas
            // 
            this.listBoxProgramas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.listBoxProgramas.FormattingEnabled = true;
            this.listBoxProgramas.Items.AddRange(new object[] {
            "  "});
            this.listBoxProgramas.Location = new System.Drawing.Point(308, 90);
            this.listBoxProgramas.Name = "listBoxProgramas";
            this.listBoxProgramas.Size = new System.Drawing.Size(333, 121);
            this.listBoxProgramas.TabIndex = 18;
            this.listBoxProgramas.SelectedIndexChanged += new System.EventHandler(this.listBoxProgramas_SelectedIndexChanged);
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Location = new System.Drawing.Point(308, 57);
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPesquisa.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 287);
            this.Controls.Add(this.txtBoxPesquisa);
            this.Controls.Add(this.listBoxProgramas);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.numPotencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxString);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciaPausa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPotencia;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ListBox listBoxProgramas;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
    }
}

