namespace NumberPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            int j = 1;
            do
            {
                for( i =1;i<=5;i++)
                {
                  for( j = 1; j <= 2; j++)
                    {
                        Console.WriteLine(i+" "+j);
                    }
                }     
            }while(i<=5);
        }
    }
}
