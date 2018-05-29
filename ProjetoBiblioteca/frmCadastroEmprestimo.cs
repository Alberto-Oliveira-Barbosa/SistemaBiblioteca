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
	public partial class frmCadastroEmprestimo : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();
		int selecao, codUsuario, codLivro;
		String usuario, livro, retirada, devolucao;

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			//se não estiver nada em branco
			if(txtUsuario.Text!= "" && txtLivro.Text != "")
			{
				//recupera os valores
				usuario = lblUsuario.Text;
				livro = lblUsuario.Text;
				codUsuario = Convert.ToInt32(txtCodUsuario.Text);
				codLivro = Convert.ToInt32(txtCodLivro.Text);
				retirada = txtRetirada.Text;
				devolucao = txtDevolucao.Text;

				String query = @"INSERT INTO Emprestimo (Id_Usuario, Id_Livro, Usuario, Livro, Retirada, Devolucao) Values('" + codUsuario + "','" + codLivro + "','" + usuario + "','" + livro + "','" + retirada + "','" + devolucao + "');";
				SqlCommand sql = new SqlCommand(query, conn);
				sql.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Empréstimo cadastrado com sucesso!");

			}
			else
			{
				MessageBox.Show("Todos os campos devem ser preenchidos!");
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void atualizaCampos(object sender, DataGridViewCellEventArgs e)
		{
			if (selecao == 1)
			{
				codUsuario = Convert.ToInt32(dgData.Rows[e.RowIndex].Cells[0].Value);
				txtCodUsuario.Text = Convert.ToString(codUsuario);
				usuario = Convert.ToString(dgData.Rows[e.RowIndex].Cells[1].Value);
				lblUsuario.Text = usuario;
			}
			if (selecao == 2)
			{
				codLivro = Convert.ToInt32(dgData.Rows[e.RowIndex].Cells[0].Value);
				txtCodLivro.Text = Convert.ToString(codLivro);
				livro = Convert.ToString(dgData.Rows[e.RowIndex].Cells[1].Value);
				lblLivro.Text = livro;
			}
		}

		private void txtLivro_TextChanged(object sender, EventArgs e)
		{
			String pesquisa = txtLivro.Text;

			String query = @"SELECT IdLivro AS 'Código', Livro, Autor, Genero, Paginas, Quantidade FROM Livro WHERE Livro LIKE '%" + pesquisa + "%'";
			SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
			DataTable tabela = new DataTable();
			adapter.Fill(tabela);
			dgData.DataSource = tabela;

			selecao = 2;
		}

		private void txtUsuario_TextChanged(object sender, EventArgs e)
		{
			String pesquisa = txtUsuario.Text;

			String query = @"SELECT IdUsuario AS 'Código', Nome, Endereco, Numero, CPF, Telefone, Email FROM Usuario WHERE Nome LIKE '%" + pesquisa + "%'";
			SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
			DataTable tabela = new DataTable();
			adapter.Fill(tabela);
			dgData.DataSource = tabela;

			selecao = 1;
		}

		public frmCadastroEmprestimo()
		{
			InitializeComponent();
			conn = banco.abrirConexao();
			//o sistema vai pegar a data atual para o campo devolução e vai acrescentar mais 5 dias para o retirada
			txtRetirada.Text = DateTime.Now.ToShortDateString();
			txtDevolucao.Text = DateTime.Now.AddDays(5).ToShortDateString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
