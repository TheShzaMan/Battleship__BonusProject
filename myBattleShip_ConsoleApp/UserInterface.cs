using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace myBattleShip_ConsoleApp
{
    public static class UserInterface
    {
        public int ConvertRow(string rowName)
        {
            
            Dictionary<string, int> letterToNum = new Dictionary<string, int>();
            letterToNum.Add("A", 1); letterToNum.Add("a", 1);
            letterToNum.Add("B", 2); letterToNum.Add("b", 2);
            letterToNum.Add("C", 3); letterToNum.Add("c", 3);
            letterToNum.Add("D", 4); letterToNum.Add("d", 4);
            letterToNum.Add("E", 5); letterToNum.Add("e", 5);
            letterToNum.Add("F", 6); letterToNum.Add("f", 6);
            letterToNum.Add("G", 7); letterToNum.Add("g", 7);
            letterToNum.Add("H", 8); letterToNum.Add("h", 8);
            letterToNum.Add("I", 9); letterToNum.Add("i", 9);
            letterToNum.Add("J", 10); letterToNum.Add("j", 10);


            int convertedInt = letterToNum[rowName];
            return convertedInt;
        }
        public void SelectSpace()
        {
            Console.WriteLine("Make your selection - letter comma number\nexample: A,9");
            string userSelection = Console.ReadLine(); 
            int row = ConvertRow(userSelection[0].ToString());
            int column = Convert.ToInt32(userSelection[];
    }
}
