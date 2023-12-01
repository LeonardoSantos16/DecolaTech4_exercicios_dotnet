/*
--------------------Desafio : Criando seu Personagem-----------------
No mundo dos RPGs, a criação do personagem é um momento importante e emocionante para os jogadores! 
Durante esse processo, o jogador deve escolher o nome, a raça, a classe e outras características importantes para o personagem.

Crie uma classe chamada "Personagem" que tenha os seguintes atributos: nome (string), raça (string), classe (string), nível (inteiro), vida (inteiro) e mana (inteiro).
A classe deve ter um construtor que recebe como parâmetros o nome, a raça e a classe do personagem. O nível e a vida devem ser iniciados com valores padrão (1 e 10 , respectivamente). Além disso, crie um método chamado "exibir_status" que exibe na tela o nome, a raça, a classe, o nível, a vida e a mana do personagem.

--------------------Entrada--------------------
A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

--------------------Saída--------------------
A saída deve conter a frase "Status:" seguida das informações do método "exibir_status", ou seja, deve exibir na tela o nome, a raça, a classe, o nível e a vida do personagem. Conforme exemplos abaixo.

*/

public class Personagem{
    public string Nome {get;set;}
    public string Raca {get; set;}
    public string Classe {get; set;}
    public int Nivel {get; set;}
    public int vida {get; set;}
    public int mana {get; set;}

    public Personagem(string nome, string raca, string classe){
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public override string ToString()
    {
        return $"Status: \nNome:{Nome} \nRaça:{Raca} \nClasse:{Classe} \nNível:1 \nVida:10";
    }

    public static void rpgMain(){
        string nome;
        string raca;
        string classe;

        nome = Console.ReadLine();
        raca = Console.ReadLine();
        classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);
        Console.WriteLine(personagem);
    }

}