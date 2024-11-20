namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr = { "A - Add", "B - Sub", "C - Divison", "D - Mut", "E - Exit" };
            Boolean b = true;
            
            for (int i = 0; b; i++)
            {
                int p = 0;
                while (p < arr.Length)
                {
                    Console.WriteLine(arr[p++]);
                }

                char List = char.Parse(Console.ReadLine());

                if (List == 'E')
                {
                    b = false;
                    break;

                }
                if (List == 'A')
                {
                    Console.WriteLine("Enter The NumberOne");

                    int NumOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The NumberTwo");

                    int NumTwo = int.Parse(Console.ReadLine());
                    int res = NumOne + NumTwo;
                    Console.WriteLine("result = "+res);
                   continue;

                }
                else if (List == 'B')

                {
                    Console.WriteLine("Enter The NumberOne");

                    int NumOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The NumberTwo");

                    int NumTwo = int.Parse(Console.ReadLine());
                    int res = NumOne - NumTwo;
                    Console.WriteLine("result = " + res);
                    continue;

                }
                else if (List == 'C')

                {
                    Console.WriteLine("Enter The NumberOne");

                    int NumOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The NumberTwo");

                    int NumTwo = int.Parse(Console.ReadLine());
                    int res = NumOne * NumTwo;
                    Console.WriteLine("result = " + res);
                    continue;

                }
                else if (List == 'D')
                {
                    Console.WriteLine("Enter The NumberOne");

                    int NumOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The NumberTwo");

                    int NumTwo = int.Parse(Console.ReadLine());
                    int res = NumOne / NumTwo;
                    Console.WriteLine("result = " + res);
                    continue;

                }
                else
                {
                    Console.WriteLine("invalid input");
                    continue;

                }


            }
           
          
            
            
           
               

               
            
        }







           
        
    }
}