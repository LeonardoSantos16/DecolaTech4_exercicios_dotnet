/*
----------------Desafio:  A batalha dos RPGistas: herança e subclasse!--------------
Em jogos de RPG, os personagens frequentemente possuem subclasses que representam especializações em determinadas áreas de combate, como por exemplo, "mago", "guerreiro", "ladino", etc. 
Neste desafio, você deve criar duas classes, "Personagem" e "Subclasse", que ilustrem o conceito de herança em POO.

Crie a classe "Personagem" que possua o atributo "nome" e "mana".

Crie a classe "Subclasse" que herda de "Personagem" e acrescenta o atributo "dano_base" e o método "calcular_dano", 
que recebe como argumento a quantidade de mana que será usada no ataque e retorna o dano causado pelo ataque, 
que é calculado como o valor de "dano_base" multiplicado pela quantidade de mana usada.

----------------Entrada----------------
A entrada será dada pela chamada da classe "Subclasse" e seus métodos, para obter os valores dos atributos de cada personagem e a quantidade de mana usada no ataque.
Os valores a serem recebidos serão:

nome: nome do personagem
mana: quantidade de mana do personagem
dano base: referente ao dano base da subclasse
Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

----------------Saída----------------
A saída deverá ser a impressão da mensagem "Nome do personagem atacou e causou X de dano!", 
onde "Nome do personagem" é o nome do personagem fornecido na entrada e "X" é o valor de dano calculado pela subclasse a partir da quantidade de mana usada no ataque.

*/
public class PersonagemHeranca{
    public string Nome {get; set;}
    public int Mana {get; set;}
    public PersonagemHeranca(string nome, int mana){
        Nome = nome;
        Mana = mana;
    }
}
public class SubClasse : PersonagemHeranca{
    public int danoBase;

    public SubClasse(string nome, int mana, int danoBase) : base(nome, mana){
        this.danoBase = danoBase;
    }

    public string calcularDano(){
        return $"{Nome} atacou e causou {Mana * danoBase} de dano!";
    }

    public static void personagemMain(){
        string nome;
        int mana;
        int danoBase;

        nome = Console.ReadLine();
        mana = int.Parse(Console.ReadLine());
        danoBase = int.Parse(Console.ReadLine());


        SubClasse personagem = new SubClasse(nome, mana, danoBase);
        Console.WriteLine(personagem.calcularDano());
    }
}