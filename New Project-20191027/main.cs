using System.IO;
using System;

class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("1)Answer");
            Console.WriteLine($"parseHexInt A:{parseHexInt("A")}");
            Console.WriteLine($"parseHexInt 1F:{parseHexInt("1F")}");
            Console.WriteLine($"parseHexInt BBBB:{parseHexInt("BBBB")}");
 
            Console.WriteLine("-------------\n2)Answer");
            sumInList(new int[] { 1, 10, 3, 7, 9 });
            sumInList(new int[] { -2, 1, -1, 0 });
             
        }

        public static string parseHexInt(string value, string retorno = "")
        {
             /* In the parseHexInt method, we consider n the number of characters present in hexadecimal number 
             * and m the number of bits generated from the hexadecimal number. For Big 0 analysis of the method,
             * we observe that the function is recursive and has a loop based on the number of bits that represent 
             * the hexadecimal value from which the integer conversion will be generated. 
             * Thus the complexity is O (n) + O (m), where the growth of characters present in a hexadecimal 
             * number is directly proportional to the number of operations.
             */
            long valueInt = 0;
            if (value.Length == 0)
            {
                int valor = 0;
                int bit = 1;
                foreach (var item in retorno)
                {
                    if (item == '1')
                        valor = valor + (bit);
                    bit = bit * 2;
                }
                return valor.ToString();
            }
            else if (value[value.Length - 1].Equals('A'))
            {
                retorno = $"{retorno}0101";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('B'))
            {
                retorno = $"{retorno}1101";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('C'))
            {
                retorno = $"{retorno}0011";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('D'))
            {
                retorno = $"{retorno}1011";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('E'))
            {
                retorno = $"{retorno}0111";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('F'))
            {
                retorno = $"{retorno}1111";
                value = value.Remove(value.Length - 1);
            }

            else if (value[value.Length - 1].Equals('0'))
            {
                retorno = $"{retorno}0000";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('1'))
            {
                retorno = $"{retorno}0001";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('2'))
            {
                retorno = $"{retorno}0010";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('3'))
            {
                retorno = $"{retorno}0011";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('4'))
            {
                retorno = $"{retorno}0100";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('5'))
            {
                retorno = $"{retorno}0101";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('6'))
            {
                retorno = $"{retorno}0110";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('7'))
            {
                retorno = $"{retorno}0111";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('8'))
            {
                retorno = $"{retorno}1000";
                value = value.Remove(value.Length - 1);
            }
            else if (value[value.Length - 1].Equals('9'))
            {
                retorno = $"{retorno}1001";
                value = value.Remove(value.Length - 1);
            }
            else
            {
                retorno = $"{retorno}{value}";
                if (valueInt == 0)
                    return parseHexInt("", retorno);
                else if (valueInt == 1)
                    return parseHexInt("1", retorno);
                else
                    return parseHexInt(value, retorno);
            }
            return parseHexInt(value, retorno);
        }

        public static int sumInList(int[] num)
        {
             /*
             In the sum method we have two unlinked loops, the first of complexity O (n) and the second O (n-1) 
             which results in a complexity algorithm O (n) + O (n-1), where we have to a list of size n, where after 
             finding the first value in list n, I have to go through a sublist n-1 to find the second.
             */
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1] && i < num.Length - 1)
                {
                    int valor1 = num[i + 1];
                    num[i + 1] = num[i];
                    num[i] = valor1;
                }
            }
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (num[i] > num[i + 1] && i < num.Length - 1)
                {
                    int valor1 = num[i + 1];
                    num[i + 1] = num[i];
                    num[i] = valor1;
                }
            }
            Console.WriteLine($"Sum ({num[num.Length - 1]} + {num[num.Length - 2]}): {num[num.Length - 1] + num[num.Length - 2]}");
            return 0;
        }
}
