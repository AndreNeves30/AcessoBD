using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AcessoBD
{
    class Conexao
    {
        private static string srtConexao = 
            @"Server = localhost; Database = acessobd;
            Uid = astrogildo; Pwd = 123456";

        private static MySqlConnection cn = new MySqlConnection(srtConexao);

        public static MySqlConnection abreConexao()
        {
            try
            {
                if (cn.State.ToString() == "Closed")
                {

                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
