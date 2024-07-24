using Gerador_de_Remessa_Cliente.Framework;
using Gerador_de_Remessa_Cliente.Model;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace Gerador_de_Remessa_Cliente.Repository
{
    internal class BuscaDadosBd
    {
        public List<TipoTitulo> buscarTitpoTitulo()
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
            string credimasterOwner = parametrosBD[5];
            string userId = login[0];
            string password = login[1];

            
            List<TipoTitulo> titulos = new List<TipoTitulo>();

            var query = " SELECT SG_TP_TIT, DS_TIT                                          " +
                "           FROM "+ credimasterOwner + ".T402TPTI                           " +
                "          WHERE ID_TP_CHQ = 'N'                                            " +
                "            AND ID_LIQ_TIT = 'C'                                           " ;
                        

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
                        TipoTitulo tipoTitulo = new TipoTitulo();
                        tipoTitulo.siglaTitpoTitulo = dr.GetString(0);
                        tipoTitulo.descricaoTitulo = dr.GetString(1);
                        titulos.Add(tipoTitulo);
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return titulos;
        }
        public Encargo buscaEncargos(string siglaEncargo)
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
            string credimasterOwner = parametrosBD[5];
            string userId = login[0];
            string password = login[1];

            Encargo encargo = new Encargo();


            var query = " SELECT CASE                                                                      " +
                        "          WHEN ID_DD_A30 = 'C' then 'CORRIDOS'                                    " +
                        "          WHEN ID_DD_A30 = 'U' then 'UTEIS'                                       " +
                        "        END identificadorDiasAte30Dias,                                           " +
                        "        TX_PRM_A30 taxaPermanenciaAte30Dias,                                      " +
                        "        CASE                                                                      " +
                        "          WHEN ID_FMA_A30 = 'C' then 'CAPITALIZADO'                               " +
                        "          WHEN ID_FMA_A30 = 'L' then 'LINEAR'                                     " +
                        "          WHEN ID_FMA_A30 = 'O' then 'OVER'                                       " +
                        "       END identificadorFormaAte30Dias,                                           " +
                        "       CASE                                                                       " +
                        "         WHEN ID_DD_M30 = 'C' then 'CORRIDOS'                                     " +
                        "         WHEN ID_DD_M30 = 'U' then 'UTEIS'                                        " +
                        "       END identificadorDiasMais30Dias,                                           " +
                        "       TX_PRM_M30 taxaPermanenciaMais30Dias,                                      " +                        
                        "       CASE                                                                       " +
                        "         WHEN ID_FMA_M30 = 'C' then 'CAPITALIZADO'                                " +
                        "         WHEN ID_FMA_M30 = 'L' then 'LINEAR'                                      " +
                        "         WHEN ID_FMA_M30 = 'O' then 'OVER'                                        " +
                        "       END identificadorformaMais30Dias,                                          " +
                        "       COALESCE(PC_MLT,0) percentualMulta,                                        " +
                        "       qt_dd_mlt quantidadeDiasMulta,                                             " +
                        "       CASE                                                                       " +
                        "         WHEN ID_CLC_MLT = 'D' then 'DEVEDOR'                                     " +
                        "         WHEN ID_CLC_MLT = 'M' then 'DEVEDOR_MAIS_MORA'                           " +
                        "         WHEN ID_CLC_MLT = 'A' then 'DEVEDOR_MENOS_ABATIMENTO'                    " +
                        "       END baseCalculoMulta                                                       " +
                        "      entx.TX_SPR_OPE valorTaxaSpread,                                            " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_BAS_SPR = 'D' then 'DEVEDOR'                                 " +
                        "        WHEN entx.ID_BAS_SPR = 'O' then 'DEVEDOR_OPERACAO'                        " +
                        "        WHEN entx.ID_BAS_SPR = 'C' then 'DEVEDOR_CORRECAO'                        " +
                        "        WHEN entx.ID_BAS_SPR = 'S' then 'DEVEDOR_TAXAS'                           " +
                        "      END identificadorBaseSpread,                                                " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_FMA_SPR = 'L' then 'LINEAR'                                  " +
                        "        WHEN entx.ID_FMA_SPR = 'C' then 'CONFIGURACAO'                            " +
                        "      END identificadorFormatoSpread,                                             " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_CRT_OPE = 'N' then 'NAO_UTILIZA'                             " +
                        "        WHEN entx.ID_CRT_OPE = 'S' then 'SEGUNDO_CRITERIO'                        " +
                        "        WHEN entx.ID_CRT_OPE = 'U' then 'CRITERIO_UNICO'                          " +
                        "      END identificadorCriterioOperacao,                                          " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_CLC_MLT = 'D' then 'DEVEDOR'                                 " +
                        "        WHEN entx.ID_CLC_MLT = 'M' then 'DEVEDOR_MAIS_MORA'                       " +
                        "        WHEN entx.ID_CLC_MLT = 'A' then 'DEVEDOR_MENOS_ABATIMENTO'                " +
                        "      END baseCalculoMulta,                                                       " +
                        "      entx.TX_LIM_MOR taxaLimiteMora,                                             " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_TIP_LIM = 'V' then 'VALOR'                                   " +
                        "        WHEN entx.ID_TIP_LIM = 'P' then 'PERCENTUAL'                              " +
                        "        WHEN entx.ID_TIP_LIM = 'O' then 'OPER_SPREAD'                             " +
                        "        WHEN entx.ID_TIP_LIM = 'S' then 'SEM_LIMITE'                              " +
                        "      END identificadorTipoLimite                                                 " +
                        "  FROM " + credimasterOwner + ".t402entx                                          " +
                        "  LEFT JOIN" + credimasterOwner + ".t402moda moda on moda.sg_ecg = entx.sg_ecg    " +
                        " WHERE entx.SG_ECG = '" + siglaEncargo + "' "                                            ;

            if (dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();

                //System.Windows.Forms.MessageBox.Show(query); // AQUI!!!!!!!!!!!!!

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
                        encargo.identificadorDiasAte30Dias = dr.GetString(0);
                        encargo.taxaPermanenciaAte30Dias = dr.GetFloat(1);
                        encargo.identificadorFormaAte30Dias = dr.GetString(2);
                        encargo.identificadorDiasMais30Dias = dr.GetString(3);
                        encargo.taxaPermanenciaMais30Dias = dr.GetFloat(4);
                        encargo.identificadorformaMais30Dias = dr.GetString(5);
                        encargo.percentualMulta = dr.GetFloat(6);
                        encargo.quantidadeDiasMulta = dr.GetInt32(7);
                        encargo.baseCalculoMulta = dr.GetString(8);
                        encargo.valorTaxaSpread = dr.GetFloat(9);
                        encargo.identificadorBaseSpread = dr.GetString(10);
                        encargo.identificadorFormatoSpread = dr.GetString(11);
                        encargo.identificadorCriterioOperacao = dr.GetString(12);
                        encargo.baseCalculoMulta = dr.GetString(13);
                        encargo.taxaLimiteMora = dr.GetFloat(14);
                        encargo.identificadorTipoLimite = dr.GetString(15);
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return encargo;
        }

        public Encargo buscaEncargosPorModalidade(string siglaModalidade)
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
            string credimasterOwner = parametrosBD[5];
            string userId = login[0];
            string password = login[1];

            Encargo encargo = new Encargo();


            var query = " SELECT CASE                                                                      " +
                        "          WHEN ID_DD_A30 = 'C' then 'CORRIDOS'                                    " +
                        "          WHEN ID_DD_A30 = 'U' then 'UTEIS'                                       " +
                        "        END identificadorDiasAte30Dias,                                           " +
                        "        TX_PRM_A30 taxaPermanenciaAte30Dias,                                      " +
                        "        CASE                                                                      " +
                        "          WHEN ID_FMA_A30 = 'C' then 'CAPITALIZADO'                               " +
                        "          WHEN ID_FMA_A30 = 'L' then 'LINEAR'                                     " +
                        "          WHEN ID_FMA_A30 = 'O' then 'OVER'                                       " +
                        "       END identificadorFormaAte30Dias,                                           " +
                        "       CASE                                                                       " +
                        "         WHEN ID_DD_M30 = 'C' then 'CORRIDOS'                                     " +
                        "         WHEN ID_DD_M30 = 'U' then 'UTEIS'                                        " +
                        "       END identificadorDiasMais30Dias,                                           " +
                        "       TX_PRM_M30 taxaPermanenciaMais30Dias,                                      " +
                        "       CASE                                                                       " +
                        "         WHEN ID_FMA_M30 = 'C' then 'CAPITALIZADO'                                " +
                        "         WHEN ID_FMA_M30 = 'L' then 'LINEAR'                                      " +
                        "         WHEN ID_FMA_M30 = 'O' then 'OVER'                                        " +
                        "       END identificadorformaMais30Dias,                                          " +
                        "       COALESCE(PC_MLT,0) percentualMulta,                                        " +
                        "       qt_dd_mlt quantidadeDiasMulta,                                             " +
                        "       CASE                                                                       " +
                        "         WHEN ID_CLC_MLT = 'D' then 'DEVEDOR'                                     " +
                        "         WHEN ID_CLC_MLT = 'M' then 'DEVEDOR_MAIS_MORA'                           " +
                        "         WHEN ID_CLC_MLT = 'A' then 'DEVEDOR_MENOS_ABATIMENTO'                    " +
                        "       END baseCalculoMulta,                                                      " +
                        "      entx.TX_SPR_OPE valorTaxaSpread,                                            " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_BAS_SPR = 'D' then 'DEVEDOR'                                 " +
                        "        WHEN entx.ID_BAS_SPR = 'O' then 'DEVEDOR_OPERACAO'                        " +
                        "        WHEN entx.ID_BAS_SPR = 'C' then 'DEVEDOR_CORRECAO'                        " +
                        "        WHEN entx.ID_BAS_SPR = 'S' then 'DEVEDOR_TAXAS'                           " +
                        "      END identificadorBaseSpread,                                                " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_FMA_SPR = 'L' then 'LINEAR'                                  " +
                        "        WHEN entx.ID_FMA_SPR = 'C' then 'CONFIGURACAO'                            " +
                        "      END identificadorFormatoSpread,                                             " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_CRT_OPE = 'N' then 'NAO_UTILIZA'                             " +
                        "        WHEN entx.ID_CRT_OPE = 'S' then 'SEGUNDO_CRITERIO'                        " +
                        "        WHEN entx.ID_CRT_OPE = 'U' then 'CRITERIO_UNICO'                          " +
                        "      END identificadorCriterioOperacao,                                          " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_CLC_MLT = 'D' then 'DEVEDOR'                                 " +
                        "        WHEN entx.ID_CLC_MLT = 'M' then 'DEVEDOR_MAIS_MORA'                       " +
                        "        WHEN entx.ID_CLC_MLT = 'A' then 'DEVEDOR_MENOS_ABATIMENTO'                " +
                        "      END baseCalculoMulta,                                                       " +
                        "      entx.TX_LIM_MOR taxaLimiteMora,                                             " +
                        "      CASE                                                                        " +
                        "        WHEN entx.ID_TIP_LIM = 'V' then 'VALOR'                                   " +
                        "        WHEN entx.ID_TIP_LIM = 'P' then 'PERCENTUAL'                              " +
                        "        WHEN entx.ID_TIP_LIM = 'O' then 'OPER_SPREAD'                             " +
                        "        WHEN entx.ID_TIP_LIM = 'S' then 'SEM_LIMITE'                              " +
                        "      END identificadorTipoLimite                                                 " +
                        "  FROM " + credimasterOwner + ".t402entx entx                                     " +
                        "  LEFT JOIN " + credimasterOwner + ".t402moda moda on moda.sg_ecg = entx.sg_ecg   " +
                        " WHERE moda.sg_mod = '" + siglaModalidade + "' ";

            if (dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();

                //System.Windows.Forms.MessageBox.Show(query); // AQUI!!!!!!!!!!!!!

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
                        encargo.identificadorDiasAte30Dias = dr.GetString(0);
                        encargo.taxaPermanenciaAte30Dias = dr.GetFloat(1);
                        encargo.identificadorFormaAte30Dias = dr.GetString(2);
                        encargo.identificadorDiasMais30Dias = dr.GetString(3);
                        encargo.taxaPermanenciaMais30Dias = dr.GetFloat(4);
                        encargo.identificadorformaMais30Dias = dr.GetString(5);
                        encargo.percentualMulta = dr.GetFloat(6);
                        encargo.quantidadeDiasMulta = dr.GetInt32(7);
                        encargo.baseCalculoMulta = dr.GetString(8);
                        encargo.valorTaxaSpread = dr.GetFloat(9);
                        encargo.identificadorBaseSpread = dr.GetString(10);
                        encargo.identificadorFormatoSpread = dr.GetString(11);
                        encargo.identificadorCriterioOperacao = dr.GetString(12);
                        encargo.baseCalculoMulta = dr.GetString(13);
                        encargo.taxaLimiteMora = dr.GetFloat(14);
                        encargo.identificadorTipoLimite = dr.GetString(15);

                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return encargo;
        }

        public List<Modalidade> buscaModalidadeCobranca()
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
            string credimasterOwner = parametrosBD[5];
            string userId = login[0];
            string password = login[1];
                       
            List<Modalidade> listaModalidades = new List<Modalidade>();

            var query = " select SG_MOD,                          " +
                "                DS_MOD,                          " +
                "                COALESCE(SG_ECG, 'SEM_ENCARGO')  " +
                "           from " + credimasterOwner + ".t402moda " +
                "          where SG_mdl = 'CD'                    " +
                "            and sg_lin_ope in ('COB', 'CAU')     ";
                //"            and ID_TP_PES = 'J'                  " ;

            //System.Windows.Forms.MessageBox.Show(query); 

            if (dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();

                

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
                        Modalidade modalidade = new Modalidade();
                        modalidade.siglaModalidade = dr.GetString(0);
                        modalidade.descricaoModalidade = dr.GetString(1);
                        modalidade.siglaEncargo = dr.GetString(2);
                        
                        listaModalidades.Add(modalidade);
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return listaModalidades;
        }


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
            List<ExtratoConta> extratoContas = new List<ExtratoConta>();


            var query = " SELECT cadc.CD_CC,                                                                      " +
                        "        cadc.NM_ABV_TLC,                                                                 " +
                        "        cadc.CD_CLI,                                                                     " +
                        "        coalesce((select vl_sdo                                                          " +
                        "                    from " + disponOwner + ".t401mvto                                    " +
                        "                   where cd_cc =" + numeroConta + "                                      " +
                        "                     and nr_seq =                                                        " +
                        "                         (select max(nr_seq)                                             " +
                        "                            from " + disponOwner + ".t401mvto                            " +
                        "                           where cd_cc = "+ numeroConta +")                              " +
                        "                             and dt_lan = (select dt_pro_atu                             " +
                        "                                             from "+ disponOwner +".t401agen             " +
                        "                                            where cd_und = "+ unidade + ")),sd_dsp_d1),  " +
                        "        sd_blq_24d1 + sd_blq_48d1 + sd_blq_ncd1 as saldoBloqueado,                       " + 
                        "        sd_blq_24d1 + sd_blq_48d1 + sd_blq_ncd1 as saldoBloqueado,                       " +
                        "        sd_blq_jdd1 + sd_blq_add1 as saldoBloqu                                          " +
                        "  from " + disponOwner + ".t401sdct sdct                                                 " +
                        " inner join " + disponOwner + ".t401cadc cadc                                            " +
                        "    on cadc.cd_cc = sdct.cd_cta                                                          " +
                        "   and sdct.cd_und = cadc.cd_und                                                         " +
                        " where  sdct.cd_und = " + unidade + "                                                    " +
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

        public List<ExtratoConta> buscaExtrato(string numeroConta, int unidade)
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

            List<ExtratoConta> extratoContas = new List<ExtratoConta>();
            


            var query = " SELECT mvto.dt_lan,                                                                                    " +
                        "        mvto.vl_lanc,                                                                                   " +
                        "        mvto.vl_sdo,                                                                                    " +
                         "        lpad(hist.cd_hst,4,0) || ' - ' ||                                                              " +
                        "        hist.de_hst_ext                                                                                 " +
                        "   from " + disponOwner + ".t401mvto mvto                                                               " +
                        "  INNER JOIN " + disponOwner + ".t401hist hist                                                          " +
                        "     ON hist.cd_hst = mvto.cd_hst                                                                       " +
                        "  WHERE mvto.cd_hst = hist.cd_hst                                                                       " +
                        "    AND mvto.cd_und = " + unidade + "                                                                   " +
                        "    AND mvto.cd_cc = " + numeroConta + "                                                                " +
                        "    AND mvto.dt_lan >=                                                                                  " +
                        "         ((select dt_pro_atu from " + disponOwner + ".t401agen where cd_und = " + unidade + " )- 7)     " +
                      //"        AND  (select dt_pro_atu from" + disponOwner + ".t401agen where cd_und = "+ unidade + " )        " +
                        "  ORDER BY mvto.nr_seq desc                                                                             " ; 
                        
                        

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
                        ExtratoConta extratoConta = new ExtratoConta();
                        extratoConta.dataLancamento = dr.GetDateTime(0);
                        extratoConta.valorLancado = dr.GetDouble(1);
                        extratoConta.valorSaldo = dr.GetDouble(2);
                        extratoConta.descricaoHistorico = dr.GetString(3);
                        
                        extratoContas.Add(extratoConta);
                        //extratoConta = null;
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return extratoContas;
        }

        public List<Historico> buscaHistoricos()
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

            Historico historico = new Historico();
            List<Historico> historicos = new List<Historico>();


            var query = "SELECT cd_hst, " +
                        "       de_hst, " +
                        "       case" +
                        "         when id_nat = 'C' then 'CRÉDITO'                " +
                        "         when id_nat = 'D' then 'DÉBITO'                 " +
                        "       end case                                          " +
                        " from " + disponOwner + ".t401hist order by cd_hst desc  ";                
                        

            if (dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();

                //System.Windows.Forms.MessageBox.Show("Vou executar a query"); // AQUI!!!!!!!!!!!!!

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
                        historico = new Historico();
                        historico.codigoHistorico = dr.GetInt32(0);
                        historico.descricaoHistorico = dr.GetString(1);
                        historico.natureza = dr.GetString(2);

                        historicos.Add(historico);                        
                    }
                }
                catch (OracleException e)
                {
                    MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }
            return historicos;
        }
    }
}
