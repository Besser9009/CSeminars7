Console.Clear();
Start();
void Start()
{
    int rows = SetNumber("rows");
    int collumns = SetNumber("collumns");
    int[,] matrix = GetRandomMatrix(rows, collumns);
    PrintMatrix(matrix);
}
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetRandomMatrix(int rows, int collumns)
{
    int[,] matrix = new int[rows, collumns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            matrix[i, j] = rand.Next(10, 100);
            
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine("");
    }
}