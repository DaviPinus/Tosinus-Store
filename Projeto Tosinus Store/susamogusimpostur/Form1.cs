using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace susamogusimpostur
{
    public partial class Form1 : Form
    {
        int codigo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string SQL = "INSERT INTO usuário(nome,email,datanasc,login,senha,perfil)" +
            "values(@nome,@email,@datanasc,@login,@senha,@perfil)";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@nome", nome.Text);
            comando.Parameters.AddWithValue("@email", email.Text);
            comando.Parameters.AddWithValue("@datanasc", nasc.Value);
            comando.Parameters.AddWithValue("@login", login.Text);
            comando.Parameters.AddWithValue("@senha", senha.Text);
            comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfil.Text));
            conexao.Open();
            if (comando.ExecuteNonQuery()>=1)
            {
                MessageBox.Show("cadastro concluido");
            }
            else
            {
                MessageBox.Show("erro no cadastro");
            }
            conexao.Close();
            
        
    
        }

        private void search_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string consulta;
            if (searchtxt.Text == "")
            {
                consulta = "Select * FROM usuário";
            }
            else
            {
                consulta = "Select * FROM usuário WHERE nome like '%" + searchtxt.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuário = new DataTable();
            dados.Fill(dtUsuário);
            dtmedo.DataSource = dtUsuário;
            conexao.Close();
        }

        private void dtmedo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dtmedo.Rows[e.RowIndex].Cells[0].Value);
                conexao con = new conexao();
                MySqlConnection conexao = con.Getconexao();
                string SQL = "SELECT * FROM usuário WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    email.Text = Convert.ToString(registro["email"]);
                    nome.Text = Convert.ToString(registro["nome"]);
                    login.Text = Convert.ToString(registro["login"]);
                    senha.Text = Convert.ToString(registro["senha"]);
                    perfil.Text = Convert.ToString(registro["perfil"]);
                }
                else
                {
                    MessageBox.Show("falha ao obter registro");
                }
                conexao.Close();
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            if (codigo > 0)
            {
                string SQL = "UPDATE usuário set nome=@nome,email=@email," +
                    "datanasc=@datanasc,login=@login,senha=@senha,perfil=@perfil WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@nome", nome.Text);
                comando.Parameters.AddWithValue("@email", email.Text);
                comando.Parameters.AddWithValue("@datanasc", nasc.Value);
                comando.Parameters.AddWithValue("@login", login.Text);
                comando.Parameters.AddWithValue("@senha", senha.Text);
                comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfil.Text));
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                if (comando.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("atualizado com perfeição");
                }
                else
                {
                    MessageBox.Show("erro/falta de dados");
                }
            }
            else
            {
                MessageBox.Show("selecione algum dado na listagem");
            }
        }
    }
}