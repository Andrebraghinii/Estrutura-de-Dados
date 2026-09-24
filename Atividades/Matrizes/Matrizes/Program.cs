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


Matriz BiDimensional
using System;

// Enumeração com os tipos de terreno
public enum TerrainEnum
{
    Grass,
    Sand,
    Water,
    Wall
}

// Métodos de extensão para o TerrainEnum
public static class TerrainEnumExtensions
{
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.Grass: return ConsoleColor.Green;
            case TerrainEnum.Sand: return ConsoleColor.Yellow;
            case TerrainEnum.Water: return ConsoleColor.Blue;
            case TerrainEnum.Wall: return ConsoleColor.DarkGray;
            default: return ConsoleColor.Gray;
        }
    }

    public static char GetChar(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.Grass: return '\u201C'; // Exemplo de carácter
            case TerrainEnum.Sand: return '\u25CB';
            case TerrainEnum.Water: return '\u2248';
            case TerrainEnum.Wall: return '\u25CF';
            default: return ' ';
        }
    }
}

public class GameMap
{
    public static void DrawMap()
    {
        // Declaração da matriz bidimensional (11 linhas, 10 colunas)
        TerrainEnum[,] map = new TerrainEnum[11, 10];
        
        // (O preenchimento do mapa com valores seria feito aqui)

        // Iteração sobre as linhas e colunas
        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                Console.ForegroundColor = map[row, col].GetColor();
                Console.Write(map[row, col].GetChar() + " ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
}

Selection Sort

using System;

public static class SelectionSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        // Percorre a matriz dividindo-a em parte ordenada e não ordenada
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            
            // Encontra o menor valor na parte não ordenada
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            
            // Troca o menor valor encontrado com o primeiro elemento da parte não ordenada
            Swap(array, i, minIndex);
        }
    }

    // Método auxiliar para efetuar a troca de elementos
    private static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}

Stack<char> chars = new Stack<char>();
foreach (char c in "LET'S REVERSE!")
{
 chars.Push(c);
}

[ 86 ]
while (chars.Count > 0)
{
 Console.Write(chars.Pop());
}
Console.WriteLine();
