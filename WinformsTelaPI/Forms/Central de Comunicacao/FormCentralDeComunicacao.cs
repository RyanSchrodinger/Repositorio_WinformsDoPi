using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms.Central_de_Comunicacao.Controle;

namespace WinformsTelaPI.Forms.Central_de_Comunicacao
{
    public partial class FormCentralDeComunicacao : Form
    {
        private Form formAtivo = null;
        public FormCentralDeComunicacao()
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
            formFilho.FormBorderStyle = FormBorderStyle.None;
            panelFilho.Controls.Add(formFilho);
            panelFilho.Tag = formFilho;
            formFilho.Show();




        }


        #region Função que dá uma interatividade para os botão de acessar as telas 
        public void CorBotao(Button botao)
        {


            btnChats.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnMensagem.BackColor = ColorTranslator.FromHtml("#3C096C");
            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        private void btnChats_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormChatsView());
            CorBotao(btnChats);
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormMensagemView());
            CorBotao(btnMensagem);
        }
    }
}
