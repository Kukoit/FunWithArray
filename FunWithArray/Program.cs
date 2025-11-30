using System;
using System.Drawing;
using Console = Colorful.Console;

class Program
{
    static void Main(string[] args)
    {
        int rows, cols;
        Console.Write("Enter number of rows: ", Color.DeepSkyBlue);
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ", Color.DeepSkyBlue);
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, cols];

        Console.WriteLine("\nEnter the elements of the array:", Color.Gold);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ", Color.White);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Display menu loop
        while (true)
        {
            Console.WriteLine("\n═══   DISPLAY MODE SELECTION   ═══", Color.HotPink);
            Console.WriteLine("1. Standard View", Color.LightGreen);
            Console.WriteLine("2. Color-Coded (Even/Odd)", Color.Cyan);
            Console.WriteLine("3. With Colorful Indices", Color.Yellow);
            Console.WriteLine("4. Dotted Box Grid", Color.LightCoral);
            Console.WriteLine("0. Exit", Color.Red);
            Console.Write("\nSelect mode: ", Color.Lime);

            string choice = Console.ReadLine();
            Console.WriteLine();

            // MODE 1: STANDARD VIEW
            if (choice == "1")
            {
                Console.WriteLine("═══ STANDARD VIEW ═══", Color.Gold);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{array[i, j],6}\t", Color.White);
                    }
                    Console.WriteLine();
                }
            }

            // MODE 2: COLOR-CODED EVEN/ODD
            else if (choice == "2")
            {
                Console.WriteLine("═══ COLOR-CODED (EVEN/ODD) ═══", Color.Gold);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (array[i, j] % 2 == 0)
                            Console.Write($"{array[i, j],6}\t", Color.DeepSkyBlue);
                        else
                            Console.Write($"{array[i, j],6}\t", Color.OrangeRed);
                    }
                    Console.WriteLine();
                }
                Console.Write("\nBlue", Color.DeepSkyBlue);
                Console.Write(" = Even  ", Color.White);
                Console.Write("Red", Color.OrangeRed);
                Console.WriteLine(" = Odd", Color.White);
            }

            // MODE 3: WITH COLORFUL INDICES
            else if (choice == "3")
            {
                Console.WriteLine("═══ WITH COLORFUL INDICES ═══", Color.Gold);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("[", Color.Gray);
                        Console.Write($"{i}", Color.Cyan);
                        Console.Write(",", Color.Gray);
                        Console.Write($"{j}", Color.Magenta);
                        Console.Write("]:", Color.Gray);
                        Console.Write($"{array[i, j],3}  ", Color.LimeGreen);
                    }
                    Console.WriteLine();
                }
            }



            // MODE 5: DOTTED BOX GRID
            else if (choice == "4")
            {
                Console.WriteLine("═══ DOTTED BOX GRID ═══", Color.Gold);

                int cellWidth = 7;

                // Top border
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("+", Color.DarkCyan);
                    for (int k = 0; k < cellWidth; k++)
                    {
                        Console.Write("-", Color.DarkCyan);
                    }
                }
                Console.WriteLine("+", Color.DarkCyan);

                // Rows with data
                for (int i = 0; i < rows; i++)
                {
                    // Data row
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("|", Color.DarkCyan);

                        // Color by divisibility
                        Color valueColor;
                        if (array[i, j] % 5 == 0)
                            valueColor = Color.Gold;
                        else if (array[i, j] % 3 == 0)
                            valueColor = Color.LimeGreen;
                        else if (array[i, j] % 2 == 0)
                            valueColor = Color.DeepSkyBlue;
                        else
                            valueColor = Color.Coral;

                        // Center the value
                        string valueStr = array[i, j].ToString();
                        int padding = (cellWidth - valueStr.Length) / 2;
                        Console.Write(new string(' ', padding), Color.White);
                        Console.Write(valueStr, valueColor);
                        Console.Write(new string(' ', cellWidth - valueStr.Length - padding), Color.White);
                    }
                    Console.WriteLine("|", Color.DarkCyan);

                    // Horizontal divider
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("+", Color.DarkCyan);
                        for (int k = 0; k < cellWidth; k++)
                        {
                            Console.Write("-", Color.DarkCyan);
                        }
                    }
                    Console.WriteLine("+", Color.DarkCyan);
                }

                Console.Write("\nGold", Color.Gold);
                Console.Write(" = Div by 5  ", Color.White);
                Console.Write("Green", Color.LimeGreen);
                Console.Write(" = Div by 3  ", Color.White);
                Console.Write("Blue", Color.DeepSkyBlue);
                Console.Write(" = Even  ", Color.White);
                Console.Write("Coral", Color.Coral);
                Console.WriteLine(" = Odd", Color.White);
            }

            // EXIT
            else if (choice == "0")
            {
                Console.WriteLine("Goodbye!", Color.LimeGreen);
                return;
            }

            // INVALID
            else
            {
                Console.WriteLine("Invalid choice!", Color.Red);
            }

            Console.WriteLine("\nPress any key to continue...", Color.Gray);
            Console.ReadKey();
        }
    }
}