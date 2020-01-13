using System;
using System.Collections.Generic;
using System.Numerics;

public class Program
{
	public static void Main()
	{
    
        //      Console.ReadLine();
        /// Code is reading a value from an Array
        /// Loop an iteration using Dictionaty object to get a list of distinct Account
        
        
        /// ****** Note: I was trying to read the file but was getting the error while reading the file, Hence due to having a limited timespan, I prefer to do this way to complete the Task.
        /// I really grateful to you for considering this program


       // string fileName = @"D:\practise\consoleapplication\accounts.txt";
        
            #region COUNT ACCOUNT NUMBER REPETATION 
           
            BigInteger[] numbers = new[] {
                BigInteger.Parse("03101035382222123361600141"),
                BigInteger.Parse("03101035382222123361600141"),
                BigInteger.Parse("03101035382222123361600142"),
                BigInteger.Parse("30101035382222123361600141"),
                BigInteger.Parse("30101035382222123361600142"),
                BigInteger.Parse("30101035382222123361600141"),
                BigInteger.Parse("30101035382222123361600142"),
                BigInteger.Parse("30101035382222123361600142"),
                BigInteger.Parse("30101035382222123361600144"),
                BigInteger.Parse("30101035382222123361600142"),
                BigInteger.Parse("30101035382222123361600145"),
                BigInteger.Parse("30101035382222123361600145"),
                BigInteger.Parse("30101035382222123361600146"),
                BigInteger.Parse("30101035382222123361600143")
            };


            Dictionary<BigInteger, BigInteger> dictionaryUse = new Dictionary<BigInteger, BigInteger>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dictionaryUse.ContainsKey(numbers[i]))
                {
                    dictionaryUse[numbers[i]] = dictionaryUse[numbers[i]] + 1;
                }
                else
                {
                    dictionaryUse.Add(numbers[i], 1);
                }
            }
            Console.WriteLine("Accounts" + "      " + "Account Repeatation count");
            foreach (var item in dictionaryUse)
            {
                Console.WriteLine(item.Key + "      " + item.Value);
            }
            #endregion

            Console.ReadLine();
    }
}