/*
-------------------------Desafio: Catálogo de Jogos-------------------
Neste desafio, o objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos. Inicie solicitando a quantidade desejada e, em seguida, peça o nome de cada jogo individualmente, armazenando-os em um array chamado nomesJogos. Utilize um loop `for` para facilitar a adição dos jogos. Após a conclusão, exiba um resumo em uma única linha, indicando a quantidade total de jogos adicionados e a lista de nomes no catálogo.

-------------------------Entrada---------------------
O programa inicia solicitando ao usuário que insira a quantidade de jogos que deseja adicionar ao catálogo. Em seguida, para cada jogo, o usuário é solicitado a inserir o nome do jogo.

-------------------------Saída-----------------------
Ao final da adição dos jogos, o programa exibe um resumo que inclui a quantidade total de jogos adicionados e uma lista com os nomes dos jogos separados por vírgulas. Este resumo fornece uma visão geral dos jogos que foram incluídos no catálogo.
*/
public class ArrayListas{
    public static void arrayListasMain(){
        int quantidadeJogos;
        quantidadeJogos = int.Parse(Console.ReadLine());

        string[] nomesJogos = new string[quantidadeJogos];

       for(int x = 0; x < quantidadeJogos; x++){
            AdicionarJogo(x, nomesJogos);
       }

        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
            static void AdicionarJogo(int indice, string[] nomes)
            {
                nomes[indice] = Console.ReadLine();
            }

            static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
            {
                string texto = "";
                for(int i = 0; i < quantidadeJogos; i++){
                    if(i < quantidadeJogos - 1){
                        texto += nomes[i] + ", ";
                    }else{
                        texto += nomes[i];
                    }
                }
                Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {texto} ao catalogo.");
            }
            
    }
}