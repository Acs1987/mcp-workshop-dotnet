using System;
using System.Collections.Generic;

namespace MyMonkeyApp;

/// <summary>
/// Helper estático para la gestión de datos de monos.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey("Baboon", "África", 15000),
        new Monkey("Capuchin Monkey", "Centroamérica", 8000),
        new Monkey("Blue Monkey", "África", 12000),
        new Monkey("Squirrel Monkey", "Sudamérica", 20000),
        new Monkey("Golden Lion Tamarin", "Brasil", 3200),
        new Monkey("Howler Monkey", "Sudamérica", 10000),
        new Monkey("Japanese Macaque", "Japón", 5000),
        new Monkey("Mandrill", "África", 9000),
        new Monkey("Proboscis Monkey", "Borneo", 7000),
        new Monkey("Sebastian", "Seattle", 1),
        new Monkey("Henry", "Phoenix", 1),
        new Monkey("Red-shanked douc", "Vietnam", 2500),
        new Monkey("Mooch", "Seattle", 1)
    };

    public static List<Monkey> GetMonkeys() => monkeys;

    public static Monkey? GetMonkeyByName(string name) =>
        monkeys.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    public static Monkey GetRandomMonkey()
    {
        var rand = new Random();
        return monkeys[rand.Next(monkeys.Count)];
    }
}
