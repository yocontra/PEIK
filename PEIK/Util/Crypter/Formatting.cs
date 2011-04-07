using System;
using System.Collections.Generic;
using System.Text;

namespace PEIK.Util.Crypter
{
    class Formatting
    {
            public static string Format(byte[] input)
            {
                return Convert.ToBase64String(input);
                /*
                const char buff = (char) 34;
                // Codedom has maximum of possible chars per line so we are storing the string in multiple strings
                StringBuilder tout = new StringBuilder();
                // Declaring a new StringBuilder to store the output string
                string base64Data = Convert.ToBase64String(input);
                // Get a readable String from the Byte Array
                string[] arr = SplitString(base64Data, 1);
                // Split the string into parts to fit in the Codedom-lines
                // Looping thought each string in the array
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    // If i equals the highest number
                    if (i == arr.Length - 1)
                    {
                        tout.Append(buff + arr[i] + buff);
                        //I is smaller than arr.Length - 1 (i < arr.Length - 1)
                    }
                    else
                    {
                        tout.Append(buff + arr[i] + buff + " & _" + Environment.NewLine);
                    }
                }
                return tout.ToString();*/
            }
            private static string[] SplitString(string input, int partsize)
            {
                int amount = input.Length / partsize;
                //Get Long value of the amount of parts using the formular (Length of Input / Length of Parts)
                string[] @out = new string[amount];
                //Declaring the Array to Return using the amount of Parts to define the size
                long currentpos = 0;
                // Declaring the Currentposition in the String
                // Looping thought each string in the array
                for (int I = 0; I <= amount - 1; I++)
                {
                    // If i equals the highest number
                    if (I == amount - 1)
                    {
                        char[] temp = new char[(input.Length - currentpos)];
                        // Declaring a temporary Array of Chars for storing the current Part of the String
                        input.CopyTo((int) currentpos, temp, 0, (int) (input.Length - currentpos));
                        // Current part is everything left from the string
                        @out[I] = Convert.ToString(temp);
                        // Current part is appended to the output string
                        //I is smaller than amount - 1 (i < amount - 1)
                    }
                    else
                    {
                        char[] temp = new char[partsize];
                        // Declaring a temporary Array of Chars for storing the current Part if the String using the Size of a part (partsize)
                        input.CopyTo((int) currentpos, temp, 0, partsize);
                        // Copying the current Part to the temp array
                        @out[I] = Convert.ToString(temp);
                        // Current part is appended to the output string
                        currentpos += partsize;
                        // Currentposition is increase to catch the next part in the next "round" of the loop
                    }
                }
                return @out;
                // Return the Output String
            }
        }

    }
