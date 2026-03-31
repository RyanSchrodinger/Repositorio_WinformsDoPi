using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms.Gestao_de_Locacoes.Controle;

namespace WinformsTelaPI.Forms.Gestao_de_Locacoes
{
    public partial class FormGestaoDeLocacoes : Form
    {
        private Form formAtivo = null;
        public FormGestaoDeLocacoes()
        {
            InitializeComponent();
        }

        #region Função que dá uma interatividade para os botão de acessar as telas 
        public void CorBotao(Button botao)
        {


            btnLocacoes.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnLocacoesItem.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnInstrumentos.BackColor = ColorTranslator.FromHtml("#3C096C");
            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

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
            formFilho.FormBorderStyle = FormBorderStyle.None;
            panelFilho.Controls.Add(formFilho);
            panelFilho.Tag = formFilho;
            formFilho.Show();




        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormLocacaoView());
            CorBotao(btnLocacoes);
        }

        private void btnLocacoesItem_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormLocacaoItensView());
            CorBotao(btnLocacoesItem);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormInstrumentosView());
            CorBotao(btnInstrumentos);
        }
    }
}
