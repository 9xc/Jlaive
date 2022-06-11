﻿using System;
using System.Collections.Generic;
using System.Linq;

using static Jlaive.Utils;

namespace Jlaive
{
    public class Obfuscator
    {
        public static (string, string) GenCodeBat(string input, Random rng, int level = 5)
        {
            string ret = string.Empty;
            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            int amount = 5;
            if (level > 1) amount -= level;
            amount *= 2;

            List<string> setlines = new List<string>();
            List<string[]> linevars = new List<string[]>();
            foreach (string line in lines)
            {
                List<string> splitted = new List<string>();
                string sc = string.Empty;
                bool invar = false;
                foreach (char c in line)
                {
                    if (c == '%')
                    {
                        invar = !invar;
                        sc += c;
                        continue;
                    }
                    if (c == ' ' && invar)
                    {
                        invar = false;
                        sc += c;
                        continue;
                    }
                    if (!invar && sc.Length >= amount)
                    {
                        splitted.Add(sc);
                        invar = false;
                        sc = string.Empty;
                    }
                    sc += c;
                }
                splitted.Add(sc);

                List<string> vars = new List<string>();
                foreach (string s in splitted)
                {
                    string name = RandomString(10, rng);
                    setlines.Add($"set \"{name}={s}\"");
                    vars.Add(name);
                }
                linevars.Add(vars.ToArray());
            }

            setlines = new List<string>(setlines.OrderBy(x => rng.Next()));
            for (int i = 0; i < setlines.Count; i++)
            {
                ret += setlines[i];
                int r = rng.Next(0, 2);
                if (r == 0 || i == setlines.Count - 1) ret += Environment.NewLine;
                else ret += " & ";
            }

            string varcalls = string.Empty;
            foreach (string[] line in linevars)
            {
                foreach (string s in line) varcalls += $"%{s}%";
                varcalls += Environment.NewLine;
            }
            return (ret.TrimEnd('\r', '\n'), varcalls.TrimEnd('\r', '\n'));
        }

        public static string GenCodePs(string input, Random rng, int level = 5)
        {
            string ret = string.Empty;
            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            int amount = 5;
            if (level > 1) amount -= level;
            amount *= 2;

            List<string> setlines = new List<string>();
            List<string[]> linevars = new List<string[]>();
            foreach (string line in lines)
            {
                List<string> splitted = new List<string>();
                string sc = string.Empty;
                bool invar = false;
                foreach (char c in line)
                {
                    if (c == '%')
                    {
                        invar = !invar;
                        sc += c;
                        continue;
                    }
                    if (c == ' ' && invar)
                    {
                        invar = false;
                        sc += c;
                        continue;
                    }
                    if (!invar && sc.Length >= amount)
                    {
                        splitted.Add(sc);
                        invar = false;
                        sc = string.Empty;
                    }
                    if (c == '\'')
                    {
                        sc += "''";
                        continue;
                    }
                    sc += c;
                }
                splitted.Add(sc);

                List<string> vars = new List<string>();
                foreach (string s in splitted)
                {
                    string name = RandomString(10, rng);
                    setlines.Add($"${name}='{s}'");
                    vars.Add(name);
                }
                linevars.Add(vars.ToArray());
            }

            setlines = new List<string>(setlines.OrderBy(x => rng.Next()));
            for (int i = 0; i < setlines.Count; i++) ret += setlines[i] + ";";

            string concat = string.Empty;
            foreach (string[] line in linevars)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (i != line.Length - 1) concat += $"${line[i]} + ";
                    else concat += $"${line[i]}";
                }
            }
            ret += "iex (" + concat + ")";
            return ret;
        }
    }
}