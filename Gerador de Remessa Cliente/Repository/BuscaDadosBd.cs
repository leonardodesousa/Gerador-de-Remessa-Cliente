using Gerador_de_Remessa_Cliente.Framework;
using Gerador_de_Remessa_Cliente.Model;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace Gerador_de_Remessa_Cliente.Repository
{
    internal class BuscaDadosBd
    {
        public Conta buscaConta(string numeroConta, int unidade)
        {
            //String dataBase = "oracle";

            List<string> parametrosBD = new List<string>();
            DbParametros db = new DbParametros();
            parametrosBD = db.buscaParametrosConexaoOracle();

            List<string> login = new List<string>();
            UserBancoDeDados user = new UserBancoDeDados();
            login = user.getLoginBd();

            string dataBase = parametrosBD[0];
            string host = parametrosBD[1];
            string port = parametrosBD[2];
            string serverName = parametrosBD[3];
            string disponOwner = parametrosBD[4];
            string userId = login[0];
            string password = login[1];

            Conta conta = new Conta();
                        

            var query = " SELECT cadc.CD_CC,                                                                                                      " +
                        "        cadc.NM_ABV_TLC,                                                                                                 " +
                        "        cadc.CD_CLI,                                                                                                     " +
                        "        coalesce((select vl_sdo                                                                                          " +
                        "        from " + disponOwner + ".t401mvto                                                                                " +
                        "       where cd_cc =" + numeroConta + "                                                                                  " +
                        "       and nr_seq =                                                                                                      " +
                        "           (select max(nr_seq) from " + disponOwner + ".t401mvto where cd_cc = "+ numeroConta +")                        " +
                        "       and dt_lan = (select dt_pro_atu from "+ disponOwner +".t401agen where cd_und = "+ unidade + ")),sd_dsp_d1),       " +
                        "       sd_blq_24d1 + sd_blq_48d1 + sd_blq_ncd1 as saldoBloqueado,                                                        " + 
                        "        sd_blq_24d1 + sd_blq_48d1 + sd_blq_ncd1 as saldoBloqueado,                                                       " +
                        "        sd_blq_jdd1 + sd_blq_add1 as saldoBloqu                                                                          " +
                        "  from " + disponOwner + ".t401sdct sdct                                                                                 " +
                        " inner join " + disponOwner + ".t401cadc cadc                                                                            " +
                        "    on cadc.cd_cc = sdct.cd_cta                                                                                          " +
                        "   and sdct.cd_und = cadc.cd_und                                                                                         " +
                        " where  sdct.cd_und = " + unidade + "                                                                                    " +
                        "   and sdct.cd_cta = " + numeroConta;                      

            if (dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                
                //System.Windows.Forms.MessageBox.Show("Host recebe " + host); // AQUI!!!!!!!!!!!!!

                try
                {
                    conn.Open();
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Impossível conectar ao Banco: " + e);
                }
                try
                {                    
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        conta.numeroConta = dr.GetString(0);
                        conta.nome = dr.GetString(1);
                        conta.codigoCliente = dr.GetInt64(2);
                        conta.saldoDisponivel = dr.GetDouble(3);
                        conta.saldoBloqueado = dr.GetDouble(4);
                        conta.saldoBloqueadoJudAdm = dr.GetDouble(5);                        
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return conta;
        }
    }
}
