using Gerador_de_Remessa_Cliente.Framework;
using Gerador_de_Remessa_Cliente.Model;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Repository
{
    internal class PersisteDadosBd
    {

        public bool insereMovimentoConta(int unidade, string conta, int historico, double valor, string numeroDocumento)//(int cdCli, long qtdAmortizacoes, decimal txJuros, long carencia, decimal valor)
        {
            bool retorno = false;
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

            ConexaoBD conBD = new ConexaoBD();
            string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = disponOwner+".SP_INSERE_MOVIMENTO_CC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("unidade", OracleDbType.Int64, ParameterDirection.Input).Value = unidade;
            cmd.Parameters.Add("conta", OracleDbType.Varchar2, ParameterDirection.Input).Value = conta;
            cmd.Parameters.Add("historico", OracleDbType.Int64, ParameterDirection.Input).Value = historico;
            cmd.Parameters.Add("valor", OracleDbType.Decimal, ParameterDirection.Input).Value = valor;
            cmd.Parameters.Add("numeroDocumento", OracleDbType.Varchar2, ParameterDirection.Input).Value = numeroDocumento;            

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (OracleException e)
            {
                throw new System.Exception(e.ToString()); 
                
            }
            finally
            {
                conn.Close();
            }
            return retorno;

        }
    }
}
