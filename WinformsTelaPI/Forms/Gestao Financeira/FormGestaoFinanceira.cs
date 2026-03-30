using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms.Gestao_Financeira.Controle;

namespace WinformsTelaPI.Forms.Gestão_Financeira
{
    public partial class FormGestaoFinanceira : Form
    {
        private Form formAtivo = null;
        public FormGestaoFinanceira()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
        private void AbrirFormFilho(Form formFilho)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }

            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.Dock = DockStyle.Fill;
            panelFilho.Controls.Add(formFilho);
            panelFilho.Tag = formFilho;
            formFilho.Show();

        }


        #region Função que dá uma interatividade para os botão de acessar as telas 
        public void CorBotao(Button botao)
        {


            btnPagamentos.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnTransacao.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnFormasDePagamento.BackColor = ColorTranslator.FromHtml("#3C096C");
            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormPagamentosView());
            CorBotao(btnPagamentos);
        }

        private void btnTransacao_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormTransasaoView());
            CorBotao(btnTransacao);
        }

        private void btnFormasDePagamento_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormFormasPagamentoView());
            CorBotao(btnFormasDePagamento);
        }
    }
}
