/*
------------------Desafio: Soma de Números Pares em Intervalo-------------
Para este desafio, vamos aplicar outros conceitos fundamentais de programação, agora, criaremos um programa que calcule a soma dos números pares em um intervalo específico. 
Dessa forma, desenvolva uma solução clara, simples e organizada, você pode criar variáveis com nomes representativos, como limiteInferior, limiteSuperior e somaPares. 
Utilize uma estrutura de controle de fluxo, como o `for` para percorrer todos os números no intervalo definido pelos `limiteInferior e o limiteSuperior`. 
Dentro desse loop, crie uma estrutura condicional `if ` para verificar se cada número é par e se o resto da divisão por 2 é igual a zero (i % 2 == 0). 
Se a condição for verdadeira, o número é somado à variável somaPares.

-------------------Entrada----------------
Será as informações de limiteInferior e limiteSuperior, sendo eles dois números inteiros(int).

-------------------Saída------------------
A saída deverá informar uma String com o resultado final: $"A soma dos números pares de {limiteInferior} a {limiteSuperior} e: {somaPares}".
*/
public class numerosPares{
    public static void somaParesMain(){
        int limiteInferior;
        int limiteSuperior;
        int somaPares = 0;

        limiteInferior = Convert.ToInt32(Console.ReadLine());
        limiteSuperior = Convert.ToInt32(Console.ReadLine());
        for(int x = limiteInferior; x <= limiteSuperior; x++){
            if(x % 2 == 0){
                somaPares += x;
            }
        }
        Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}