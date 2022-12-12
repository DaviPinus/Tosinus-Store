namespace CheidAr
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
            this.nasc = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lologin = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.pBfoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.senhalo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrar
            // 
            this.registrar.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.registrar.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.ForeColor = System.Drawing.Color.White;
            this.registrar.Location = new System.Drawing.Point(8, 298);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(295, 49);
            this.registrar.TabIndex = 0;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // logar
            // 
            this.logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logar.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.logar.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logar.ForeColor = System.Drawing.Color.White;
            this.logar.Location = new System.Drawing.Point(44, 198);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(244, 43);
            this.logar.TabIndex = 1;
            this.logar.Text = "Login";
            this.logar.UseVisualStyleBackColor = false;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(6, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(293, 20);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(6, 205);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(293, 20);
            this.senha.TabIndex = 3;
            this.senha.UseSystemPasswordChar = true;
            this.senha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.senha_MaskInputRejected);
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
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 66);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(293, 20);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de nascimento";
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
            // nasc
            // 
            this.nasc.Location = new System.Drawing.Point(6, 113);
            this.nasc.Name = "nasc";
            this.nasc.Size = new System.Drawing.Size(293, 20);
            this.nasc.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 385);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cboPerfil);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.login);
            this.tabPage1.Controls.Add(this.senha);
            this.tabPage1.Controls.Add(this.nasc);
            this.tabPage1.Controls.Add(this.registrar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nome);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Items.AddRange(new object[] {
            "ALUNO",
            "PROFESSOR "});
            this.cboPerfil.Location = new System.Drawing.Point(6, 256);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboPerfil.TabIndex = 14;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged_2);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.senhalo);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.lologin);
            this.tabPage5.Controls.Add(this.logar);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(332, 359);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Usuário";
            // 
            // lologin
            // 
            this.lologin.Location = new System.Drawing.Point(131, 112);
            this.lologin.Multiline = true;
            this.lologin.Name = "lologin";
            this.lologin.Size = new System.Drawing.Size(157, 20);
            this.lologin.TabIndex = 4;
            this.lologin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lologin.TextChanged += new System.EventHandler(this.lologin_TextChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.tabPage6.Size = new System.Drawing.Size(332, 359);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Endereço";
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Complemento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "CEP";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(127, 197);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(167, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(127, 162);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(127, 126);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(127, 92);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(167, 20);
            this.txtCep.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(127, 58);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(167, 20);
            this.txtRua.TabIndex = 0;
            // 
            // pBfoto
            // 
            this.pBfoto.BackColor = System.Drawing.Color.White;
            this.pBfoto.Location = new System.Drawing.Point(392, 144);
            this.pBfoto.Name = "pBfoto";
            this.pBfoto.Size = new System.Drawing.Size(177, 154);
            this.pBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto.TabIndex = 17;
            this.pBfoto.TabStop = false;
            this.pBfoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.btnFoto.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.Location = new System.Drawing.Point(392, 76);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(177, 52);
            this.btnFoto.TabIndex = 18;
            this.btnFoto.Text = "Selecionar Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(392, 316);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(177, 20);
            this.txtFoto.TabIndex = 19;
            this.txtFoto.TextChanged += new System.EventHandler(this.txtFoto_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CheidAr.Properties.Resources.MOYAI;
            this.pictureBox1.Location = new System.Drawing.Point(346, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(409, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 55);
            this.label6.TabIndex = 21;
            this.label6.Text = "TOSINUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Perfil";
            // 
            // senhalo
            // 
            this.senhalo.Location = new System.Drawing.Point(131, 148);
            this.senhalo.Multiline = true;
            this.senhalo.Name = "senhalo";
            this.senhalo.Size = new System.Drawing.Size(157, 20);
            this.senhalo.TabIndex = 8;
            this.senhalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.ClientSize = new System.Drawing.Size(612, 380);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker nasc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox lologin;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox senhalo;
    }
}

