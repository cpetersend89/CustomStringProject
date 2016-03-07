using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace CustomStringProject
{
    class CustomMethods
    {
        public void CustomToUpper(string toUpper)
        {
            foreach (char t in toUpper)
            {
                if (t == 'a' || t == 'A')
                    Console.WriteLine("A");
                if (t == 'b' || t == 'B')
                    Console.WriteLine("B");
                if (t == 'c' || t == 'C')
                    Console.WriteLine("C");
                if (t == 'd' || t == 'D')
                    Console.WriteLine("D");
                if (t == 'e' || t == 'E')
                    Console.WriteLine("E");
                if (t == 'f' || t == 'F')
                    Console.WriteLine("F");
                if (t == 'g' || t == 'G')
                    Console.WriteLine("G");
                if (t == 'h' || t == 'H')
                    Console.WriteLine("H");
                if (t == 'i' || t == 'I')
                    Console.WriteLine("I");
                if (t == 'j' || t == 'J')
                    Console.WriteLine("J");
                if (t == 'k' || t == 'K')
                    Console.WriteLine("K");
                if (t == 'l' || t == 'L')
                    Console.WriteLine("L");
                if (t == 'm' || t == 'M')
                    Console.WriteLine("M");
                if (t == 'n' || t == 'N')
                    Console.WriteLine("N");
                if (t == 'o' || t == 'O')
                    Console.WriteLine("O");
                if (t == 'p' || t == 'P')
                    Console.WriteLine("P");
                if (t == 'q' || t == 'Q')
                    Console.WriteLine("Q");
                if (t == 'r' || t == 'R')
                    Console.WriteLine("R");
                if (t == 's' || t == 'S')
                    Console.WriteLine("S");
                if (t == 't' || t == 'T')
                    Console.WriteLine("T");
                if (t == 'u' || t == 'U')
                    Console.WriteLine("U");
                if (t == 'v' || t == 'V')
                    Console.WriteLine("V");
                if (t == 'w' || t == 'W')
                    Console.WriteLine("W");
                if (t == 'x' || t == 'X')
                    Console.WriteLine("X");
                if (t == 'y' || t == 'Y')
                    Console.WriteLine("Y");
                if (t == 'z' || t == 'Z')
                    Console.WriteLine("Z");
                if (t == ' ')
                    Console.WriteLine(" ");
            }
        }

        public void CustomToLower(string toLower)
        {
            foreach (char t in toLower)
            {
                if (t == 'a' || t == 'A')
                    Console.WriteLine("a");
                if (t == 'b' || t == 'B')
                    Console.WriteLine("b");
                if (t == 'c' || t == 'C')
                    Console.WriteLine("c");
                if (t == 'd' || t == 'D')
                    Console.WriteLine("d");
                if (t == 'e' || t == 'E')
                    Console.WriteLine("e");
                if (t == 'f' || t == 'F')
                    Console.WriteLine("f");
                if (t == 'g' || t == 'G')
                    Console.WriteLine("g");
                if (t == 'h' || t == 'H')
                    Console.WriteLine("h");
                if (t == 'i' || t == 'I')
                    Console.WriteLine("i");
                if (t == 'j' || t == 'J')
                    Console.WriteLine("j");
                if (t == 'k' || t == 'K')
                    Console.WriteLine("k");
                if (t == 'l' || t == 'L')
                    Console.WriteLine("l");
                if (t == 'm' || t == 'M')
                    Console.WriteLine("m");
                if (t == 'n' || t == 'N')
                    Console.WriteLine("n");
                if (t == 'o' || t == 'O')
                    Console.WriteLine("o");
                if (t == 'p' || t == 'P')
                    Console.WriteLine("p");
                if (t == 'q' || t == 'Q')
                    Console.WriteLine("q");
                if (t == 'r' || t == 'R')
                    Console.WriteLine("r");
                if (t == 's' || t == 'S')
                    Console.WriteLine("s");
                if (t == 't' || t == 'T')
                    Console.WriteLine("t");
                if (t == 'u' || t == 'U')
                    Console.WriteLine("u");
                if (t == 'v' || t == 'V')
                    Console.WriteLine("v");
                if (t == 'w' || t == 'W')
                    Console.WriteLine("w");
                if (t == 'x' || t == 'X')
                    Console.WriteLine("x");
                if (t == 'y' || t == 'Y')
                    Console.WriteLine("y");
                if (t == 'z' || t == 'Z')
                    Console.WriteLine("z");
                if (t == ' ')
                    Console.WriteLine(" ");
            }
        }
        public string ToLowerCase(string str)
        {
            string result = Empty;

            foreach (char t in str)
            {
                if (t >= 65 && t <= 90)
                    result += Convert.ToChar((int)t + 32);
                else
                    result += t;
            }

            return result;
        }

        public string ToUpperCase(string str)
        {
            string result = Empty;

            foreach (char t in str)
            {
                if (t >= 97 && t <= 122)
                    result += Convert.ToChar(t - 32);
                else
                    result += t;
            }
            return result;
        }
        public void Split(string value)
        {
            string output;
            output = "";
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                output += (array[i] + " . ");
            }
            Console.WriteLine(output);
        }

        public bool CustomContains(string str, char c)
        {
            char result;
            string s = ToLowerCase(str);
            foreach (char t in s)
            {
                if (t == c)
                    return true;

            }
            return false;

        }

        public int CustomCount(string str)
        {
            int value = 0;
            foreach (char t in str)
            {
                value++;
            }
            return value;
        }

        public void CustomReplace(string str, char current, char replace)
        {
            char[] characters = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == current)
                {
                    characters[i] = replace;

                }
            }
            foreach (char character in characters)
            {
                Console.Write(character);
            }
        }

    }
}
