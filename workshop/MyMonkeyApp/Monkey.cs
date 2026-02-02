using System;

namespace MyMonkeyApp;

/// <summary>
/// Modelo de datos para un mono.
/// </summary>
public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int Population { get; set; }

    public Monkey(string name, string location, int population)
    {
        Name = name;
        Location = location;
        Population = population;
    }
}
