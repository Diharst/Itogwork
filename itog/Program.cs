int ReadInt(string size)
{
    System.Console.WriteLine(size);
    return Convert.ToInt32(Console.ReadLine());
}

string[] Generate(int a)
{
string[] matrix = new string[a];
Random rand = new Random();

for (int i = 0; i < a; i++)
{
        System.Console.Write("Введите элемент массива: ");
        matrix[i] = Console.ReadLine();
    
}
return matrix;
}

void Print(string[] matrix)
{
System.Console.Write("[" + string.Join(", ", matrix) + "]");
}

string[] Find(string[] matrix)
{
    int count = 0;
    string[] massiv = new string[matrix.Length];
    for(int i = 0; i < matrix.Length; i++)
    {
        if(matrix[i].Length<=3)
        massiv[i] = matrix[count];
        count++;
    }
    return massiv;
}


int size = ReadInt("Введите размер массива: ");
string[] massiv = Generate(size);
Print(massiv);
string[] massiv1 = Find(massiv);
massiv1 = massiv1.Where(i => i != null).ToArray();
System.Console.Write(" -> ");
System.Console.WriteLine("[" + string.Join(", ", massiv1) + "]");
