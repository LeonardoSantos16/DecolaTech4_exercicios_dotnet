/*
---------------------Desafio: Cálculo de Pegada de Carbono-------------
Vamos desenvolver uma ferramenta para calcular a pegada de carbono de uma pessoa, dessa forma, crie variáveis como nome, quilometrosPorDia, horasDeEletronicos, 
refeicoesComCarne para armazenar as respectivas entradas do usuário. Para o cálculo da pegada, 
crie uma função CalcularPegadaDeCarbono que opera através da utilização de fatores de emissão específicos para cada atividade que contribui para a pegada de carbono, sendo eles:

quilometrosPorDia: fator de 0.2, é a média estimada das emissões de carbono associadas a veículos motorizados ao longo de um ano.

horasDeEletronicos, fator de 0.1, é a pegada de carbono relacionada ao consumo elétrico desses dispositivos.

refeicoesComCarne, fator de 0.5, é utilizado para representar as emissões associadas à produção de carne.

A pegada de carbono do usuário é calculada a partir de três fatores: 
transporte (quilômetros diários × 365 × 0.2), eletrônicos (horas diárias × 0.1) e consumo de carne (refeições com carne por dia × 0.5). 
A soma desses valores fornece a pegada de carbono total, abrangendo diversas fontes de emissões.

---------------------Entrada---------------
Como entrada será recebido o nome(string), quilometrosPorDia(double), horasDeEletronicos(int) e refeicoesComCarne(int).

---------------------Saída----------------
Exiba a pegada de carbono calculada com base nas informações fornecidas pelo usuário.
*/
public class PegadaCarbono{
    public static void carbonoMain(){
        string nome;
        double quilometrosPorDia;
        int horasDeEletronicos;
        int refeicoesComCarne;

        nome = Console.ReadLine();
        quilometrosPorDia = double.Parse(Console.ReadLine());
        horasDeEletronicos = int.Parse(Console.ReadLine());
        refeicoesComCarne = int.Parse(Console.ReadLine());
        double pegadaCarbono = pegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaCarbono} toneladas de CO2 por ano.");
        static double pegadaDeCarbono(double quilometros, int horas, int refeicoes){
            return quilometros * 365 * 0.2 + horas * 0.1 + refeicoes * 0.5;
        }
    }
}