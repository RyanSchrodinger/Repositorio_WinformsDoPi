using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms.Gestao_de_Servicos.Controle;

namespace WinformsTelaPI.Forms.Gestao_de_Servicos
{
    public partial class FormGestaoDeServicos : Form
    {
        private Form formAtivo = null;
        public FormGestaoDeServicos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Função que dá uma interatividade para os botão de acessar as telas 
        public void CorBotao(Button botao)
        {


            btnServicos.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnServicoPedido.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnAvaliacoes.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnPedido.BackColor = ColorTranslator.FromHtml("#3C096C");
            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        
        private void AbrirFormFilho(Form formFilho)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }

            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.Dock = DockStyle.Fill;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            panelFilho.Controls.Add(formFilho);
            panelFilho.Tag = formFilho;
            formFilho.Show();




        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormServicoView());
            CorBotao(btnServicos);
        }

        private void btnServicoPedido_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormServicoPedidosView());
            CorBotao(btnServicoPedido);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormPedidosView());
            CorBotao(btnPedido);
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormAvaliacoesView());
            CorBotao(btnAvaliacoes);
        }
    }
}
