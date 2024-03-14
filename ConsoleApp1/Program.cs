// 1.Verilmish ededin mertebelerinin en boyuyunu tapan alqoritm Misal: input 7481, output 8

//int num = 7481;
//int count = 0;  
//for (int i = 0; i < num; i++)
//{
//    int eded = num % 10;
//    if (eded > count)
//    {
//        count = eded;
//    }
//    num /= 10;
//}
//Console.WriteLine(count);




// 2.Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm Misal: input 8 output 2-in quvvetidir ve ya input 9 2-in quvveti deyil
//int num = 6;
//if (num == 0)
//{
//    Console.WriteLine("2 in quvetidir");
//}
//while (num > 0)
//{
//    if (num %2 != 0)
//    {
//        Console.WriteLine("2 nin quveti deil");
//        break;
//    }
//    num = num / 2;
//    if (num %2 ==0)
//    {
//        Console.WriteLine("2 nin quvetidir");
//        break;
//    }
//}





// 3.Verilmish arrayda en kicik ve en boyuk ededlerin cemini cixaran alogirthm

//int[] arr = { 17, 4, 12, 53, 5 };
//int max = arr[0];
//int min = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]>max)
//    {
//        max = arr[i];
//    }
//    if (arr[i]<min)
//    {
//        min = arr[i];
//    }
//}
//Console.WriteLine(max +min);






// 4..Verilmish arrayda hem tek eded olan hemde 3-e bolunen ededlerin sayini cixaran algorithm


//int[] arr = { 5, 15, 21, 24, 27, 6 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 3 == 0 && arr[i] % 2 != 0)
//    {
//        Console.WriteLine(arr[i]);
//    }
//}





// 5.Verilmish arrayda murekkeb ededlerin sayini cixaran algorithm misal:input {5,9,12,11} output 2

//int[] arr = { 5, 9, 12, 11 };
//int count = 0;
//for (int i = 1; i < arr.Length; i++)
//{
//    for (int j = 2; j < arr[i]; j++)
//    {
//        if (arr[i] % j == 0)
//        {
//            count++;
//            break;
//        }
//    }
//}
//Console.WriteLine(count);