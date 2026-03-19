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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

     
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestaoPessoas_Click(object sender, EventArgs e)
        {
            var tela = new FormGestaoDePessoas();
            tela.ShowDialog();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
