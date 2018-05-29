namespace ProjetoBiblioteca
{
	partial class frmExcluirLivro
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
			this.btnExcluir = new System.Windows.Forms.Button();
			this.dgPesquisa = new System.Windows.Forms.DataGridView();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFechar
			// 
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Location = new System.Drawing.Point(380, 390);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(143, 41);
			this.btnFechar.TabIndex = 9;
			this.btnFechar.Text = "Fechar janela";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Location = new System.Drawing.Point(207, 390);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(143, 41);
			this.btnLimpar.TabIndex = 12;
			this.btnLimpar.Text = "Limpar pesquisa";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Location = new System.Drawing.Point(34, 390);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(143, 41);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "Excluir Livro";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// dgPesquisa
			// 
			this.dgPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPesquisa.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPesquisa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgPesquisa.Location = new System.Drawing.Point(34, 138);
			this.dgPesquisa.Name = "dgPesquisa";
			this.dgPesquisa.Size = new System.Drawing.Size(801, 222);
			this.dgPesquisa.TabIndex = 11;
			this.dgPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionaRegistros);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(35, 91);
			this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(630, 25);
			this.txtPesquisa.TabIndex = 10;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(741, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Excluir Livro";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Digite um nome para pesquisar:";
			// 
			// frmExcluirLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.dgPesquisa);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmExcluirLivro";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmExcluirLivro";
			((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.DataGridView dgPesquisa;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}