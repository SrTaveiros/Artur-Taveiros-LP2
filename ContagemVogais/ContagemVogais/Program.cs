﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char pos;
            int i, vogal;

            vogal = 0;

            Console.WriteLine("informeo texto desejado");
            s = Console.ReadLine();

            for (i = 0; i < s.Length; i++)
            {
                pos = s[i];

                if (pos == 'a' || pos == 'A' || pos == 'e' || pos == 'E' || pos == 'i' || pos == 'I' || pos == 'o' || pos == 'O' || pos == 'u' || pos == 'U')
                    vogal++;

            }

            Console.WriteLine("Número de vogais: {0} vogais", vogal);
        }
    }
}
