class Program{
    public static void Main(){
        Console.Clear();
        Console.Write("valor inicial:");
        decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
        Console.Write("taxa:");
        decimal taxa = Convert.ToDecimal(Console.ReadLine());
        Console.Write("periodo:");
        int periodo = Convert.ToInt32(Console.ReadLine());



        Console.Write($"Valor final: {juroscompostos(valorInicial, taxa,periodo):F2}");

    }
    public static decimal juroscompostos(decimal vlPresente, decimal taxa, int periodo){
        return vlPresente * Pow(1+taxa/100,periodo);
    }
    public static decimal Pow(decimal num, int power){
        if(power ==1 ) return num;
        if(power>1) return Pow(num, power-1) * num;
        else return Pow(num, power+1)/num;
    }

}
