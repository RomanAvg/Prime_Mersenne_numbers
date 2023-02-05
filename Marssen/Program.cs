namespace Marssen
{
    internal class Program
    {
        static private List<int> Marsen(int n)
        {
            var answerlocal=new List<int>();
            
            for(int i = 1; i <= n; i++)
            {
                answerlocal.Add(Convert.ToInt16(Math.Pow(2, i)) - 1);
            }
            for(int i=0;i<answerlocal.Count;i++)
            {
                int check = 0;
                for(int j = 1; j <= answerlocal[i]; j++)
                {
                    if (answerlocal[i] % j == 0)
                    {
                        check++;
                    }
                }
                if (check > 2)
                {
                    answerlocal.RemoveAt(i);
                }
            }
            return answerlocal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max value");
            List<int> answer=Marsen(Convert.ToInt16(Console.ReadLine()));
            foreach(int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}