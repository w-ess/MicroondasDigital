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
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPotencia = new System.Windows.Forms.NumericUpDown();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.listBoxProgramas = new System.Windows.Forms.ListBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.grpBoxCadastro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numPotenciaC = new System.Windows.Forms.NumericUpDown();
            this.numSegundosC = new System.Windows.Forms.NumericUpDown();
            this.txtBoxCaractereC = new System.Windows.Forms.TextBox();
            this.txtBoxNomeC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).BeginInit();
            this.grpBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPotenciaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosC)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(559, 43);
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
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.Location = new System.Drawing.Point(12, 303);
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPesquisa.TabIndex = 27;
            this.txtBoxPesquisa.TextChanged += new System.EventHandler(this.txtBoxPesquisa_TextChanged);
            // 
            // listBoxProgramas
            // 
            this.listBoxProgramas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.listBoxProgramas.FormattingEnabled = true;
            this.listBoxProgramas.Items.AddRange(new object[] {
            "  "});
            this.listBoxProgramas.Location = new System.Drawing.Point(12, 336);
            this.listBoxProgramas.Name = "listBoxProgramas";
            this.listBoxProgramas.Size = new System.Drawing.Size(333, 121);
            this.listBoxProgramas.TabIndex = 26;
            this.listBoxProgramas.SelectedIndexChanged += new System.EventHandler(this.listBoxProgramas_SelectedIndexChanged_1);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(139, 295);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(67, 35);
            this.btnPesquisa.TabIndex = 25;
            this.btnPesquisa.Text = "Pesquisa Programa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // grpBoxCadastro
            // 
            this.grpBoxCadastro.Controls.Add(this.button1);
            this.grpBoxCadastro.Controls.Add(this.numPotenciaC);
            this.grpBoxCadastro.Controls.Add(this.numSegundosC);
            this.grpBoxCadastro.Controls.Add(this.txtBoxCaractereC);
            this.grpBoxCadastro.Controls.Add(this.txtBoxNomeC);
            this.grpBoxCadastro.Controls.Add(this.label7);
            this.grpBoxCadastro.Controls.Add(this.label6);
            this.grpBoxCadastro.Controls.Add(this.label5);
            this.grpBoxCadastro.Controls.Add(this.label3);
            this.grpBoxCadastro.Location = new System.Drawing.Point(359, 283);
            this.grpBoxCadastro.Name = "grpBoxCadastro";
            this.grpBoxCadastro.Size = new System.Drawing.Size(188, 174);
            this.grpBoxCadastro.TabIndex = 29;
            this.grpBoxCadastro.TabStop = false;
            this.grpBoxCadastro.Text = "Cadastrar Programas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 21);
            this.button1.TabIndex = 29;
            this.button1.Text = "Cadastrar Programas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numPotenciaC
            // 
            this.numPotenciaC.Location = new System.Drawing.Point(68, 86);
            this.numPotenciaC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPotenciaC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotenciaC.Name = "numPotenciaC";
            this.numPotenciaC.Size = new System.Drawing.Size(100, 20);
            this.numPotenciaC.TabIndex = 7;
            this.numPotenciaC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSegundosC
            // 
            this.numSegundosC.Location = new System.Drawing.Point(68, 56);
            this.numSegundosC.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numSegundosC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegundosC.Name = "numSegundosC";
            this.numSegundosC.Size = new System.Drawing.Size(100, 20);
            this.numSegundosC.TabIndex = 6;
            this.numSegundosC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBoxCaractereC
            // 
            this.txtBoxCaractereC.Location = new System.Drawing.Point(68, 112);
            this.txtBoxCaractereC.Name = "txtBoxCaractereC";
            this.txtBoxCaractereC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCaractereC.TabIndex = 5;
            // 
            // txtBoxNomeC
            // 
            this.txtBoxNomeC.Location = new System.Drawing.Point(68, 25);
            this.txtBoxNomeC.Name = "txtBoxNomeC";
            this.txtBoxNomeC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeC.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Caractere:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Potência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Segundos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alimento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(310, 65);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 38);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 488);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpBoxCadastro);
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
            this.grpBoxCadastro.ResumeLayout(false);
            this.grpBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPotenciaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosC)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.ListBox listBoxProgramas;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox grpBoxCadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPotenciaC;
        private System.Windows.Forms.NumericUpDown numSegundosC;
        private System.Windows.Forms.TextBox txtBoxCaractereC;
        private System.Windows.Forms.TextBox txtBoxNomeC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}

