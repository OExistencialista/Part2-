class Program{
    public static void Main(){
        Console.Clear();
        
        decimal valorInicial = 1000;
        Console.WriteLine("Valor inicial:" + valorInicial);
        
        decimal taxa = 5.30M;
        Console.WriteLine("Taxa:"+ taxa);
        
        int periodo = 10;
        Console.WriteLine("Periodo:" + periodo);



        Console.Write($"Valor final:{juroscompostos(valorInicial, taxa,periodo):F2}");

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
