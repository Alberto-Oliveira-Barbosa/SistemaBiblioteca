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
	public partial class frmDetalhesUsuario : Form
	{
		SqlConnection conn;
		Banco banco = new Banco();

		public frmDetalhesUsuario()
		{
			InitializeComponent();
			conn = banco.abrirConexao();
		}

		public void recebeDados(int codigo, String nome, String endereco, String numero, String cpf, String telefone, String email)
		{
			//Recebe os dados para preencher o formulário
			txtCodigo.Text = Convert.ToString(codigo);
			txtNome.Text = nome;
			txtEndereco.Text = endereco;
			txtNumero.Text = numero;
			txtCPF.Text = cpf;
			txtTelefone.Text = telefone;
			txtEmail.Text = email;

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			int codigo = Convert.ToInt32(txtCodigo.Text);
			String nome = txtNome.Text;
			String endereco = txtEndereco.Text;
			String numero = txtNumero.Text;
			String cpf = txtCPF.Text;
			String tel = txtTelefone.Text;
			String email = txtEmail.Text;
			try
			{
				//atualiza a tabela usuario
				String query = @"UPDATE Usuario SET Nome ='" + nome + "', Endereco='" + endereco + "', numero='" + numero + "', CPF='" + cpf + "', Telefone='" + tel + "', Email='" + email + "' WHERE IdUsuario ='" + codigo + "';";
				SqlCommand sql = new SqlCommand(query, conn);
				sql.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Usuário alterado com sucesso!");
				this.Close();
			}catch(Exception erro)
			{
				MessageBox.Show("Erro: " + erro.Message);
			}
		

		}
	}
}
