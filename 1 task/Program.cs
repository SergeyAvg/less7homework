Console.Write("Введите кол-во строк: ");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int input_2 = Convert.ToInt32(Console.ReadLine());


double [,] massive = new double [input_1, input_2];
Random rnd = new Random();

void massiv_print(double [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        Console.Write($"{massive[i,j]} ");
    }
    Console.WriteLine();
}
}

void fill_mass(double [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
       massive[i,j] = Convert.ToDouble(rnd.Next(-9, 10)/10.0);
    }
    
}
}

massiv_print (massive);
Console.WriteLine();
fill_mass(massive);
massiv_print(massive);