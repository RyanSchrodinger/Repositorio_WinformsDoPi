using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTelaPI.Forms;

namespace WinformsTelaPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "Digite seu login...";
            txtLogin.ForeColor = Color.Gray;
            txtSenha.Text = "Digite sua senha...";
            txtSenha.ForeColor = Color.Gray;

        }
        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Digite seu login...")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if(txtLogin.Text == "")
            {
                txtLogin.Text = "Digite seu login...";
                txtLogin.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Digite sua senha...")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Digite seu login...";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tela = new FormMenu();
            tela.ShowDialog();
        }

       
    }
}

