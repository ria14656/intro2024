using System;

class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("Error: División menor a 1");
    }
}

class CalculadoraCientifica : Calculadora
{
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }

    public double Potencias(double baseValue, double exponente)
    {
        return Math.Pow(baseValue, exponente);
    }

    public double Raiz(double numero)
    {
        return Math.Sqrt(numero);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double numero)
    {
        return Math.Log(numero);
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de Calculadora
        var calculadoraBase = new Calculadora(marca: "casio", serie: "554471");

        // Crear una instancia de Calculadora Cientifica
        var calculadoraCientifica = new CalculadoraCientifica(marca: "Rolex", serie: "997858");

        // Probar los métodos
        Console.WriteLine($"Suma: {calculadoraBase.Sumar(15, 6)}");
        Console.WriteLine($"Resta: {calculadoraBase.Restar(30, 5)}");
        Console.WriteLine($"Multiplicación: {calculadoraBase.Multiplicar(20, 3)}");
        Console.WriteLine($"División: {calculadoraBase.Dividir(10, 8)}");

        Console.WriteLine($"Potencia: {calculadoraCientifica.Potencias(7, 3)}");
        Console.WriteLine($"Raíz cuadrada: {calculadoraCientifica.Raiz(9)}");
        Console.WriteLine($"Módulo: {calculadoraCientifica.Modulo(12, 3)}");
        Console.WriteLine($"Logaritmo: {calculadoraCientifica.Logaritmo(110)}");
    }
}
