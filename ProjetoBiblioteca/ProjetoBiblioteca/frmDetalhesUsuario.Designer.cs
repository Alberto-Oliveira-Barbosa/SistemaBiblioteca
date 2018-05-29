namespace ProjetoBiblioteca
{
	partial class frmDetalhesUsuario
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
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.Lime;
			this.btnSalvar.Location = new System.Drawing.Point(133, 368);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(149, 33);
			this.btnSalvar.TabIndex = 23;
			this.btnSalvar.Text = "Alterar usuário";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtTelefone
			// 
			this.txtTelefone.BackColor = System.Drawing.Color.DarkGray;
			this.txtTelefone.Location = new System.Drawing.Point(341, 212);
			this.txtTelefone.Mask = "(##) ####-####";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(100, 25);
			this.txtTelefone.TabIndex = 18;
			// 
			// txtCPF
			// 
			this.txtCPF.BackColor = System.Drawing.Color.DarkGray;
			this.txtCPF.Location = new System.Drawing.Point(133, 214);
			this.txtCPF.Mask = "###.###.###-##";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(111, 25);
			this.txtCPF.TabIndex = 16;
			// 
			// txtEndereco
			// 
			this.txtEndereco.BackColor = System.Drawing.Color.DarkGray;
			this.txtEndereco.Location = new System.Drawing.Point(133, 168);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(390, 25);
			this.txtEndereco.TabIndex = 12;
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.Color.DarkGray;
			this.txtNumero.Location = new System.Drawing.Point(573, 168);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(37, 25);
			this.txtNumero.TabIndex = 14;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
			this.txtEmail.Location = new System.Drawing.Point(133, 260);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(308, 25);
			this.txtEmail.TabIndex = 20;
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.DarkGray;
			this.txtNome.Location = new System.Drawing.Point(133, 122);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(390, 25);
			this.txtNome.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Lime;
			this.label6.Location = new System.Drawing.Point(264, 212);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 19;
			this.label6.Text = "Telefone";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(49, 212);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "CPF";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Lime;
			this.label4.Location = new System.Drawing.Point(49, 258);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(542, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 20);
			this.label3.TabIndex = 13;
			this.label3.Text = "N°";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(46, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Endereço";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Lime;
			this.label7.Location = new System.Drawing.Point(679, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 24);
			this.label7.TabIndex = 8;
			this.label7.Text = "Alterar Usuário";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(46, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Nome";
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.DarkGray;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(133, 74);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(90, 25);
			this.txtCodigo.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Lime;
			this.label8.Location = new System.Drawing.Point(46, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Código";
			// 
			// frmDetalhesUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmDetalhesUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDetalhesUsuario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label8;
	}
}