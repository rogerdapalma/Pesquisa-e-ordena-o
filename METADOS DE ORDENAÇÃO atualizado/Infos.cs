

namespace metodosOrdenacao {
    internal class Infos {
        public string Get_informacoes(int metodo) {
            string infos =  "";


            if (metodo == 0)
            { //
                infos = "Não selecionou nenhuma das opções.";
            }
            else if (metodo == 1) { //se o metodo 1 for escolido, exibe info de bolha
                infos = "O bubble sort, ou ordenação por flutuação (literalmente \"por bolha\"), é um algoritmo de ordenação dos mais simples. " +
                    "A ideia é percorrer o vector diversas vezes, e a cada passagem fazer flutuar para o topo o maior elemento da sequência.";
            } else if (metodo == 2) {//se o metodo 2 for escolido, exibe info de Ordenação
                infos = " ordenação por seleção é procurar o menor elemento do vetor (ou maior) e" +
                    " movimentá-lo para a primeira (última) posição do vetor. Repetir para os n elementos do vetor.";
            } else if (metodo == 3) {//se o metodo 3 for escolido, exibe info de INSERÇÃO
                infos = "INSERÇÃO - Insertion Sort -O Insertion Sort tem como rotina base a inserção ordenada. A ideia é executar várias vezes essa rotina para ordenar um array. Para ser exato, " +
                    "se executarmos N−1 vezes a rotina de inserção ordenada em um array o resultado é a ordenação completa do mesmo;";
            } else if (metodo == 4) { //se o metodo 4 for escolido, exibe info de AGITAÇÃO
                infos = "AGITAÇÃO - Shake Sort ou Cocktail É baseado no Bolha, ou seja, é uma tentantiva de melhorar o Bolha. Estável  Memória Interna " +
                    "A estrutura possui 3 partes/porções (1a é a ordenada pelos menores; 2a é a desordenada; 3a é  na ordenada pelos maiores) " +
                    "De fato é a aplicação do bolha da esquerda para direita e depois da direita para esquerda Há os índices/ponteiros ini e fim que" +
                    "marcam o início e o final da estrutura Observação: I) se a estrutura estiver ordenada ou quase, o agitação terá excelente desempenho," +
                    "como o bolha II) atenção a lista deve ser duplamente encadeada";
            } else if (metodo == 5) { //se o metodo 5 for escolido, exibe info de PENTE
                infos = "PENTE - Comb Sort É baseado no Bolha, ou seja, é uma tentantiva de melhorar o Bolha. a partir deste método, há COMPARAÇÕES" +
                   "a uma distância X. Isso gera uma pré-organização da estrutura,diminuindo número de comparações e trocas.Instável  Memória" +
                    "Interna A estrutura possui 2 porções/partes (1a é a ordenada; 2a é a desordenada) Há as variáveis clássicas do bolha: i, houveTroca," +
                    "tmp. Há a variável distancia que é calculada pelo tamanho da estrutura dividido por 1.3 Adequado somente para vetores ou estruturas" +
                    "prontas tipo lista de uma linguagem de programação = ";
            } else if (metodo == 6) { //se o metodo 6 for escolido, exibe info de SHELLSORT
                infos = "SHELLSORT  É baseado no Inserção, ou seja, é uma tentativa de melhoria via o uso da ANÁLISE A DISTÂNCIA (tipo pente)\r\nInstável" +
                    "\r\nMemória Interna Não é adequado para listas encadeadas";
            } else if (metodo == 7) { //se o metodo 7 for escolido, exibe info de Quick
                infos = "Quick Sort é um algoritmo eficiente de ordenação. O algoritmo baseia a ordenação em sucessivas execuções de particionamento, uma rotina que escolhe" +
                    " um pivot e o posiciona no array de uma maneira em que os elementos menores ou iguais ao pivot estão à sua esquerda e os maiores estão à sua direita.";
            } else if (metodo == 8) {//se o metodo 8 for escolido, exibe info de heapsort 
                infos = "O heapsort utiliza uma estrutura de dados chamada heap binário para ordenar os elementos a medida que os insere na estrutura. Assim, ao final das inserções," +
                    " os elementos podem ser sucessivamente removidos da raiz da heap, na ordem desejada. Um heap binário é uma árvore binária mantida na forma de um vetor.";

            }

            return infos;
        }
    }
}