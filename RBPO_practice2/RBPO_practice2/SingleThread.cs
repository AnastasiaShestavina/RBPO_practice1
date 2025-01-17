﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RBPO_practice2
{
    internal static class SingleThread
    {
        private static readonly char[] Dictionary =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        internal static void BruteHash(string hash)
        {
            DateTime start = DateTime.Now;
            int length = Dictionary.Length;
            for (int ch1 = 0; ch1 < length; ch1++)
            {
                string a = Convert.ToString(Dictionary[ch1]);
                for (int ch2 = 0; ch2 < length; ch2++)
                {
                    string b = Convert.ToString(Dictionary[ch2]);
                    for (int ch3 = 0; ch3 < length; ch3++)
                    {
                        string c = Convert.ToString(Dictionary[ch3]);
                        for (int ch4 = 0; ch4 < length; ch4++)
                        {
                            string d = Convert.ToString(Dictionary[ch4]);
                            for (int ch5 = 0; ch5 < length; ch5++)
                            {
                                string e = Convert.ToString(Dictionary[ch5]);
                                string password = a + b + c + d + e;
                                string hashed = Hash.GetStringHash(password);
                                if (hash == hashed)
                                {
                                    Console.WriteLine($"Найденый пароль: {password}, Хэш: {hashed}");
                                    Console.WriteLine($"Затраченное время: {DateTime.Now - start}");
                                    ch1 = ch2 = ch3 = ch4 = ch5 = length;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
