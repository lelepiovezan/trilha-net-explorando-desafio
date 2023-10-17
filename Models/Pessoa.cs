using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
        public string Nome { get; set; }

        public string SobreNome { get; set; }
        
    }
}