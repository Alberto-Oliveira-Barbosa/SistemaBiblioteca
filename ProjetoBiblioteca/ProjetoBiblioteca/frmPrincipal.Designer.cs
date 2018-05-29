namespace ProjetoBiblioteca
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inclluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.empréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.incluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.empréstimosToolStripMenuItem,
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(900, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclluirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// inclluirToolStripMenuItem
			// 
			this.inclluirToolStripMenuItem.Name = "inclluirToolStripMenuItem";
			this.inclluirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.inclluirToolStripMenuItem.Text = "Incluir";
			this.inclluirToolStripMenuItem.Click += new System.EventHandler(this.inclluirToolStripMenuItem_Click);
			// 
			// alterarToolStripMenuItem
			// 
			this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
			this.alterarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.alterarToolStripMenuItem.Text = "Alterar";
			this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
			// 
			// excluirToolStripMenuItem
			// 
			this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
			this.excluirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.excluirToolStripMenuItem.Text = "Excluir";
			this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
			// 
			// pesquisarToolStripMenuItem
			// 
			this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
			this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.pesquisarToolStripMenuItem.Text = "Pesquisar";
			this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
			// 
			// livrosToolStripMenuItem
			// 
			this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.alterarToolStripMenuItem1,
            this.excluirToolStripMenuItem1,
            this.pesquisarToolStripMenuItem1});
			this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
			this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.livrosToolStripMenuItem.Text = "Livros";
			// 
			// incluirToolStripMenuItem
			// 
			this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
			this.incluirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.incluirToolStripMenuItem.Text = "Incluir";
			this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
			// 
			// alterarToolStripMenuItem1
			// 
			this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
			this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.alterarToolStripMenuItem1.Text = "Alterar";
			this.alterarToolStripMenuItem1.Click += new System.EventHandler(this.alterarToolStripMenuItem1_Click);
			// 
			// excluirToolStripMenuItem1
			// 
			this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
			this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.excluirToolStripMenuItem1.Text = "Excluir";
			this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.excluirToolStripMenuItem1_Click);
			// 
			// pesquisarToolStripMenuItem1
			// 
			this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
			this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
			this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarToolStripMenuItem1_Click);
			// 
			// empréstimosToolStripMenuItem
			// 
			this.empréstimosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem1,
            this.excluirToolStripMenuItem2,
            this.consultarToolStripMenuItem});
			this.empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
			this.empréstimosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.empréstimosToolStripMenuItem.Text = "Empréstimos";
			// 
			// incluirToolStripMenuItem1
			// 
			this.incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
			this.incluirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.incluirToolStripMenuItem1.Text = "Incluir";
			this.incluirToolStripMenuItem1.Click += new System.EventHandler(this.incluirToolStripMenuItem1_Click);
			// 
			// excluirToolStripMenuItem2
			// 
			this.excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
			this.excluirToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.excluirToolStripMenuItem2.Text = "Excluir";
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.consultarToolStripMenuItem.Text = "Consultar";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.toolStripMenuItem1.Text = "Fechar";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(136, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 57);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sistema de Controle de Bibliotecas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(683, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Versão 1.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(22, 442);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(392, 28);
			this.label3.TabIndex = 3;
			this.label3.Text = "Desenvolvido por Alberto Oliveira Barbosa";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Snow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmPrincipal";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema para bibliotecas";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inclluirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem empréstimosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
	}
}

