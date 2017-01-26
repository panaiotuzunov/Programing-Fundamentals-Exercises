using System;

class InstructionSet_broken
{
    static void Main()
    {
        string[] commandArr = Console.ReadLine().Split();
        string command = commandArr[0];

        while (command != "END")
        {
            long result = 0;

            switch (command)
            {
                case "INC":
                    {
                        long operandOne = long.Parse(commandArr[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(commandArr[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(commandArr[1]);
                        long operandTwo = long.Parse(commandArr[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(commandArr[1]);
                        long operandTwo = long.Parse(commandArr[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            Console.WriteLine(result);

            commandArr = Console.ReadLine().Split();
            command = commandArr[0];
        }
    }
}