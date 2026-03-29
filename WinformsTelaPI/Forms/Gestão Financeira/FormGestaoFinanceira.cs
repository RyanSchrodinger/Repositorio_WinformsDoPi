using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsTelaPI.Forms.Gestão_Financeira
{
    public partial class FormGestaoFinanceira : Form
    {
        public FormGestaoFinanceira()
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


            btnPagamentos.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnTransacao.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnFormasDePagamento.BackColor = ColorTranslator.FromHtml("#3C096C");
            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            CorBotao(btnPagamentos);
        }

        private void btnTransacao_Click(object sender, EventArgs e)
        {
            CorBotao(btnTransacao);
        }

        private void btnFormasDePagamento_Click(object sender, EventArgs e)
        {
            CorBotao(btnFormasDePagamento);
        }
    }
}
