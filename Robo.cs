/*
----------------------Desafio: Controle de Velocidade do Robô-----------------
Você foi contratado para criar um software que simule o controle de velocidade de um robô. Esse robô possui uma velocidade máxima e uma velocidade mínima. 
Sua tarefa é desenvolver um programa  utilizando o conceito de Orientação a Objetos para calcular a velocidade final do robô após uma sequência de comandos.
Crie uma classe chamada "Robo" que possua as seguintes propriedades e métodos:

velocidadeAtual: inteiro que representa a velocidade atual do robô (inicialmente 0);
velocidadeMaxima: inteiro que representa a velocidade máxima do robô;
velocidadeMinima: inteiro que representa a velocidade mínima do robô;
acelerar(): um método que aumenta a velocidade atual em 1 unidade, desde que não ultrapasse a velocidade máxima;
desacelerar(): um método que diminui a velocidade atual em 1 unidade, desde que não fique abaixo da velocidade mínima.

----------------------Entrada----------------------
A entrada consiste em duas linhas: A primeira linha contém dois inteiros Vmin e Vmax (1 ≤ Vmin < Vmax ≤ 100), representando a velocidade mínima e máxima do robô, respectivamente.
A segunda linha contém uma sequência de comandos (com no máximo 100 caracteres), onde: 'A' representa uma aceleração e 'D' representa uma desaceleração. 
Desta maneira, a entrada seria da seguinte maneira:

Vmin Vmax: ambos valores int.
comandos: string.

----------------------Saída----------------------
A saída deve apresentar apenas a velocidade final (int)  do robô, considerando as regras descritas nos métodos de acelerar e desacelerar.
*/
public class Robo
{
    public int velocidadeAtual { get; set; } = 0;
    public int velocidadeMinima { get; }
    public int velocidadeMaxima { get; }

    public Robo(int velocidadeMinima, int velocidadeMaxima)
    {
        this.velocidadeMinima = velocidadeMinima;
        this.velocidadeMaxima = velocidadeMaxima;
        this.velocidadeAtual = velocidadeMinima;
    }

    public void Acelerar()
    {
        if (velocidadeAtual < velocidadeMaxima)
        {
            this.velocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (velocidadeAtual > velocidadeMinima)
        {
            this.velocidadeAtual--;
        }
    }

    public void Testes(string texto)
    {
        foreach (var palavra in texto)
        {     
            if (palavra == 'A')
            {
                Acelerar();
            }
            else
            {
                Desacelerar();
            }
            
        }
    }

    public static void programaMain(){
        int velocidademax;
        int velocidademin;

        string velocidade = Console.ReadLine();
        string texto = Console.ReadLine();
        string[] velocidades = velocidade.Split(" ");
        velocidademin = int.Parse(velocidades[0]);
        velocidademax = int.Parse(velocidades[1]);
        Robo robos = new Robo(velocidademin, velocidademax);
        robos.Testes(texto);
        Console.WriteLine(robos.velocidadeAtual);
    }
}



   