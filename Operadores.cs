/*
------------Desafio: Gerenciamento de Tarefas----------
Agora, focaremos em outro conceito fundamental de programação para desenvolver um algoritmo que possua como objetivo a simulação de um Sistema de Gerenciamento de Tarefas. 
Dessa forma, crie variáveis como, titulo, descricao e dataVencimento para guardar as informações das tarefas, após isso, 
implemente uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres. 
Caso a descrição exceda 50 carateres, trataremos essa condição exibindo uma mensagem adequada. 
Lembrando que as estruturas condicionais são fundamentais para o controle de fluxo dos programas pois realizam verificações precisas com base em condições específicas predefinidas,
neste caso, é o limite de 50 caracteres.

------------Entrada-----------
A entrada será as Strings com o titulo da tarefa, a descrição e a data de vencimento.

------------Saída-------------
Será exibido a tarefa que foi adicionada com o título, descrição e data de vencimento. Mas caso a descrição tenha mais de 50 caracteres deverá ser informado: 
'O Valor da descrica excede a quantidade de caracteres permitido'.

*/

public class Operadores{
    public static void operadoresMain(){
        string titulo;
        string descricao;
        string dataVencimento;

        titulo = Console.ReadLine();
        descricao = Console.ReadLine();
        dataVencimento = Console.ReadLine();

        if(descricao.Length > 50){
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }else{
            Console.WriteLine($"{descricao} ate {dataVencimento}");
        }
    }
}