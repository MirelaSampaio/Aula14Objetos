using Aula14Objetos;

Pessoa p1 = new Pessoa("Misa", 19, "Rua dos bobos, nº 0", "Engracinho", "São Juju");

// Para relacionar o endereço a classe pessoa, é necessário seguir esse procedimento:

//Endereco e1 = new Endereco("Rua dos bobos, nº 0", "Engracinho", "São Juju"");
//p1.endereco= e1;
// Isso é:
// O objeto completo "e1//Endereco um" foi adicionado dentro do objeto "pessoa um" que está acessando a classe endereco.
// Outra forma de fazer isso é dentro da propria classe "Pessoa" (está marcado com ***).

p1.mostra();
p1.endereco.mostra();
