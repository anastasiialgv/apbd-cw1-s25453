namespace Homework1;

public class StatisticsHelper
{
    private List<int> lista;

    public StatisticsHelper(List<int> lista)
    {
        this.lista = lista;
    }

    Func<int, bool> parity = n => n%2 == 0;

    public void CheckParity()
    {
        if (lista == null || lista.Count == 0)
        {
            Console.WriteLine("Error: The list is empty. Cannot check parity."); 
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