public class KalkulatorBMI
{
    public string BMI { get; set; }
    public double ObliczBMI(double wzrostCm, double wagaKg)
    {
        double wzrostM= wzrostCm / 100;
        return (wagaKg / (wzrostM*wzrostM));
    }
    public string InterpretujBMI(double bmi)
    {
        if (bmi < 18.5)
            return "Niedowaga";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Waga prawidłowa";
        else if (bmi >= 25 && bmi <=29.9)
            return "Nadwaga";
        else
            return "Otyłość";
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj wzrost:");
        string podanyWzrost = Console.ReadLine();
        while (double.TryParse(podanyWzrost, out double w) == false || w <= 0)
        {
            Console.WriteLine("Podano nieprawidłowy wzrost. Podaj jeszce raz:");
            podanyWzrost = Console.ReadLine();
        }
        double.TryParse(podanyWzrost, out double wzrost);
        
        Console.WriteLine("Podaj wagę:");
        string podanaWaga = Console.ReadLine();
        while (double.TryParse(podanaWaga, out double w) == false || w <= 0)
        {
            Console.WriteLine("Podano nieprawidłową wagę. Podaj jeszce raz:");
            podanaWaga = Console.ReadLine();
        }
        double.TryParse(podanaWaga, out double waga);


        var kalkulator = new KalkulatorBMI();
        double obliczoneBMI = kalkulator.ObliczBMI(wzrost, waga);
        kalkulator.BMI = kalkulator.InterpretujBMI(obliczoneBMI);
        Console.WriteLine("BMI: " + obliczoneBMI + " " + kalkulator.BMI);
    }
}