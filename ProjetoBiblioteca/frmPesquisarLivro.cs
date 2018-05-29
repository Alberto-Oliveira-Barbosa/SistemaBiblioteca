using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
	public partial class frmPesquisarLivro : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();

		public frmPesquisarLivro()
		{
			InitializeComponent();
			conn = banco.abrirConexao();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			//Pesquisa o que foi digitado e preenche o datagrid
			try
			{
				String pesquisa = txtPesquisa.Text;

				String query = @"SELECT IdLivro AS 'Código', Livro, Autor, Genero, Paginas, Quantidade FROM Livro WHERE Livro LIKE '%" + pesquisa + "%'";
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable tabela = new DataTable();
				adapter.Fill(tabela);
				dgPesquisar.DataSource = tabela;
				conn.Close();
			}
			catch (Exception erro)
			{
				MessageBox.Show("ERRO: " + erro.Message);
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtPesquisa.Clear();
		}
	}
}
