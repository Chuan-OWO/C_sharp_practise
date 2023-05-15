// See https://aka.ms/new-console-template for more information
//字串的常見用法

//反斜線n =>換行
System.Console.WriteLine("Hello \nWorld!");
//新的寫法
//Console.WriteLine("Hello \nWorld!");

//雙引號在字串加上雙引號
System.Console.WriteLine("Hello\" World!");
//字串相加 
System.Console.WriteLine("Hello" + "World!");

//字串字的長度 .length
string phrase = "Hello World!";
System.Console.WriteLine(phrase.Length); //12

//將字串"全部"轉成大寫 的方法
System.Console.WriteLine(phrase.ToUpper());//HELLO WORLD!
//將字串"全部"轉成小寫 的方法
System.Console.WriteLine(phrase.ToLower());//hello world!

//判斷參數裡面是否含有 Hello World! 得字串
System.Console.WriteLine(phrase.Contains(phrase)); //ture

//判斷 位置去找值 //C#是從零開始 "Hello World!" 
System.Console.WriteLine(phrase[1]); //e

//判斷 值去找位置
System.Console.WriteLine(phrase.IndexOf('e')); //1

//Substring(從第幾個位置,留幾個) 字串切割 從第一個位置切割 
//Hello World! => ellow world
System.Console.WriteLine(phrase.Substring(1,4));