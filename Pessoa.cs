/*
--------------------Desafio: Primeiro Desafio com POO--------------------
Você acabou de aprender POO e foi desafiado a criar o seu primeiro projeto. Neste código, você deve criar uma classe chamada Pessoa com dois atributos: nome e idade. Em seguida, deve implementar dois métodos para obter esses atributos: getNome() e getIdade(). Por fim, deve criar um objeto do tipo Pessoa e exibir na tela o nome e a idade usando os métodos criados.

--------------------Requisitos--------------------

Utilizar classes e métodos para implementar o programa;
Implementar a classe Pessoa com os atributos nome e idade, e o método get para cada atributo;
O programa deve solicitar que o usuário insira o nome e a idade da pessoa;
O programa deve exibir o nome e a idade da pessoa inserida pelo usuário.

--------------------Entrada--------------------
A entrada deverá receber as informações do objeto Pessoa, conforme exemplo abaixo:

nome (string)
idade (int)
Saída
O código deverá retornar uma mensagem (string) informando o nome e idade da pessoa, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

João
26

De acordo com esses valores de entrada, a saída ficará desta maneira:
Nome: João, Idade: 26

*/
class Pessoa
{
    string nome;
    int idade;
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
    /*
    public static void Main(string[] args)
    {
        var nome = Console.ReadLine();
        var idade  = Convert.ToInt32(Console.ReadLine());
        Pessoa pessoa = new Pessoa(nome, idade);
        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");

    }
    */
    public static void Testando()
    {
        var nome = Console.ReadLine();
        var idade = Convert.ToInt32(Console.ReadLine());
        Pessoa pessoa = new Pessoa(nome, idade);
        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");

    }

}

    