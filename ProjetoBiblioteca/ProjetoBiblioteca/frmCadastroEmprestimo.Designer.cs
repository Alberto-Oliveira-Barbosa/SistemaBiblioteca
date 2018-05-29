namespace ProjetoBiblioteca
{
	partial class frmCadastroEmprestimo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtCodUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtCodLivro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLivro = new System.Windows.Forms.TextBox();
			this.lblLivro = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dgData = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRetirada = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(97, 55);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(400, 25);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
			// 
			// txtCodUsuario
			// 
			this.txtCodUsuario.Location = new System.Drawing.Point(663, 55);
			this.txtCodUsuario.Name = "txtCodUsuario";
			this.txtCodUsuario.Size = new System.Drawing.Size(67, 25);
			this.txtCodUsuario.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(521, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Código do Usuário";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(93, 101);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(56, 20);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuário";
			this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtCodLivro
			// 
			this.txtCodLivro.Location = new System.Drawing.Point(663, 145);
			this.txtCodLivro.Name = "txtCodLivro";
			this.txtCodLivro.Size = new System.Drawing.Size(67, 25);
			this.txtCodLivro.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(521, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Código do Livro";
			// 
			// txtLivro
			// 
			this.txtLivro.Location = new System.Drawing.Point(97, 145);
			this.txtLivro.Name = "txtLivro";
			this.txtLivro.Size = new System.Drawing.Size(400, 25);
			this.txtLivro.TabIndex = 6;
			this.txtLivro.TextChanged += new System.EventHandler(this.txtLivro_TextChanged);
			// 
			// lblLivro
			// 
			this.lblLivro.AutoSize = true;
			this.lblLivro.Location = new System.Drawing.Point(93, 191);
			this.lblLivro.Name = "lblLivro";
			this.lblLivro.Size = new System.Drawing.Size(39, 20);
			this.lblLivro.TabIndex = 4;
			this.lblLivro.Text = "Livro";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Livro";
			// 
			// dgData
			// 
			this.dgData.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgData.Location = new System.Drawing.Point(31, 234);
			this.dgData.Name = "dgData";
			this.dgData.Size = new System.Drawing.Size(610, 150);
			this.dgData.TabIndex = 9;
			this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.atualizaCampos);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(689, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Data de retirada";
			// 
			// txtRetirada
			// 
			this.txtRetirada.Location = new System.Drawing.Point(693, 265);
			this.txtRetirada.Mask = "00/00/0000";
			this.txtRetirada.Name = "txtRetirada";
			this.txtRetirada.Size = new System.Drawing.Size(100, 25);
			this.txtRetirada.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(689, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Data de devolução";
			// 
			// txtDevolucao
			// 
			this.txtDevolucao.Location = new System.Drawing.Point(693, 339);
			this.txtDevolucao.Mask = "00/00/0000";
			this.txtDevolucao.Name = "txtDevolucao";
			this.txtDevolucao.Size = new System.Drawing.Size(100, 25);
			this.txtDevolucao.TabIndex = 10;
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Location = new System.Drawing.Point(63, 414);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(192, 56);
			this.btnSalvar.TabIndex = 11;
			this.btnSalvar.Text = "Cadastrar empréstimo";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(680, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(207, 24);
			this.label7.TabIndex = 2;
			this.label7.Text = "Cadastro de Empréstimos";
			// 
			// btnFechar
			// 
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Location = new System.Drawing.Point(285, 414);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(192, 56);
			this.btnFechar.TabIndex = 11;
			this.btnFechar.Text = "Fechar janela";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// frmCadastroEmprestimo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtDevolucao);
			this.Controls.Add(this.txtRetirada);
			this.Controls.Add(this.dgData);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCodLivro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLivro);
			this.Controls.Add(this.lblLivro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCodUsuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCadastroEmprestimo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastroEmprestimo";
			((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtCodUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtCodLivro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLivro;
		private System.Windows.Forms.Label lblLivro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgData;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtRetirada;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox txtDevolucao;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnFechar;
	}
}