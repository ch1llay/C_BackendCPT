using System;

namespace Task4
{
    class SuperConsole
    {

        private string symbol;
        private bool writeDoubleSymbol = false;
        public SuperConsole(string symbol)
        {
            this.symbol = symbol;
        }
        public SuperConsole(string symbol, bool writeDoubleSymbol=true)
        {
            this.symbol = symbol;
            this.writeDoubleSymbol = writeDoubleSymbol;
        }
        private void WriteSymbol(int n)
        {
            Console.WriteLine();
            for (var i = 0; i < n; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        public void Print(string s)
        {
            int n = !(writeDoubleSymbol) ? s.Length : s.Length * 2;
            WriteSymbol(n);
            Console.WriteLine(s);
            WriteSymbol(n);
        }
        public void Print(decimal number)
        {
            int n = !(writeDoubleSymbol) ? number.ToString().Length : number.ToString().Length * 2;
            WriteSymbol(n);
            Console.WriteLine(number);
            WriteSymbol(n);


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperConsole superConsoleSingle = new SuperConsole("*");
            superConsoleSingle.Print("Строка перед и после которой будут звездочки по длине строки");
            SuperConsole superConsoleDouble = new SuperConsole("*", true);
            superConsoleDouble.Print("Строка перед и после которой будут звездочки количество которых в два раза превашает длину строки");

        }
    }
}
