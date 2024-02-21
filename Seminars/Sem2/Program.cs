// void numToQuad(int num)
// {
//     System.Console.WriteLine(num * num);
// }


// int numToQuad(int num)
// {
//     return num * num;
// }


// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру 
// этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81

// void deleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         System.Console.WriteLine($"{num} -> {num/100 * 10 + num % 10}");
//     }
//     else 
//     {
//         System.Console.WriteLine("Youu input not 3 digit num");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// deleteSecondDigit(number);


// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого 
// числа в степень, равную третьей цифре.
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// double secondTOThitd(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         return Math.Pow(dec, ed);
//     }
//     return 0;
// }
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(secondTOThitd(number));

// double secondTOThitd(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     return 0;
// }
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(secondTOThitd(number));


// Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли первое число 
// кратным второму. Если первое число некратно 
// второму, то программа выводит остаток от деления.
// 14, 5 => нет, 
// 4 16, 8 => да
// 4, 3 => нет, 1

// void abc(int num_1, int num_2)
// {
//     if (num_1 % num_2 == 0)
//     {
//         System.Console.WriteLine("=> да");
//     }
//     else
//     {
//         System.Console.WriteLine($"нет {num_1 % num_2}");
//     }
// }
// System.Console.WriteLine("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input first number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// abc(number_1, number_2);
