class Program
{
    public static void Main()
    {
        Console.Clear();
        decimal valorInicial = 3800;
        Console.WriteLine("valor inicial:" + valorInicial);
        decimal taxa = 1.25M;
        Console.WriteLine("taxa:"+ taxa);
        int periodo = 6;
        Console.WriteLine("periodo:" + periodo);
        Console.WriteLine("  MES | REDIMENTO DO MES | REDIMENTO TOTAL | ");
        for (int i = 1; i <= periodo; i++)
        {
            Console.WriteLine(
            $" {i} |".PadLeft(7, ' ') +
            $"{juroscompostos(valorInicial, taxa, i) - juroscompostos(valorInicial, taxa, i - 1):F2} |".PadLeft(19, ' ') +
            $"{juroscompostos(valorInicial, taxa, i):F2} | ".PadLeft(19, ' ')
             );
        }




    }
    public static decimal juroscompostos(decimal VLInicial, decimal taxa, int periodo)
    {
        return VLInicial * Pow(1 + taxa / 100, periodo);
    }
    public static decimal Pow(decimal num, int power)
    {
        if (power == 1) return num;
        if (power > 1) return Pow(num, power - 1) * num;
        else return Pow(num, power + 1) / num;
    }

}
