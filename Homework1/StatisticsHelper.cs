namespace Homework1;

public class StatisticsHelper
{
    private List<int> lista;

    public StatisticsHelper(List<int> lista)
    {
        this.lista = lista;
    }

    Func<int, bool> parity = n => n%2 == 0;
    
    
    
}