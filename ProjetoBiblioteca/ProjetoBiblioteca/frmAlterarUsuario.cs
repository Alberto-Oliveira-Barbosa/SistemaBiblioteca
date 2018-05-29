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
	public partial class frmAlterarUsuario : Form
	{
		int codigo;
		String nome, endereco, numero, cpf, telefone, email;
		SqlConnection conn;
		Banco banco = new Banco();

		private void frmAlterarUsuario_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			frmDetalhesUsuario frm = new frmDetalhesUsuario();
			//Envia os dados para o formuário de detalhes
			frm.recebeDados(codigo, nome, endereco, numero, cpf, telefone, email);
			this.Close();
			frm.Show();
		}

		private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
		{
			// pega os dados do datagrid 
			codigo = Convert.ToInt32(dgPesquisar.Rows[e.RowIndex].Cells[0].Value);
			nome = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[1].Value);
			endereco = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[2].Value);
			numero = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[3].Value);
			cpf = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[4].Value);
			telefone = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[5].Value);
			email = Convert.ToString(dgPesquisar.Rows[e.RowIndex].Cells[6].Value);
			btnAlterar.Enabled = true;
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			//Pesquisa o que foi digitado na caixa de pesquisas
			try
			{
				String pesquisa = txtPesquisa.Text;

				String query = @"SELECT IdUsuario AS 'Código', Nome, Endereco, Numero, CPF, Telefone, Email FROM Usuario WHERE Nome LIKE '%" + pesquisa + "%'";

				//Popula o datagrid
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable tabela = new DataTable();
				adapter.Fill(tabela);
				dgPesquisar.DataSource = tabela;
				conn.Close();
			}catch(Exception erro)
			{
				MessageBox.Show("ERRO: " + erro.Message);
			}
		}

		
		public frmAlterarUsuario()
		{
			InitializeComponent();
			//inicializa as conexões e desativa o botão de alterar
			conn = banco.abrirConexao();
			btnAlterar.Enabled = false;
		}
	}
}
