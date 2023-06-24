using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj czas w sekundach:");
        int elapsedTime = Convert.ToInt32(Console.ReadLine());
        string formattedTime = FormatTime(elapsedTime);
        Console.WriteLine(formattedTime);
    }

    static string FormatTime(int elapsedTime)
    {
        int hours = elapsedTime / 3600;
        int minutes = (elapsedTime % 3600) / 60;
        int seconds = elapsedTime % 60;

        string formattedHours = hours.ToString("D2");
        string formattedMinutes = minutes.ToString("D2");
        string formattedSeconds = seconds.ToString("D2");

        string formattedTime = $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
        return formattedTime;
    }
}