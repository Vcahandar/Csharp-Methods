//1)Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//static void Num()
//{
//	int n =41;
//	if (n%3==0&&n%7==0)
//	{
//		Console.WriteLine("Bolunur");
//	}
//	else
//	{
//		Console.WriteLine("Bolunmur");
//	}

//}
//Num();


//2)n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.



//static void Num()
//{
//    int n = 8;
//    int m = 6;
//    int sum= 0; 

//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }
//    Console.WriteLine(sum);
//}
//Num();  


//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapinstat


//static void Num()
//{
//    int n = 1;
//    int m = 10;
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum = sum + i;

//        }


//    }
//    Console.WriteLine(sum);

//}

//Num();


//4) Verilmish arrayin icindeki tek ededlerin cemini tapin



//static void Nums()
//{
//	int[] number = { 1, 5, 7, 9, 8, 6, 3, 10 };
//	int sum = 0;
//	for (int i = 0; i < number.Length; i++)
//	{
//		if (number[i] % 2 == 1)
//		{
//			sum = sum + number[i];

//		}

//	}
//	Console.WriteLine(sum);
//}
//Nums();


//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.


//static  void Result()
//{
//    int[] nums = { 1, 2, 4, 5, 6, 7, 8, };
//    int sum = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i]%2==0)
//        {
//            sum = sum + nums[i];
//        }

//    }
//    Console.WriteLine(sum);
//}

//Result();   


//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.




//NumSum(1, 10);
//static void NumSum(int n,int m)
//{

//    int count = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    if (n > m)
//    {
//        Console.WriteLine("Duzgun Reqem Daxil Edin!");
//    }
//    else
//    {
//        Console.WriteLine(count);
//    }
//}



//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.


//static int NumsSum(int n, int m)
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum += i;
//		}

//	}
//	return sum;


//}
//Console.WriteLine(NumsSum(1, 10));


//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//static  int Nums(int n,int  m)
//{
//    int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2==0)
//		{
//			count++;

//		}



//	}
//	return count;	
//}

//int result = Nums(20, 30);

//Console.WriteLine(result);


//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
//static  void Nums()
//{


//    int n = -5;
//    int count = 0;

//    if (n <= 0)
//    {
//        Console.WriteLine("Duzgun eded daxil edin!");
//    }
//    else if (n == 1)
//    {
//        Console.WriteLine("Ne sade Ne murekkebdir!");

//    }

//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }

//        if (count > 2)
//        {
//            Console.WriteLine("Murekkebdir");
//        }
//        else
//        {
//            Console.WriteLine("Sadedir");
//        }


//    }


//}


//Nums();     



//10)n ededinin faktorialini hesablamaq.

//static void FaktorialNums()
//{




//    int n = 7;

//    int res = 1;
//    while (n != 1)
//    {
//        res = res * n;
//        n = n - 1;
//    }
//    Console.WriteLine(res);
//}


//FaktorialNums();    