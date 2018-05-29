namespace ProjetoBiblioteca
{
	partial class frmAlterarUsuario
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
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
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
			this.btnFechar.Location = new System.Drawing.Point(496, 600);
			this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(191, 63);
			this.btnFechar.TabIndex = 9;
			this.btnFechar.Text = "Fechar janela";
			this.btnFechar.UseVisualStyleBackColor = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Location = new System.Drawing.Point(265, 600);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(191, 63);
			this.btnLimpar.TabIndex = 12;
			this.btnLimpar.Text = "Limpar pesquisa";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Location = new System.Drawing.Point(35, 600);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(191, 63);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "Excluir registro";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(977, 16);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Excluir Usuário";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(190, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 41);
			this.button1.TabIndex = 16;
			this.button1.Text = "Fechar janela";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Location = new System.Drawing.Point(26, 385);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(143, 41);
			this.btnAlterar.TabIndex = 20;
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
			this.dgPesquisar.Location = new System.Drawing.Point(26, 133);
			this.dgPesquisar.Name = "dgPesquisar";
			this.dgPesquisar.Size = new System.Drawing.Size(801, 222);
			this.dgPesquisar.TabIndex = 18;
			this.dgPesquisar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selecionaRegistro);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(27, 86);
			this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(630, 25);
			this.txtPesquisa.TabIndex = 17;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(733, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Alterar Usuário";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 46);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "Digite um nome para pesquisar:";
			// 
			// frmAlterarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dgPesquisar);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmAlterarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAlterarUsuario";
			((System.ComponentModel.ISupportInitialize)(this.dgPesquisar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.DataGridView dgPesquisar;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}