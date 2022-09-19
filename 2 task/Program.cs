Console.Write("Введите кол-во строк: ");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int input_2 = Convert.ToInt32(Console.ReadLine());

int [,] massive = new int [input_1, input_2];

void print_massive(int [,] massive)
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

void fill_massive(int [,] massive)
{
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
       massive[i,j] = new Random().Next(1, 10);
    }
    
}
}


print_massive (massive);
Console.WriteLine();
fill_massive(massive);
print_massive(massive);


Console.WriteLine("Инициализирую код поиска елемента массива");
Console.Write("Введите № в строке для поиска: ");
int inp_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № в столбце для поиска: ");
int inp_2 = Convert.ToInt32(Console.ReadLine());
inp_1--;
inp_2--;
if ((inp_1 < massive.GetLength(0)) 
    && (inp_1 != 0-1) 
    && (inp_2 < massive.GetLength(1)) 
    && (inp_2 != 0-1))
    {
    Console.Write("Число: " + massive[inp_1,inp_2]);
    }
else
{
    Console.Write("Нет такого числа");
}