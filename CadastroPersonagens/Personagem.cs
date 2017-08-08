using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPersonagens
{
    class Personagem
    {
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string Arma { get; set; }

        public int Ataque { get; set; }

        public int Defesa { get; set; }

        public Guid ID { get; set; }

        public string caminhoImagem { get; set; }

        public override string ToString()
        {
            return Nome;
        }

    }

   
}
