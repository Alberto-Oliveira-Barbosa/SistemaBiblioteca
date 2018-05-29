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
	public partial class frmDetalhesLivro : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();

		public void recebeDados(int codigo, String livro, String autor, String genero, int paginas, int qte)
		{
			txtCodigo.Text = Convert.ToString(codigo);
			txtLivro.Text = livro;
			txtAutor.Text = autor;
			cmbGenero.Text = genero;
			txtPaginas.Text = Convert.ToString(paginas);
			txtQTD.Text = Convert.ToString(qte);


		}
		public frmDetalhesLivro()
		{
			InitializeComponent();
			conn = banco.abrirConexao();

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			int codigo = Convert.ToInt32(txtCodigo.Text);
			String livro = txtLivro.Text;
			String autor = txtAutor.Text;
			String genero = cmbGenero.Text;
			int pags = Convert.ToInt32(txtPaginas.Text);
			int qte = Convert.ToInt32(txtQTD.Text);
			try
			{
				//atualiza a tabela usuario
				String query = @"UPDATE Livro SET Livro ='" + livro + "', Autor='" + autor + "', Genero='" + genero+ "', Paginas='" + pags + "', Quantidade='" + qte +  "' WHERE IdLivro ='" + codigo + "';";
				SqlCommand sql = new SqlCommand(query, conn);
				sql.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Livro alterado com sucesso!");
				this.Close();
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro.Message);
			}
		}
	}
}
