// // Метод 1. Не возвращают. Не принимают.
// void Method1()
// {
//     Console.WriteLine("Автор - Павлик");
// }


// Method1(); // вызов метода



// // Метод 2. Не возвращают. Могут принимать.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Этот текст.");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Новый текст.", 4);
// Method21(msg: "Другой текст.", count: 4);
// Method21(count:3, msg: "Еще один текст.");



// // Метод 3. Возвращают. Не принимают.

//  int Method3()   // если метод возвращает - обязательно указываетс тип данных, который ожидаем от этого метода.
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// Метод 4. Принимают. Возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Текст.");
// Console.WriteLine(res);



// // Цикл For
// for (int i = 0; i <10; i++)
// {
//     Console.WriteLine(i);
// }

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "Текст.");
// Console.WriteLine(res);



// // вывод талицы умножения
// // (цикл в цикле)
// for (int i = 2; i <=10; i++)
// {
//     for (int j = 2; j <10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }



// // Заменить в тексте пробелы вертикальными черточками, 
// //маленькие к большими К, большие В на маленькие в.

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s =  "qwerty"
// //              0123456
// // s[3] - r
// Console.WriteLine(text);
// Console.WriteLine();
// string Replace(string text, char oldSymb, char newSymb)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i =0; i < length; i++)
//     {
//         if (text[i] == oldSymb)
//         {
//             result=result+$"{newSymb}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         }
//     }
//     return result;
// }
// string newText = Replace(text,' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'В', 'в');
// Console.WriteLine(newText);
// Console.WriteLine();



// // упорядочивание массива
// // выбрать самый первый, найти минимальный, 
// // поменять местами, выбрать первый в оставшейся части,
// // выбрать минимальный в оставшейся части
// // поменять метсами, повторять до конца массива.
// int[] arr = { 1, 4, 7, 9, 3, 2, 6, 7, 4, 6, 8 };
// void PrintArr(int[] arr)
// {
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// void selectionSort(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//     int minPos = i;
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[j] < arr[minPos])
//         {
//             minPos = j;
//         }
//     }
//     int temp = arr[i];
//     arr[i] = arr[minPos];
//     arr[minPos] = temp;
//     }
// }
// PrintArr (arr);
// selectionSort(arr);
// PrintArr(arr);
