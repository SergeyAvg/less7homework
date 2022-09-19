Console.Write("Введите кол-во строк: ");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int input_2 = Convert.ToInt32(Console.ReadLine());

int [,] mass = new int [input_1, input_2];

void print_massive(int [,] mass)
{
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write($"{mass[i,j]} ");
    }
    Console.WriteLine();
}
}

void fill_massive(int [,] mass)
{
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
       mass[i,j] = new Random().Next(1, 10);
    }
    
}
}


print_massive (mass);
Console.WriteLine();
fill_massive(mass);
print_massive(mass);
double count = 0;
double inp_1 = input_1;

for (int i =0; i < mass.GetLength(1); i++)
{
    for (int l = 0; l < mass.GetLength(0); l++)
    {
        count += mass[l,i]; 
    }
    Console.Write(count / inp_1 + " ");
    count = 0;
}