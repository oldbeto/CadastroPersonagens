using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipuladorArquivo
{
    public class Arquivo
    {

        public static void CriaArquivo(string caminho, string nomeArquivo, string extensao, string dados) {
            var arquivo = File.CreateText(caminho + nomeArquivo + extensao);
            arquivo.WriteLine(dados);
            arquivo.Close();         

        }

        public static Boolean DeletaArquivo(string caminho) {
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                return true;
            }
            else {
                return false;
            }
        }

        public static string LerArquivo(string caminho) {
            return File.ReadAllText(caminho);
        }


        public static string[] CarregarArquivos(string caminho)
        {
           return Directory.GetFiles(caminho);
        }
    }
}
