using System;

namespace Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];

            int B = 0;
            int S = 0;
            int W = 0;
            int wildBoar = 0;
           

            for (int r = 0; r < n; r++)
            {
                string[] chars = Console.ReadLine().Split();
                for (int c = 0; c < chars.Length; c++)
                {
                    
                    matrix[r, c] = chars[c];
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop the hunt")
            {


                if (command.StartsWith("Collect"))
                {
                    int row = int.Parse(command.Split()[1]);
                    int col = int.Parse(command.Split()[2]);

                    
                        if (matrix[row, col] == "B")
                        {
                            B++;
                            matrix[row, col] = "-";

                        }
                        else if (matrix[row, col] == "S")
                        {
                            S++;
                            matrix[row, col] = "-";

                        }
                        else if (matrix[row, col] == "W")
                        {
                            W++;
                            matrix[row, col] = "-";

                        }
                 


                }
                else if (command.StartsWith("Wild_Boar"))
                {   
                    int row = int.Parse(command.Split()[1]);
                    int col = int.Parse(command.Split()[2]);
                    string direction = command.Split()[3];
                   
                    if (direction == "right")
                    {
                        while (col <= matrix.GetLength(1) - 1)
                        {

                            if ((matrix[row, col] == "B") || (matrix[row, col] == "S") || (matrix[row, col] == "W"))
                            {
                                wildBoar++;
                                matrix[row, col] = "-";
                            }

                            col += 2;

                        }


                    }
                    else if (direction == "left")
                    {
                        while (col >= 0)
                        {

                            if ((matrix[row, col] == "B") || (matrix[row, col] == "S") || (matrix[row, col] == "W"))
                            {
                                wildBoar++;
                                matrix[row, col] = "-";
                            }

                            col -= 2;

                        }
                    }
                    else if (direction == "up")
                    {

                        while (row  >= 0 )
                        {

                            if ((matrix[row, col] == "B") || (matrix[row, col] == "S") || (matrix[row, col] == "W"))
                            {
                                wildBoar++;
                                matrix[row, col] = "-";
                            }

                            row -= 2;

                        }
                    }
                    else if (direction == "down")
                    {

                        while (row <= matrix.GetLength(0) - 1)
                        {

                            if ((matrix[row, col] == "B") || (matrix[row, col] == "S") || (matrix[row, col] == "W"))
                            {
                                wildBoar++;
                                matrix[row, col] = "-";
                            }

                            row += 2;

                        }
                    }




                }
                command = Console.ReadLine();
            }
            
                Console.WriteLine($"Peter manages to harvest {B} black, {S} summer, and {W} white truffles.");
                Console.WriteLine($"The wild boar has eaten {wildBoar} truffles.");
                for (int r = 0; r < matrix.GetLength(0); r++)
                {

                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        Console.Write(matrix[r, c] + " ");



                    }

                    Console.WriteLine();
                }
            
       }

      

           
    }
}



