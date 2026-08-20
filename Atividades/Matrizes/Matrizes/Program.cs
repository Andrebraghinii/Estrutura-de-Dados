//Vetores multi-dimensionais

//vetor bi-dimensional
int[, ] numbersBi = new int[5, 2];


//vetor tri-dimensional
int[,, ] numbersTri = new int[5, 4, 3];

//podemos combinar  a declaração com a inicialização
//exemplo de um 4x3

int[,] newNumbersBi = new int[, ] {
    {9,5 ,-9},
    {-11, 4, 0},
    {6, 115, 3},
    {-12, -9, 71},
    {1, -6, -1}
};


//percorrendo a matriz. Exemplo de repetição for encadeada
//Nested/chained for

for(int i = 0; i < newNumbersBi.GetLength (0); i++){
    for(int j=0; j < newNumbersBi.GetLength (1); j++){

        Console.WriteLine($"[{newNumbersBi[i,j]}]");
    }
    Console.WriteLine("");
}




//jagged Arrays ou Arrei de jegue
//vetor de Vetores

int[][] jaggedNumbers = new int[4][];
//atribuindo valores
jaggedNumbers[0] = new int[] {9,5 -9};
jaggedNumbers[1] = new int[] {0,-3, 12, 51, -3};
jaggedNumbers[3] = new int[] {51};

//declaração com inicialização

int[][] jaggedNumbers2 = {
    
    new int[] {0, 1, 2},
    new int[] {3, 3, 5, 6},
    null,
    new int[] {7, 8, 9, 10},
};

//para acessar uma posição especifica
int n = jaggedNumbers[1][2];
jaggedNumbers[1][2] = 22;

Console.WriteLine("n = "+ n);
Console.WriteLine("jaggeedNumbers = " + jaggedNumbers[1][2]);



//tarefa pagina 40 a 42
//pagina 47 a 50