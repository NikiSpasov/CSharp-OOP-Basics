﻿using System;
using _01.EventImplementation;

public class StaqrtUp
    {
        public static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string name = Console.ReadLine();
            while (name != "End")
            {
                dispatcher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
