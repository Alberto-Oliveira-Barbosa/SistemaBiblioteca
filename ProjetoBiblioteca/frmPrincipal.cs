using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void inclluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroUsuario frm = new frmCadastroUsuario();
			frm.Show();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPesquisarUsuario frm = new frmPesquisarUsuario();
			frm.Show();
		}

		private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmExcluirUsuario frm = new frmExcluirUsuario();
			frm.Show();
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAlterarUsuario frm = new frmAlterarUsuario();
			frm.Show();
		}

		private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastrarLivro frm = new frmCadastrarLivro();
			frm.Show();
		}

		private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmPesquisarLivro frm = new frmPesquisarLivro();
			frm.Show();
		}

		private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmExcluirLivro frm = new frmExcluirLivro();
			frm.Show();
		}

		private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmAlterarLivro frm = new frmAlterarLivro();
			frm.Show();
		}

		private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmCadastroEmprestimo frm = new frmCadastroEmprestimo();
			frm.Show();
		}
	}
}
