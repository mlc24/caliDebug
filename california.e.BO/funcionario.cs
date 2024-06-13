using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace california.e.BO
{
    public class funcionario
    {
        public string cargoFunc { get; set; }
        public string usuarioFunc { get; set; }
        public string senhaFunc { get; set; }
        public string nomeFunc { get; set; }
        public string cpfFunc { get; set; }
        public DateTime dtNascimento { get; set; }
        public string telefoneFunc { get; set; }
        public string enderecoFunc { get; set; }
        public string confSenha{ get; }    
        

        public void cadastrarFunc(funcionario funcionario)
        {
            string conexaoBD = "server = localhost; database = california; uid = root; pwd = etec";

            MySqlConnection conn = new MySqlConnection(conexaoBD);
            conn.Open();

            string sqlcommand = "insert into funcionario(cargoFunc,usuarioFunc,senhaFunc,nomeFunc,cpfFunc,dtNascimento,telefoneFunc,enderecoFunc)" +
                                "values(' " + funcionario.cargoFunc+ " ', '  " + funcionario.usuarioFunc + " ' , ' " + funcionario.senhaFunc + " ' , ' " + funcionario.nomeFunc + " ' , ' " + funcionario.cpfFunc + " ' , ' " + funcionario.dtNascimento.ToString("yyyy-MM-dd") + " ' , ' " + funcionario.telefoneFunc + " ' , ' " + funcionario.enderecoFunc + " '); ";

            MySqlCommand comando = new MySqlCommand(sqlcommand, conn);
            comando.ExecuteNonQuery();


        }
    }
}
