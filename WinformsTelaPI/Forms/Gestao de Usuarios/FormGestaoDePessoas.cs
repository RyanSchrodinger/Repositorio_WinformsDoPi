using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public void CorBotao(Button botao)
        {

            btnAdm.BackColor = ColorTranslator.FromHtml("#2A1247");
            btnConsultar.BackColor = ColorTranslator.FromHtml("#2A123D");
            btnAdicionar.BackColor = ColorTranslator.FromHtml("#2A123D");
            btnUsuarios.BackColor = ColorTranslator.FromHtml("#2A1247");
            btnEmpresas.BackColor = ColorTranslator.FromHtml("#2A1247");
            btnProfissional.BackColor = ColorTranslator.FromHtml("#2A1247");
            btnClientes.BackColor = ColorTranslator.FromHtml("#2A1247");


            botao.BackColor = ColorTranslator.FromHtml("#9D4EDD");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CorBotao(btnConsultar);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            CorBotao(btnEmpresas);
        }

        private void btnProfissional_Click(object sender, EventArgs e)
        {
            CorBotao(btnProfissional);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CorBotao(btnClientes);
        }
    }


}
