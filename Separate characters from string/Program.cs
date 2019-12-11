using System;
public class Exercise3
{
    public static void Main()
    {
        string str;
        int l = 0;

        Console.Write("\n\nSeparate the individual characters from a string :\n");
        Console.Write("------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        Console.Write("The characters of the string are  :  ");
        while (l <= str.Length - 1)
        {
            Console.Write("{0} ", str[l]);
            l++;
        }
        Console.Write("\n\n");
    }
}
/*
Separate the individual characters from a string :
------------------------------------------------------
Input the string : sachin gurung
The characters of the string are  :  s a c h i n   g u r u n g

Press any key to continue . . .
*/
