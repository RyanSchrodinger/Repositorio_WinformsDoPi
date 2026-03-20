using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            formFilho.FormBorderStyle   = FormBorderStyle.None;
            panelFilho.Controls.Add(formFilho);
            panelFilho.Tag = formFilho;
            formFilho.Show();



            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new FormUsuarioInformacao());
        }
    }

}
