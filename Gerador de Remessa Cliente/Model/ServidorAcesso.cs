using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente.Model
{
    internal class ServidorAcesso
    {
        public bool atualizaServidor(String novoServidor, String novoToken)
        {
            String path = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";

            bool retorno = false;


            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("SERVIDOR=" + novoServidor.Trim());
                sw.WriteLine("TOKEN=" + novoToken.Trim());
                retorno = true;
            }
            return retorno;
        }

        public List<String> getServidorEToken()
        {
            List<String> login = new List<String>();

            String path = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String servidor;
            String token;

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    String ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 6 && ln.Substring(0, 8).ToUpper() == "SERVIDOR")
                        {
                            servidor = ln.Substring(9, ln.Length - 9);
                            login.Add(servidor.Trim());
                        }
                        if (ln.Length > 8 && ln.Substring(0, 5).ToUpper() == "TOKEN")
                        {
                            token = ln.Substring(6, ln.Length - 6);
                            login.Add(token.Trim());
                        }
                    }
                }
            }
            while (login.Count < 2)
            {
                login.Add(" ");
            }
            return login;
        }

    }
}
