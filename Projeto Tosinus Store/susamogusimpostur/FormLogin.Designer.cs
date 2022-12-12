namespace CheidAr

{
    partial class FormSegundo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridListar = new System.Windows.Forms.DataGridView();
            this.cod_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atualizar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Excluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).BeginInit();
            this.Atualizar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Atualizar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.searchtxt);
            this.tabPage2.Controls.Add(this.search);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar Informações";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 67);
            this.label7.MinimumSize = new System.Drawing.Size(180, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Insira um nome para pesquisa:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(27, 96);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(266, 20);
            this.searchtxt.TabIndex = 5;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.search.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(106, 122);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(109, 38);
            this.search.TabIndex = 4;
            this.search.Text = "Pesquisar";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridListar
            // 
            this.dataGridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_usuario,
            this.nome,
            this.email,
            this.datanasc,
            this.fone,
            this.cod_perfil,
            this.login,
            this.senha,
            this.perfil,
            this.id_endereco});
            this.dataGridListar.Location = new System.Drawing.Point(330, 89);
            this.dataGridListar.Name = "dataGridListar";
            this.dataGridListar.Size = new System.Drawing.Size(452, 290);
            this.dataGridListar.TabIndex = 0;
            this.dataGridListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListar_CellContentClick);
            // 
            // cod_usuario
            // 
            this.cod_usuario.DataPropertyName = "cod_usuario";
            this.cod_usuario.HeaderText = "Cod. User";
            this.cod_usuario.Name = "cod_usuario";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome User";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // datanasc
            // 
            this.datanasc.DataPropertyName = "datanasc";
            this.datanasc.HeaderText = "Data Nasc";
            this.datanasc.Name = "datanasc";
            // 
            // fone
            // 
            this.fone.DataPropertyName = "fone";
            this.fone.HeaderText = "Fone";
            this.fone.Name = "fone";
            // 
            // cod_perfil
            // 
            this.cod_perfil.DataPropertyName = "cod_perfil";
            this.cod_perfil.HeaderText = "Cod. Perfil";
            this.cod_perfil.Name = "cod_perfil";
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            // 
            // perfil
            // 
            this.perfil.DataPropertyName = "perfil";
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            // 
            // id_endereco
            // 
            this.id_endereco.DataPropertyName = "id_endereco";
            this.id_endereco.HeaderText = "Id Endereço";
            this.id_endereco.Name = "id_endereco";
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Atualizar.Controls.Add(this.label1);
            this.Atualizar.Controls.Add(this.button1);
            this.Atualizar.Location = new System.Drawing.Point(4, 22);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Padding = new System.Windows.Forms.Padding(3);
            this.Atualizar.Size = new System.Drawing.Size(322, 428);
            this.Atualizar.TabIndex = 2;
            this.Atualizar.Text = "Atualizar Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selecione os dados para atualizar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.button1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(57, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.atualizar_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Excluir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 428);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Excluir Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecione os dados para exclusão";
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Excluir.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.Excluir.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.Color.White;
            this.Excluir.Location = new System.Drawing.Point(59, 128);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(195, 63);
            this.Excluir.TabIndex = 16;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // FormSegundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheidAr.Properties.Resources.Sem_sex;
            this.ClientSize = new System.Drawing.Size(610, 380);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridListar);
            this.Name = "FormSegundo";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormSegundo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).EndInit();
            this.Atualizar.ResumeLayout(false);
            this.Atualizar.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Atualizar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_endereco;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}