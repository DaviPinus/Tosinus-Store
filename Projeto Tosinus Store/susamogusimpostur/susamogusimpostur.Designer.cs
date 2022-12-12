namespace susamogusimpostur
{
    partial class Form1
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
            this.registrar = new System.Windows.Forms.Button();
            this.logar = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.perfil = new System.Windows.Forms.TextBox();
            this.nasc = new System.Windows.Forms.DateTimePicker();
            this.atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.search = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmedo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.senhalo = new System.Windows.Forms.MaskedTextBox();
            this.lologin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pBfoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmedo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(10, 297);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(295, 31);
            this.registrar.TabIndex = 0;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // logar
            // 
            this.logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logar.Location = new System.Drawing.Point(6, 195);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(307, 53);
            this.logar.TabIndex = 1;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = false;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(6, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(293, 20);
            this.login.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(6, 205);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(293, 20);
            this.senha.TabIndex = 3;
            this.senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(6, 24);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(293, 20);
            this.nome.TabIndex = 7;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 66);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(293, 20);
            this.email.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Nascimento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Perfil";
            // 
            // perfil
            // 
            this.perfil.Location = new System.Drawing.Point(6, 244);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(293, 20);
            this.perfil.TabIndex = 12;
            // 
            // nasc
            // 
            this.nasc.Location = new System.Drawing.Point(6, 113);
            this.nasc.Name = "nasc";
            this.nasc.Size = new System.Drawing.Size(293, 20);
            this.nasc.TabIndex = 13;
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.atualizar.Location = new System.Drawing.Point(6, 6);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(307, 316);
            this.atualizar.TabIndex = 14;
            this.atualizar.Text = "atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Excluir.Location = new System.Drawing.Point(6, 6);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(307, 316);
            this.Excluir.TabIndex = 15;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 354);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.cboPerfil);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.login);
            this.tabPage1.Controls.Add(this.senha);
            this.tabPage1.Controls.Add(this.nasc);
            this.tabPage1.Controls.Add(this.registrar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.perfil);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nome);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "cadastro";
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(10, 270);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboPerfil.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.search);
            this.tabPage2.Controls.Add(this.searchtxt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dtmedo);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "listar";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(124, 66);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Pesquisar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(16, 19);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(290, 20);
            this.searchtxt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pesquisar";
            // 
            // dtmedo
            // 
            this.dtmedo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtmedo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmedo.Location = new System.Drawing.Point(6, 162);
            this.dtmedo.Name = "dtmedo";
            this.dtmedo.Size = new System.Drawing.Size(305, 158);
            this.dtmedo.TabIndex = 0;
            this.dtmedo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtmedo_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.atualizar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(319, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "atualizar";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.Excluir);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(319, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "excluir";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage5.Controls.Add(this.senhalo);
            this.tabPage5.Controls.Add(this.lologin);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.logar);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(319, 328);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "login";
            // 
            // senhalo
            // 
            this.senhalo.Location = new System.Drawing.Point(53, 63);
            this.senhalo.Name = "senhalo";
            this.senhalo.Size = new System.Drawing.Size(244, 20);
            this.senhalo.TabIndex = 5;
            this.senhalo.UseSystemPasswordChar = true;
            // 
            // lologin
            // 
            this.lologin.Location = new System.Drawing.Point(53, 27);
            this.lologin.Name = "lologin";
            this.lologin.Size = new System.Drawing.Size(244, 20);
            this.lologin.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Login";
            // 
            // pBfoto
            // 
            this.pBfoto.BackColor = System.Drawing.Color.White;
            this.pBfoto.Location = new System.Drawing.Point(406, 100);
            this.pBfoto.Name = "pBfoto";
            this.pBfoto.Size = new System.Drawing.Size(166, 172);
            this.pBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto.TabIndex = 17;
            this.pBfoto.TabStop = false;
            this.pBfoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(434, 22);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(106, 52);
            this.btnFoto.TabIndex = 18;
            this.btnFoto.Text = "ESCOLHER FOTO";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(415, 305);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(147, 20);
            this.txtFoto.TabIndex = 19;
            this.txtFoto.TextChanged += new System.EventHandler(this.txtFoto_TextChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txtComplemento);
            this.tabPage6.Controls.Add(this.txtBairro);
            this.tabPage6.Controls.Add(this.txtCidade);
            this.tabPage6.Controls.Add(this.txtCep);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.txtRua);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(319, 328);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(127, 42);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(167, 20);
            this.txtRua.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Rua";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(127, 92);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(167, 20);
            this.txtCep.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(127, 139);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(127, 178);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(127, 239);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(167, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cep";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Bairro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Complemento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(612, 380);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pBfoto);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmedo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.MaskedTextBox senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox perfil;
        private System.Windows.Forms.DateTimePicker nasc;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtmedo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MaskedTextBox senhalo;
        private System.Windows.Forms.TextBox lologin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.PictureBox pBfoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label10;
    }
}

