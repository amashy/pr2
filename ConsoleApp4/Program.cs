using System;
using System.Collections.Generic;

class Program
{
    delegate int StringLengthDelegate(string input);

    static void Main()
    {
        List<string> strings = new List<string> {
            "hello",
            "test",
            "of",
            "code",
            "right",
            "now"
        };

        StringLengthDelegate stringLength = (input) => input.Length;

        foreach (var str in strings)
        {
            int length = stringLength(str);
            Console.WriteLine("{0}: {1} characters", str, length);
        }
    }
}
