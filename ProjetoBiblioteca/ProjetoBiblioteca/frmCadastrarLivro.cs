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
	public partial class frmCadastrarLivro : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();
		public frmCadastrarLivro()
		{
			InitializeComponent();
			conn = banco.abrirConexao();

		}
		private void limparDados()
		{
			txtLivro.Clear();
			txtAutor.Clear();
			txtPaginas.Clear();
			txtQTD.Clear();
			txtLivro.Focus();
		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (txtLivro.Text != "" && txtAutor.Text != "" && cmbGenero.Text!=""&& txtPaginas.Text != "" && txtQTD.Text != "")
			{
				try
				{
					String livro = txtLivro.Text;
					String autor = txtAutor.Text;
					String genero = cmbGenero.Text;
					int pags = Convert.ToInt32(txtPaginas.Text);
					int qtd = Convert.ToInt32(txtQTD.Text);

					//Query de insert na tabela livro
					String query = @"INSERT INTO Livro(Livro, Autor, Genero, Paginas, Quantidade) VALUES ('" + livro + "','" + autor + "','" + genero + "','" + pags + "','" + qtd + "');";
					SqlCommand sql = new SqlCommand(query, conn);
					sql.ExecuteNonQuery();
					conn.Close();

					MessageBox.Show("Livro cadastrado com sucesso!");
					limparDados();
				}catch(Exception er)
				{
					MessageBox.Show("ERRO: " + er.Message);
				}
			}
			else
			{
				MessageBox.Show("Todos os campos são obrigatórios!");
			}
		
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limparDados();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
