using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsTelaPI.Forms.Central_de_Comunicacao
{
    public partial class FormCentralDeComunicacao : Form
    {
        public FormCentralDeComunicacao()
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


            btnChats.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnMensagem.BackColor = ColorTranslator.FromHtml("#3C096C");



            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        private void btnChats_Click(object sender, EventArgs e)
        {
            CorBotao(btnChats);
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            CorBotao(btnMensagem);
        }
    }
}
