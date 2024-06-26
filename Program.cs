class Program{
    public static void Main(){
        Console.Clear();
        decimal valorFinal = 7390.61M;
        int periodo = 2;
        decimal taxa = 1.25M;
        decimal valorPresente = VP(valorFinal, taxa, periodo);
        Console.WriteLine($"taxa = {taxa}, valor presente = {valorPresente:F2}");
    }
    static decimal VP(decimal valorFinal,decimal taxa,int periodo){
        return valorFinal/(taxa + (periodo*taxa));
    }
}