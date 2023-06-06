// See https://aka.ms/new-console-template for more information
////數字常見的用法 (整數/浮點數
//3
Console.WriteLine(5 - 2);

//10
Console.WriteLine(5 * 2);

//回傳的解果是省略掉小數點的部分因為是整數跟整數的運算 
//2
Console.WriteLine(5 / 2);

//只要把其中一邊改成有小數點的數 解果就會變成 
//2.5
Console.WriteLine(5 / 3.0);

int num = 3;
Console.WriteLine((5 + 2) / num);

//絕對值 
//10
Console.WriteLine(System.Math.Abs(-10));

//2的3次方
//8
Console.WriteLine(System.Math.Pow(2, 3));

//開根號
//8
Console.WriteLine(System.Math.Sqrt(64));

//回傳比較大的值
//101
Console.WriteLine(System.Math.Max(101, 64));

//回傳比較小的值
//64
Console.WriteLine(System.Math.Min(101, 64));

//4捨5入
//3
Console.WriteLine(System.Math.Round(3.4));

