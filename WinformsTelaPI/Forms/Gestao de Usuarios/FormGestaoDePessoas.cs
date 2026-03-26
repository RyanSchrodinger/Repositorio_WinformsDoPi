using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms.Gestao_de_Usuarios;
using WinformsTelaPI.Forms.Gestao_de_Usuarios.ADM;

namespace WinformsTelaPI.Forms
{
    public partial class FormGestaoDePessoas : Form
    {
        public FormGestaoDePessoas()
        {
            InitializeComponent();

            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void MostrarPanelAdm()
        {
            if (panelAdm.Visible == false)
            {

                panelAdm.Visible = true;

            }
            else
                panelAdm.Visible = false;
        }



        private void btnAdm_Click(object sender, EventArgs e)
        {
            MostrarPanelAdm();
            CorBotao(btnAdm);

        }



        // cntr + tab 
        private Form formAtivo = null;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormUsuarioInformacao());
            CorBotao(btnUsuarios);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormCadastrarAdm());
            CorBotao(btnAdicionar);
            
        }

        #region Função que dá uma interatividade para os botão de acessar as telas 
        public void CorBotao(Button botao)
        {
            /*
            if (panel2.Height == 552)
            {
                panel2.AutoScroll = true;
            }
            else
            {
                panel2.AutoScroll = false;
            }
            */

            btnAdm.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnConsultar.BackColor = ColorTranslator.FromHtml("#2A123D");
            btnAdicionar.BackColor = ColorTranslator.FromHtml("#2A123D");
            btnUsuarios.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnEmpresas.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnProfissional.BackColor = ColorTranslator.FromHtml("#3C096C");
            btnClientes.BackColor = ColorTranslator.FromHtml("#3C096C");


            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }
        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CorBotao(btnConsultar);
            AbrirFormFilho(new FormConsultarAdm());
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormEmpresaInformacao());
            CorBotao(btnEmpresas);

        }

        private void btnProfissional_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormProfissionalInformacao());
            CorBotao(btnProfissional);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CorBotao(btnClientes);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            CorBotao(btnAdm);

            btnAdm.BackColor = ColorTranslator.FromHtml("#3C096C");


        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
