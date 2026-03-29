namespace WinformsTelaPI.Forms.Gestao_de_Locacoes
{
    partial class FormGestaoDeLocacoes
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFormasDePagamento = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTransacao = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFilho = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1417, 53);
            this.panel3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO DE LOCAÇÕES \r\n";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(18)))), ((int)(((byte)(72)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(28, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 733);
            this.panel2.TabIndex = 35;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = global::WinformsTelaPI.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(0, 669);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10);
            this.btnVoltar.Size = new System.Drawing.Size(359, 57);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar para o Menu";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 726);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(359, 5);
            this.panel9.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(18)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.btnFormasDePagamento);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnTransacao);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnPagamentos);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(30, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 651);
            this.panel1.TabIndex = 31;
            // 
            // btnFormasDePagamento
            // 
            this.btnFormasDePagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnFormasDePagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormasDePagamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormasDePagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnFormasDePagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormasDePagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormasDePagamento.ForeColor = System.Drawing.Color.White;
            this.btnFormasDePagamento.Image = global::WinformsTelaPI.Properties.Resources.tipospagamento;
            this.btnFormasDePagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormasDePagamento.Location = new System.Drawing.Point(0, 280);
            this.btnFormasDePagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormasDePagamento.Name = "btnFormasDePagamento";
            this.btnFormasDePagamento.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnFormasDePagamento.Size = new System.Drawing.Size(291, 57);
            this.btnFormasDePagamento.TabIndex = 3;
            this.btnFormasDePagamento.Text = "FORMA_PAGAMENTO";
            this.btnFormasDePagamento.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 11);
            this.panel6.TabIndex = 29;
            // 
            // btnTransacao
            // 
            this.btnTransacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnTransacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacao.ForeColor = System.Drawing.Color.White;
            this.btnTransacao.Image = global::WinformsTelaPI.Properties.Resources.transacao;
            this.btnTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacao.Location = new System.Drawing.Point(0, 212);
            this.btnTransacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnTransacao.Size = new System.Drawing.Size(291, 57);
            this.btnTransacao.TabIndex = 27;
            this.btnTransacao.Text = "TRANSAÇÕES";
            this.btnTransacao.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 201);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(291, 11);
            this.panel8.TabIndex = 29;
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.btnPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPagamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.ForeColor = System.Drawing.Color.White;
            this.btnPagamentos.Image = global::WinformsTelaPI.Properties.Resources.pagamentsso;
            this.btnPagamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamentos.Location = new System.Drawing.Point(0, 144);
            this.btnPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnPagamentos.Size = new System.Drawing.Size(291, 57);
            this.btnPagamentos.TabIndex = 0;
            this.btnPagamentos.Text = "PAGAMENTOS";
            this.btnPagamentos.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 21);
            this.panel4.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(18)))), ((int)(((byte)(72)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WinformsTelaPI.Properties.Resources.gestaoFinanceira;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panelFilho
            // 
            this.panelFilho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilho.Location = new System.Drawing.Point(415, 61);
            this.panelFilho.Margin = new System.Windows.Forms.Padding(4);
            this.panelFilho.Name = "panelFilho";
            this.panelFilho.Size = new System.Drawing.Size(988, 733);
            this.panelFilho.TabIndex = 37;
            // 
            // FormGestaoDeLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1417, 809);
            this.Controls.Add(this.panelFilho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormGestaoDeLocacoes";
            this.Text = "FormGestaoDeLocacoes";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFormasDePagamento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTransacao;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFilho;
    }
}