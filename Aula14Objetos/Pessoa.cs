using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Pessoa
    {
        // Atributos


        // Nenhuma das variáveis precisa necessáriamente ser publica,
        // pois se nao qualquer pessoa pode acessar e alterar o que está dentro do atributo.

        // Assim que você tira o publico do nome do atributo ele já fica automaticamente privado,
        // ou seja, você não precisa declarar que está privado, porém é recomendado declarar como "private",
        // pra ficar explicito no seu código o que é publico ou não.

        private string nome;
        private int idade;
        public bool inadimplente = false;

        // A classe "Endereco" foi adicionado a classe "Pessoa", ou seja, a classe "Pessoa" contém outra classe
        // dentro de si, se tornando a classe principal.
        public Endereco endereco;





        // Construtor
        public Pessoa (string nome, int idade, string rua, string bairro, string cidade)
        {
            this.nome = nome;
            this.idade = idade;

            // *****************************************************
            this.endereco = new Endereco(rua, bairro, cidade);
            // *****************************************************
        }





        // Metódos
        public void mostra()
        {
            Console.WriteLine($"Eu sou {nome} e tenho {idade} anos.");
            
        }


    }
}
