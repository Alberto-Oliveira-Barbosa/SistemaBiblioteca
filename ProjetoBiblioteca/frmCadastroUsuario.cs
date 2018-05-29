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
	public partial class frmCadastroUsuario : Form
	{
		public frmCadastroUsuario()
		{
			InitializeComponent();
		}

		private void limparCampos()
		{
			txtNome.Clear();
			txtEndereco.Clear();
			txtNumero.Clear();
			txtCPF.Clear();
			txtTelefone.Clear();
			txtEmail.Clear();
			txtNome.Focus();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			// Verifica se os campos não estão em branco
			if (txtNome.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtCPF.Text != "" && txtTelefone.Text != "")
			{
				//Rotina para inserir no banco de dados
				try
				{
					String nome = txtNome.Text;
					String endereco = txtEndereco.Text;
					int numero = Convert.ToInt32(txtNumero.Text);
					String cpf = txtCPF.Text;
					String tel = txtTelefone.Text;
					String email = txtEmail.Text;

					Banco banco = new Banco();
					SqlConnection conn;
					conn = banco.abrirConexao();

					String query = @"INSERT INTO Usuario (Nome, Endereco, Numero, CPF,Telefone,Email) VALUES ('" + nome + "','" + endereco + "','" + numero + "','" + cpf + "','" + tel + "','" + email + "')";

					SqlCommand sql = new SqlCommand(query, conn);

					sql.ExecuteNonQuery();

					conn.Close();

					MessageBox.Show("Cadastrado com sucesso!");
					limparCampos();
				}catch(Exception erro)
				{
					MessageBox.Show("ERRO : " + erro.Message);
				}
			}
			else
			{
				MessageBox.Show("Verifique se todos os campos foram digitados!");
			}

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limparCampos();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
