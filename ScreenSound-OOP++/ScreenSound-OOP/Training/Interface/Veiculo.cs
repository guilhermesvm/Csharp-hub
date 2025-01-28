namespace ScreenSound.Training.Heritage;

public interface IPagavel
{
    double CalcularPagamento();
}

public class Produto : IPagavel
{
    public int Valor { get; set; }
    public int Quantidade { get; set; }

    public double CalcularPagamento()
    {
        return Valor * Quantidade;
    }

}
