using MySql.Data.MySqlClient;//libraby sql
using System;
using System.Data;//biblioteca do sistema
using System.Windows.Forms;//librarby forulario

namespace CheidAr
{
    class conexao
    {
        static private string servidor = "localhost";
        static private string bancodados = "tds";
        static private string usuario = "root";
        static private string senha = "";
        static public string StrCon = "server=" + servidor + ";database=" + bancodados + ";user id=" + usuario + ";password=" + senha;

        public MySqlConnection Getconexao()
        {
            MySqlConnection con = new MySqlConnection(StrCon);
            return con;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                Getconexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha: " + ex.Message);
            }
            return result;
        }

        //metodo para consultar as informacoes do perfil

        public DataTable GetPerfil()
        {
            MySqlConnection conexao = Getconexao();
            string sql = "SELECT * FROM perfil";
            DataTable dbperfil = new DataTable();
            try//trata a conexao e a consulta
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(comando);
                dados.Fill(dbperfil);//popular o resultado

            }
            //tratamento de erro
            catch (Exception ex)
            {//qual erro que esta acontecendo
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dbperfil;
        }
    }
}
