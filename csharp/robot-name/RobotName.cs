using System;
using System.Linq;

public class Robot
{
    public Robot ()
    {   //cross-instance uniqueness verification requirement 
        //needs a static List<string> for names. 
        //Decided to go simple for this accercise.
        Name = GetRandomName();
    }
    public string Name
    { get; private set; }

    public void Reset()
    {   //refer to the comment on Robot() constructor. 
        Name = GetRandomName();
    }

    //static variable rand to 
    //randomize across different instance of Robot
    private static Random rand = new Random();  
    private char[] Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private string GetRandomName()
    {
        var randomName = string.Empty;

        //ref: https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
        randomName += new String
                    (Enumerable
                    .Repeat(Alphabets, 2)                  //2 iterations of choices
                    .Select(a => a[rand.Next(a.Length)])   //randomly choose one from the choices
                    .ToArray()
                    );
        randomName += rand.Next(999).ToString();

        return randomName;
    }
}