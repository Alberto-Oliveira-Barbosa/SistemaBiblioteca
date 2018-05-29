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
	public partial class frmExcluirUsuario : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();
		int codigo;
		

		public frmExcluirUsuario()
		{
			InitializeComponent();
			conn = banco.abrirConexao();
			btnExcluir.Enabled = false;
		}


		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtPesquisa.Clear();
			txtPesquisa.Focus();
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			//Pesquisa o que foi digitado na caixa de pesquisa e preenche o datagrid
			try
			{
				String pesquisa = txtPesquisa.Text;
				String query = @"SELECT IdUsuario, Nome, Endereco, Numero, CPF, Telefone,Email FROM Usuario WHERE Nome LIKE '%" + pesquisa + "%'";
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable tabela = new DataTable();
				adapter.Fill(tabela);
				dgPesquisa.DataSource = tabela;
			}catch (Exception erro)
			{
				MessageBox.Show("Erro: " + erro.Message);
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que quer excluir o registro?", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					//Deleta do banco
					String query = @"DELETE FROM Usuario WHERE IdUsuario ='" + codigo + "';";
					SqlCommand sql = new SqlCommand(query, conn);
					sql.ExecuteNonQuery();
					txtPesquisa.Text = "";

					//Atualiza o datagrid
					String pesquisa = txtPesquisa.Text;
					query = @"SELECT IdUsuario, Nome, Endereco, Numero, CPF, Telefone,Email FROM Usuario WHERE Nome LIKE '%" + pesquisa + "%'";
					SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
					DataTable tabela = new DataTable();
					adapter.Fill(tabela);
					dgPesquisa.DataSource = tabela;
					btnExcluir.Enabled = false;
				}catch(Exception erro)
				{
					MessageBox.Show("ERRO: " + erro.Message);
				}
			}
		}

		private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
		{
			//pega o valor do ID do registro selecionado no datagrid
			codigo = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[0].Value);
			btnExcluir.Enabled = true;
		}
	}
}
