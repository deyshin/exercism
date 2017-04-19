using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}



public class Garden
{
    private Dictionary<string, List<Plant>> ChildrenAndPlants { get; set; }

    public Garden(IEnumerable<string> children, string windowSills)
    {
        ChildrenAndPlants = new Dictionary<string, List<Plant>>();

        var SplitSills = windowSills.Split('\n');
        var top = SplitSills[0].ToCharArray();
        var bot = SplitSills[1].ToCharArray();

        var cnt = 0;
        foreach (var c in children)
        {
            var plantList = new List<Plant>();

            plantList.Add(TranslateCharToPlant(top[cnt * 2]));
            plantList.Add(TranslateCharToPlant(top[cnt * 2 + 1]));
            plantList.Add(TranslateCharToPlant(bot[cnt * 2]));
            plantList.Add(TranslateCharToPlant(bot[cnt * 2 + 1]));

            ChildrenAndPlants.Add(c, plantList);
            cnt++;
            if (cnt + 2 > top.Length / 2)
            { break; }
        }
        Console.WriteLine("===");

        foreach (var i in ChildrenAndPlants)
        {
            Console.WriteLine("---" + i.Key);
            foreach (var v in i.Value)
            { Console.WriteLine(v.ToString()); }
        }

    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        List<Plant> res = new List<Plant>();
        ChildrenAndPlants.TryGetValue(child, out res);

        return res;
    }

    public static Garden DefaultGarden(string windowSills)
    {
        var garden = new Garden(new[] { "Alice", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" }, windowSills);
        return garden;
    }

    private Plant TranslateCharToPlant(char c)
    {
        Plant res;
        switch (c)
        {
            case 'V':
                res = Plant.Violets;
                break;
            case 'R':
                res = Plant.Radishes;
                break;
            case 'C':
                res = Plant.Clover;
                break;
            case 'G':
                res = Plant.Grass;
                break;
            default:
                throw new Exception("Char not recognized");
        }

        return res;
    }
}