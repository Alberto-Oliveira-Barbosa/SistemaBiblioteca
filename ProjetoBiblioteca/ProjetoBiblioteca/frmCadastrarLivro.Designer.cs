namespace ProjetoBiblioteca
{
	partial class frmCadastrarLivro
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
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtPaginas = new System.Windows.Forms.TextBox();
			this.txtLivro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQTD = new System.Windows.Forms.TextBox();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnFechar
			// 
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.ForeColor = System.Drawing.Color.Lime;
			this.btnFechar.Location = new System.Drawing.Point(487, 372);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(149, 33);
			this.btnFechar.TabIndex = 8;
			this.btnFechar.Text = "Fechar janela";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.Color.Lime;
			this.btnLimpar.Location = new System.Drawing.Point(310, 372);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(149, 33);
			this.btnLimpar.TabIndex = 7;
			this.btnLimpar.Text = "Limpar Campos";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.Lime;
			this.btnSalvar.Location = new System.Drawing.Point(133, 372);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(149, 33);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Salvar Livro";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtAutor
			// 
			this.txtAutor.BackColor = System.Drawing.Color.DarkGray;
			this.txtAutor.Location = new System.Drawing.Point(133, 172);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(390, 25);
			this.txtAutor.TabIndex = 3;
			// 
			// txtPaginas
			// 
			this.txtPaginas.BackColor = System.Drawing.Color.DarkGray;
			this.txtPaginas.Location = new System.Drawing.Point(166, 213);
			this.txtPaginas.Name = "txtPaginas";
			this.txtPaginas.Size = new System.Drawing.Size(53, 25);
			this.txtPaginas.TabIndex = 4;
			// 
			// txtLivro
			// 
			this.txtLivro.BackColor = System.Drawing.Color.DarkGray;
			this.txtLivro.Location = new System.Drawing.Point(133, 126);
			this.txtLivro.Name = "txtLivro";
			this.txtLivro.Size = new System.Drawing.Size(390, 25);
			this.txtLivro.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Lime;
			this.label6.Location = new System.Drawing.Point(296, 218);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 20);
			this.label6.TabIndex = 19;
			this.label6.Text = "Quantidade em estoque";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(49, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Total de Páginas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(538, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "Gênero";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(46, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Autor";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Lime;
			this.label7.Location = new System.Drawing.Point(679, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(153, 24);
			this.label7.TabIndex = 8;
			this.label7.Text = "Cadastro de Livros";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(46, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Livro";
			// 
			// txtQTD
			// 
			this.txtQTD.BackColor = System.Drawing.Color.DarkGray;
			this.txtQTD.Location = new System.Drawing.Point(454, 215);
			this.txtQTD.Name = "txtQTD";
			this.txtQTD.Size = new System.Drawing.Size(69, 25);
			this.txtQTD.TabIndex = 5;
			// 
			// cmbGenero
			// 
			this.cmbGenero.FormattingEnabled = true;
			this.cmbGenero.Items.AddRange(new object[] {
            "Terror",
            "Suspense",
            "Infanto-juvenil",
            "Aventura",
            "Auto-ajuda",
            "Esportes",
            "Linguas"});
			this.cmbGenero.Location = new System.Drawing.Point(615, 128);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(121, 28);
			this.cmbGenero.TabIndex = 2;
			// 
			// frmCadastrarLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.cmbGenero);
			this.Controls.Add(this.txtQTD);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.txtPaginas);
			this.Controls.Add(this.txtLivro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCadastrarLivro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastrarLivro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtPaginas;
		private System.Windows.Forms.TextBox txtLivro;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQTD;
		private System.Windows.Forms.ComboBox cmbGenero;
	}
}