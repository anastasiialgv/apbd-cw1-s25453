namespace Homework1;

public class StatisticsHelper
{
    private List<int> lista;

    public StatisticsHelper(List<int> lista)
    {
        this.lista = lista;
    }

    Func<int, bool> parity = n => n%2 == 0;

    public static int CalculateAverage(int[] values)
    {
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }

        return sum / values.Length;
    }
    
    public static int CalculateMax(int[] values)
    {
        int max = 0;
        foreach (int value in values)
        {
            if (value > max)
                max = value;
        }

        return max;
    }
    
    public static int CalculateMin(int[] values)
    {

    }

    public void CheckParity()
    {
        if (lista == null || lista.Count == 0)
        {
            Console.WriteLine("The list is empty. Cannot check parity."); 
            return;
        }
        foreach (var number in lista)
        {
            if (parity(number))
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
    }
    
}