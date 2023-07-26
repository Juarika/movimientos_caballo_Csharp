using System;
class Program
{
    private static char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
    static void Main(string[] args)
    {   
        Console.WriteLine("Hola Usuario, Ingresa la Posicion Inicial: ej: [a1]");
        string ? input = Console.ReadLine();
        
        if (input.Length == 2)
        {
            char letra = input[0];
            char numero = input[1];
            int letNum = Array.IndexOf(letters, letra) + 1;
            int num = numero - '0';
            bool present = letters.Contains(letra);
            if (char.IsLetter(letra) && char.IsDigit(numero) && present && num != 0)
            {
                for (int i = 1; i <= 8; i++) 
                {
                    for (int j = 1; j <= 8; j++) 
                    {
                        if (num == i && letNum == j) 
                        {
                            Console.Write("♞ ");
                        }
                        else if (
                            num - 2 == i && letNum - 1 == j || 
                            num - 2 == i && letNum + 1 == j || 
                            num + 2 == i && letNum - 1 == j || 
                            num + 2 == i && letNum + 1 == j || 
                            num - 1 == i && letNum - 2 == j || 
                            num - 1 == i && letNum + 2 == j || 
                            num + 1 == i && letNum - 2 == j || 
                            num + 1 == i && letNum + 2 == j)
                        {
                            Console.Write("⬛");
                        }
                        else
                        {
                            Console.Write("⬜");
                        }
                    }
                    Console.WriteLine(i);
                }
                foreach (var item in letters) 
                {
                    Console.Write(item);
                    Console.Write(' ');
                }            
                Console.WriteLine(' ');
            }
            else
            {
                Console.WriteLine("El formato ingresado no es válido. Debe ser [a1].");
            }
        }
        else
        {
            Console.WriteLine("El formato ingresado no es válido. Debe ser [a1].");
        }
    }
}