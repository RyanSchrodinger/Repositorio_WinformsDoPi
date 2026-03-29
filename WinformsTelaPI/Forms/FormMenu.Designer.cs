namespace WinformsTelaPI.Forms
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGestaoPessoas = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnGestaoFinanceira = new System.Windows.Forms.Button();
            this.btnCentralMensagem = new System.Windows.Forms.Button();
            this.btnGestaoLocacao = new System.Windows.Forms.Button();
            this.btnGestaoServicos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "FAZER LOGOUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 50);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(475, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Painel Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(177, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 219);
            this.panel2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(316, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bem Vindo ADM";
            // 
            // btnGestaoPessoas
            // 
            this.btnGestaoPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnGestaoPessoas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestaoPessoas.FlatAppearance.BorderSize = 2;
            this.btnGestaoPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoPessoas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoPessoas.ForeColor = System.Drawing.Color.White;
            this.btnGestaoPessoas.Image = global::WinformsTelaPI.Properties.Resources.pes;
            this.btnGestaoPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestaoPessoas.Location = new System.Drawing.Point(177, 358);
            this.btnGestaoPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestaoPessoas.Name = "btnGestaoPessoas";
            this.btnGestaoPessoas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestaoPessoas.Size = new System.Drawing.Size(432, 63);
            this.btnGestaoPessoas.TabIndex = 22;
            this.btnGestaoPessoas.Text = "Gestão de Pessoas";
            this.btnGestaoPessoas.UseVisualStyleBackColor = false;
            this.btnGestaoPessoas.Click += new System.EventHandler(this.btnGestaoPessoas_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinformsTelaPI.Properties.Resources.music_station_vetorizada_1;
            this.pictureBox5.Location = new System.Drawing.Point(0, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(913, 132);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // btnGestaoFinanceira
            // 
            this.btnGestaoFinanceira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnGestaoFinanceira.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestaoFinanceira.FlatAppearance.BorderSize = 2;
            this.btnGestaoFinanceira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoFinanceira.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoFinanceira.ForeColor = System.Drawing.Color.White;
            this.btnGestaoFinanceira.Image = global::WinformsTelaPI.Properties.Resources.financiamentoColaborativo;
            this.btnGestaoFinanceira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestaoFinanceira.Location = new System.Drawing.Point(663, 358);
            this.btnGestaoFinanceira.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestaoFinanceira.Name = "btnGestaoFinanceira";
            this.btnGestaoFinanceira.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestaoFinanceira.Size = new System.Drawing.Size(432, 63);
            this.btnGestaoFinanceira.TabIndex = 19;
            this.btnGestaoFinanceira.Text = "Gestão Financeira\r\n";
            this.btnGestaoFinanceira.UseVisualStyleBackColor = false;
            this.btnGestaoFinanceira.Click += new System.EventHandler(this.btnGestaoFinanceira_Click);
            // 
            // btnCentralMensagem
            // 
            this.btnCentralMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnCentralMensagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCentralMensagem.FlatAppearance.BorderSize = 2;
            this.btnCentralMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentralMensagem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentralMensagem.ForeColor = System.Drawing.Color.White;
            this.btnCentralMensagem.Image = global::WinformsTelaPI.Properties.Resources.comunicacao;
            this.btnCentralMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentralMensagem.Location = new System.Drawing.Point(177, 537);
            this.btnCentralMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCentralMensagem.Name = "btnCentralMensagem";
            this.btnCentralMensagem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCentralMensagem.Size = new System.Drawing.Size(917, 63);
            this.btnCentralMensagem.TabIndex = 8;
            this.btnCentralMensagem.Text = "Central de Comunicação";
            this.btnCentralMensagem.UseVisualStyleBackColor = false;
            this.btnCentralMensagem.Click += new System.EventHandler(this.btnCentralMensagem_Click);
            // 
            // btnGestaoLocacao
            // 
            this.btnGestaoLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnGestaoLocacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestaoLocacao.FlatAppearance.BorderSize = 2;
            this.btnGestaoLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoLocacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoLocacao.ForeColor = System.Drawing.Color.White;
            this.btnGestaoLocacao.Image = global::WinformsTelaPI.Properties.Resources.locacao;
            this.btnGestaoLocacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestaoLocacao.Location = new System.Drawing.Point(663, 450);
            this.btnGestaoLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestaoLocacao.Name = "btnGestaoLocacao";
            this.btnGestaoLocacao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestaoLocacao.Size = new System.Drawing.Size(432, 63);
            this.btnGestaoLocacao.TabIndex = 7;
            this.btnGestaoLocacao.Text = "Gestão de Locações";
            this.btnGestaoLocacao.UseVisualStyleBackColor = false;
            this.btnGestaoLocacao.Click += new System.EventHandler(this.btnGestaoLocacao_Click);
            // 
            // btnGestaoServicos
            // 
            this.btnGestaoServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnGestaoServicos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestaoServicos.FlatAppearance.BorderSize = 2;
            this.btnGestaoServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoServicos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoServicos.ForeColor = System.Drawing.Color.White;
            this.btnGestaoServicos.Image = global::WinformsTelaPI.Properties.Resources.services;
            this.btnGestaoServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestaoServicos.Location = new System.Drawing.Point(177, 450);
            this.btnGestaoServicos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestaoServicos.Name = "btnGestaoServicos";
            this.btnGestaoServicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestaoServicos.Size = new System.Drawing.Size(432, 63);
            this.btnGestaoServicos.TabIndex = 6;
            this.btnGestaoServicos.Text = "Gestão de Serviços";
            this.btnGestaoServicos.UseVisualStyleBackColor = false;
            this.btnGestaoServicos.Click += new System.EventHandler(this.btnGestaoServicos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformsTelaPI.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1272, 651);
            this.Controls.Add(this.btnGestaoPessoas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGestaoFinanceira);
            this.Controls.Add(this.btnCentralMensagem);
            this.Controls.Add(this.btnGestaoLocacao);
            this.Controls.Add(this.btnGestaoServicos);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGestaoServicos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestaoLocacao;
        private System.Windows.Forms.Button btnCentralMensagem;
        private System.Windows.Forms.Button btnGestaoFinanceira;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnGestaoPessoas;
        private System.Windows.Forms.Label label3;
    }
}