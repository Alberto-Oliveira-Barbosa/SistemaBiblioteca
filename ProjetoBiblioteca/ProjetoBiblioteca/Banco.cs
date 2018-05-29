using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
	class Banco
	{
		SqlConnection conn;

		public SqlConnection abrirConexao()
		{
			conn = new SqlConnection();
			//Alterar o caminho da string de conexão
			//conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= CAMINHO DO BANCO DE DADOS ;Integrated Security=True;Connect Timeout=30";
			conn.Open();
			return conn;
		}

		public void fecharConexao()
		{
			conn.Close();
		}
	}
}
