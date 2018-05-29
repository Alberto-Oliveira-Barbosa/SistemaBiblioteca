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
	public partial class frmAlterarLivro : Form
	{
		int codigo;
		String livro, autor, genero;
		int paginas, qte;

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			frmDetalhesLivro frm = new frmDetalhesLivro();
			//Envia os dados para o formuário de detalhes
			frm.recebeDados(codigo, livro,autor,genero,paginas,qte);
			this.Close();
			frm.Show();
		}

		private void selecionaRegistros(object sender, DataGridViewCellEventArgs e)
		{
			// pega os dados do datagrid 
			codigo = Convert.ToInt32(dgPesquisar.Rows[e.RowIndex].Cells[0].Value);
			livro = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[1].Value);
			autor = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[2].Value);
			genero = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[3].Value);
			paginas = Convert.ToInt32(dgPesquisar.Rows[e.RowIndex].Cells[4].Value);
			qte = Convert.ToInt32(dgPesquisar.Rows[e.RowIndex].Cells[5].Value);
			btnAlterar.Enabled = true;
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//Pesquisa o que foi digitado na caixa de pesquisas

				String pesquisa = txtPesquisa.Text;

				String query = @"SELECT IdLivro AS 'Código', Livro, Autor, Genero, Paginas, Quantidade FROM Livro WHERE Livro LIKE '%" + pesquisa + "%'";

				//Popula o datagrid
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable tabela = new DataTable();
				adapter.Fill(tabela);
				dgPesquisar.DataSource = tabela;
				conn.Close();
			}catch(Exception er)
			{
				MessageBox.Show("ERRO: " + er.Message);
			}

		}

		SqlConnection conn;
		Banco banco = new Banco();
		public frmAlterarLivro()
		{
			InitializeComponent();
			conn = banco.abrirConexao();
		}
	}
}
