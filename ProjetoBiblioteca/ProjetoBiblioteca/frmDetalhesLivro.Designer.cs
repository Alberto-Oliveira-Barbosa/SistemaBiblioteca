namespace ProjetoBiblioteca
{
	partial class frmDetalhesLivro
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
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.txtQTD = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtPaginas = new System.Windows.Forms.TextBox();
			this.txtLivro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.DarkGray;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(156, 74);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(90, 25);
			this.txtCodigo.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Lime;
			this.label8.Location = new System.Drawing.Point(69, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 20);
			this.label8.TabIndex = 40;
			this.label8.Text = "Código";
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.Lime;
			this.btnSalvar.Location = new System.Drawing.Point(156, 368);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(149, 33);
			this.btnSalvar.TabIndex = 39;
			this.btnSalvar.Text = "Alterar livro";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Lime;
			this.label7.Location = new System.Drawing.Point(702, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 24);
			this.label7.TabIndex = 26;
			this.label7.Text = "Alterar Livro";
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
			this.cmbGenero.Location = new System.Drawing.Point(638, 129);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(121, 28);
			this.cmbGenero.TabIndex = 43;
			// 
			// txtQTD
			// 
			this.txtQTD.BackColor = System.Drawing.Color.DarkGray;
			this.txtQTD.Location = new System.Drawing.Point(477, 216);
			this.txtQTD.Name = "txtQTD";
			this.txtQTD.Size = new System.Drawing.Size(69, 25);
			this.txtQTD.TabIndex = 46;
			// 
			// txtAutor
			// 
			this.txtAutor.BackColor = System.Drawing.Color.DarkGray;
			this.txtAutor.Location = new System.Drawing.Point(156, 173);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(390, 25);
			this.txtAutor.TabIndex = 44;
			// 
			// txtPaginas
			// 
			this.txtPaginas.BackColor = System.Drawing.Color.DarkGray;
			this.txtPaginas.Location = new System.Drawing.Point(189, 214);
			this.txtPaginas.Name = "txtPaginas";
			this.txtPaginas.Size = new System.Drawing.Size(53, 25);
			this.txtPaginas.TabIndex = 45;
			// 
			// txtLivro
			// 
			this.txtLivro.BackColor = System.Drawing.Color.DarkGray;
			this.txtLivro.Location = new System.Drawing.Point(156, 127);
			this.txtLivro.Name = "txtLivro";
			this.txtLivro.Size = new System.Drawing.Size(390, 25);
			this.txtLivro.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Lime;
			this.label6.Location = new System.Drawing.Point(319, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 20);
			this.label6.TabIndex = 51;
			this.label6.Text = "Quantidade em estoque";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(72, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 20);
			this.label5.TabIndex = 50;
			this.label5.Text = "Total de Páginas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(561, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 49;
			this.label3.Text = "Gênero";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(69, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Autor";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(69, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 47;
			this.label1.Text = "Livro";
			// 
			// frmDetalhesLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.cmbGenero);
			this.Controls.Add(this.txtQTD);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.txtPaginas);
			this.Controls.Add(this.txtLivro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmDetalhesLivro";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDetalhesLivro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbGenero;
		private System.Windows.Forms.TextBox txtQTD;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtPaginas;
		private System.Windows.Forms.TextBox txtLivro;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}