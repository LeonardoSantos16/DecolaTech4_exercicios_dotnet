/*
------------------Desafio: Criando um jogador de futebol------------------
Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição. O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

------------------Entrada------------------
O programa deve ler as informações do jogador nessa ordem: 

nome: string
nacionalidade: string
idade: inteiro
posição: strig

------------------Saída------------------
O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início. 
As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). Veja a estrutura abaixo:

Jogador criado!
[nome]
[nacionalidade]
[idade]
Posição: [posição]
*/
public class Jogador{
    public string? Nome {get; set;}
    public string? Nacionalidade {get; set;}
    public int Idade {get; set;}
    public string? Posicao {get; set;}

    public Jogador(string nome, string nacionalidade, int idade, string posicao){
        this.Nome = nome;
        this.Nacionalidade = nacionalidade;
        this.Idade = idade;
        this.Posicao = posicao;
    }
    /*
    public string Exibir(){
        return $"Jogador criado! \n{Nome} \n{Nacionalidade} \n{Idade} \nPosição: {Posicao}";
    }
    */
    public override string ToString()
    {
        return $"Jogador criado! \n{Nome} \n{Nacionalidade} \n{Idade} \nPosição: {Posicao}";
    }

    public static void jogadorMain(){
        string nome;
        string nacionalidade;
        int idade;
        string posicao;

        nome = Console.ReadLine();
        nacionalidade = Console.ReadLine();
        idade = int.Parse(Console.ReadLine());
        posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);
        //Console.WriteLine(jogador.Exibir());
        Console.WriteLine(jogador);
    }
}