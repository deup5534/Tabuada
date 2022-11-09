Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.Write("Tabuada do número:");

int tabu = Convert.ToInt32(Console.ReadLine());
int ada = 0;
int tabuada;

while (ada <= 10)

{
    tabuada = tabu * ada;
    Console.WriteLine($"{tabu} x {ada} = {tabuada}");
    ada +=1;
}

Console.ResetColor();