﻿using System;

public class StartUp
{
    public static void Main()
    {
        string rank = Console.ReadLine();
        string suit = Console.ReadLine();
        Card currentCard = new Card(rank, suit);

        Console.WriteLine(currentCard);
    }
}

