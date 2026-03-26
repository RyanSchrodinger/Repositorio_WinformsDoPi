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
    public partial class FormUsuarioInformacao : Form
    {
        public FormUsuarioInformacao()
        {
            InitializeComponent();
            PersonalizarDataGrid();
        }


        public void PersonalizarDataGrid()
        {
            dgvUsuarios.BackgroundColor = Color.FromArgb(27, 18, 51);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 35, 138);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUsuarios.DefaultCellStyle.BackColor = Color.FromArgb(34, 22, 61);
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 63, 214);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvUsuarios.GridColor = Color.FromArgb(75, 59, 110);
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ReadOnly = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
