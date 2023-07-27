using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Endereco
    {
        // Atributos
        public string rua;
        public string bairro;
        public string cidade;

        // Construtor
        public Endereco(string rua, string bairro, string cidade )
        {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        // Métodos

        public void mostra()
        {

            Console.WriteLine($"Eu moro na rua {rua} localizada no bairro {bairro} que fica na cidade de {cidade}."); 

        }

    }

}
