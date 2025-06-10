Console.Write("Enter number of lines and columns for the matrix: ");
string[] dimensions = Console.ReadLine().Split(' ');
int nLines = int.Parse(dimensions[0]);
int nColumns = int.Parse(dimensions[1]);

int[,] matrix = new int[nLines, nColumns];
for (int i = 0; i < nLines; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    for (int j = 0; j < nColumns; j++)
    {
        matrix[i, j] = int.Parse(input[j]);
    }
}

Console.WriteLine("Enter the number to search for: ");
int searchNumber = int.Parse(Console.ReadLine());
string positionNumber;

for (int i = 0; i < nLines; i++)
{

    for (int j = 0; j < nColumns; j++)
    {
        if (matrix[i, j] == searchNumber)
        {
            positionNumber = $"Position: {i},{j}";
            Console.WriteLine(positionNumber);
            if (i > 0)
            {
                Console.WriteLine($"Up: {matrix[i - 1, j]}");
            }
            else
            {
                Console.WriteLine("Up: ");
            }
            if (i < nLines - 1)
            {
                Console.WriteLine($"Down: {matrix[i + 1, j]}");
            }
            else
            {
                Console.WriteLine("Down: ");
            }
                
            if (j > 0)
            {
                Console.WriteLine($"Left: {matrix[i, j - 1]}");
            }
            else
            {
                Console.WriteLine("Left: ");
            }
            if (j < nColumns - 1)
            {
                Console.WriteLine($"Right: {matrix[i, j + 1]}");
            }
            else
            {
                Console.WriteLine("Right: ");
            }
        }
    }
}