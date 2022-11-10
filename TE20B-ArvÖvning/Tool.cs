using System;



public class Tool : Item
{
    public Tool()
    {

        name = "Tool";

        Random generator = new Random();

        rarity = generator.Next(1, 3);
    }
}
