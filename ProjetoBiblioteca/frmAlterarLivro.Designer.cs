namespace ProjetoBiblioteca
{
	partial class frmAlterarLivro
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
			this.btnAlterar = new System.Windows.Forms.Button();
			this.dgPesquisar = new System.Windows.Forms.DataGridView();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgPesquisar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFechar
			// 
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Location = new System.Drawing.Point(198, 394);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(143, 41);
			this.btnFechar.TabIndex = 23;
			this.btnFechar.Text = "Fechar janela";
			this.btnFechar.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Location = new System.Drawing.Point(34, 394);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(143, 41);
			this.btnAlterar.TabIndex = 26;
			this.btnAlterar.Text = "Alterar registro";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// dgPesquisar
			// 
			this.dgPesquisar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPesquisar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPesquisar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgPesquisar.Location = new System.Drawing.Point(34, 142);
			this.dgPesquisar.Name = "dgPesquisar";
			this.dgPesquisar.Size = new System.Drawing.Size(801, 222);
			this.dgPesquisar.TabIndex = 25;
			this.dgPesquisar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionaRegistros);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(35, 95);
			this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(630, 25);
			this.txtPesquisa.TabIndex = 24;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(741, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 24);
			this.label1.TabIndex = 21;
			this.label1.Text = "Alterar Livro";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 55);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 20);
			this.label3.TabIndex = 22;
			this.label3.Text = "Digite um nome para pesquisar:";
			// 
			// frmAlterarLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dgPesquisar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmAlterarLivro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAlterarLivro";
			((System.ComponentModel.ISupportInitialize)(this.dgPesquisar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridView dgPesquisar;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}