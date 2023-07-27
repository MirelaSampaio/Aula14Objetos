using Aula14Objetos;

Pessoa p1 = new Pessoa("Misa", 19, "Atilio Pratavieira", "Aracy I", "São Carlos");

// Para relacionar o endereço a classe pessoa, é necessário seguir esse procedimento:

//Endereco e1 = new Endereco("Atilio Pratavieira", "Aracy I", "São Carlos");
//p1.endereco= e1;
// Isso é:
// O objeto completo "e1//Endereco um" foi adicionado dentro do objeto "pessoa um" que está acessando a classe endereco.
// Outra forma de fazer isso é dentro da propria classe "Pessoa" (está marcado com ***).

p1.mostra();
p1.endereco.mostra();
