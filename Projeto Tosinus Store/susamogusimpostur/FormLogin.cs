using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace CheidAr
{

    public partial class FormSegundo : System.Windows.Forms.Form
    {
        int codigo;

        public FormSegundo()
        {
            InitializeComponent();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dataGridListar.Rows[e.RowIndex].Cells[0].Value);
                conexao con = new conexao();
                MySqlConnection conexao = con.Getconexao();
                string SQL = "SELECT * FROM usuario WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    email.HeaderText = Convert.ToString(registro["@email"]);
                    nome.HeaderText = Convert.ToString(registro["@nome"]);
                    login.HeaderText = Convert.ToString(registro["@login"]);
                    senha.HeaderText = Convert.ToString(registro["@senha"]);

                }
                else
                {
                    MessageBox.Show("falha ao obter registro");
                }
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string consulta;
            if (searchtxt.Text == "")
            {
                consulta = "Select * FROM usuario";
            }
            else
            {
                consulta = "Select * FROM usuario WHERE nome like '%" + searchtxt.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuário = new DataTable();
            dados.Fill(dtUsuário);
            dataGridListar.DataSource = dtUsuário;
            DataGridViewImageColumn img = new DataGridViewImageColumn();



            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //img.Image coloca a imagem


            conexao.Close();
        }

        private void atualizar_Click_1(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            codigo++;
            if (codigo > 0)
            {
                string SQL = "UPDATE usuario set nome=@nome,email=@email," +
                    "datanasc=@datanasc,login=@login,senha=@senha,perfil=@perfil WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@nome", nome.HeaderText);
                comando.Parameters.AddWithValue("@email", email.HeaderText);
                comando.Parameters.AddWithValue("@datanasc", datanasc.ValueType);
                comando.Parameters.AddWithValue("@login", login.HeaderText);
                comando.Parameters.AddWithValue("@senha", senha.HeaderText);
                comando.Parameters.AddWithValue("@perfil", perfil.HeaderText);
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
            conexao.Close();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string SQL = "DELETE FROM usuario WHERE usercode=@codigo";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@codigo", codigo);
            conexao.Open();
            if (comando.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("excluido com sucesso");
            }
            else
            {
                MessageBox.Show("erro na exclusão");
            }
            conexao.Close();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSegundo_Load(object sender, EventArgs e)
        {
          

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
