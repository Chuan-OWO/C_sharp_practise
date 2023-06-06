//Array 陣列
int[] scores = { 50,60,70,30,20 };
//  0  1   2  3  4


/*
創建一個空的陣列
他可以放十個字串
*/
string[] phones = new string[10];

phones[0] = "0123456789";

phones[1] = "12388888";
Console.WriteLine(phones);
Console.WriteLine(scores);

//改變陣列第一個值
scores[0] = 1; 


//取得陣列的值

Console.WriteLine(scores[0]);

Console.WriteLine(scores[1]);

Console.WriteLine(scores[2]);

Console.WriteLine(scores[3]);

Console.WriteLine(scores[4]);


/*
 ***創建陣列的方法有兩種
1.創建陣列 給{} 把值寫在裡面

2.不確定陣列裡面的值
    可先創建空陣列
    指定陣列可以放幾個值
    再把值一個個給陣列
 */