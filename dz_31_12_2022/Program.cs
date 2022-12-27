using static System.Console;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Text;
using static System.String;
using System.Runtime.InteropServices;

var rand = new Random();
//Задание 1
//Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив 
//А числами, введенными с клавиатуры пользователем, а 
//двумерный массив В случайными числами с помощью 
//циклов. Вывести на экран значения массивов: массива
//А в одну строку, массива В — в виде матрицы. Найти в 
//данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее 
//произведение всех элементов, сумму четных элементов 
//массива А, сумму нечетных столбцов массива В.
/////////////////////////////////////////////////////////////////////////////////////////////////////
//int rows = 3;
//int collumn = 4;
//int[] A = new int[5];
//double[,] B = new double[rows,collumn];
//WriteLine("введите 5 чисел через пробел");//string read = Console.ReadLine();
//string? str = Console.ReadLine();
//string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int sum_A = 0;
//int chetn_sum_A = 0;
//int max_A = 0;int min_A = 999999999;
//long mul_A = 1;
//for (int i = 0; i < words.Length; i++)
//{
//    if (i < A.Length) { A[i] = Convert.ToInt32(words[i]); }
//    mul_A *= A[i];
//    sum_A+=A[i];
//    if (i % 2 == 0) { chetn_sum_A += A[i]; }
//    if (max_A< A[i] )max_A= A[i];
//    if (min_A > A[i] )min_A= A[i];
//}
//WriteLine();
//foreach (int i in A) { Write($"{i} "); }
//WriteLine("\n\n\n");
//double sum_B =0;
//double max_B = 0; double min_B = 999999999;
//double mul_B = 1;
//double nehetn_sum_B = 0;
////int value = rand.Next();
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < collumn; j++) { B[i, j] = rand.Next(0, 99)/10.0; ; }
//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < collumn; j++) {
//        sum_B += B[i, j];
//        mul_B *= B[i,j];
//        if (max_B < B[i, j]) max_B = B[i, j];
//        if (min_B > B[i, j]) min_B = B[i, j];
//        if (!(j % 2 == 0)) nehetn_sum_B += B[i, j];

//        Write($"{B[i, j]} "); 
//    }
//    WriteLine();

//}
//WriteLine($" общая сумма всех элементов {Convert.ToDouble(sum_A) +sum_B}"); //общую сумму всех элементов
//WriteLine($" сумма чётных чисел массива А {chetn_sum_A}");//сумму четных элементов массива А
//WriteLine($" сумма не чётных чисел массива В {nehetn_sum_B}");// сумму нечетных столбцов массива В
//if (Convert.ToDouble(max_A) > max_B) { WriteLine($" макс число в массиве A {max_A}"); } else { WriteLine($" макс число в массиве B {max_B}"); }//общий максимальный обьект
//if (Convert.ToDouble(min_A) < min_B) { WriteLine($" минимальное число в массиве A {min_A}"); } else { WriteLine($" минимальное число в массиве B {min_B}"); }//общий минимальный обьект


//WriteLine($" произведение массива A {mul_A}");
//WriteLine($" произведение массива B {mul_B}");
//WriteLine($" общее произведение массивовa A и B {Convert.ToDouble(mul_A) *mul_B}");//общее произведение всех элементов




//Задание 2
//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных 
//между минимальным и максимальным элементами.
//int max_arr_2d = 0;   int max_count_i = 0; int max_count_j = 0;
//int min_arr_2d = 101; int min_count_i = 0; int min_count_j = 0;
//int rows = 5;
//int collumns = 5;
//int[,] arr_2d = new int[rows, collumns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < collumns; j++) { arr_2d[i, j] = rand.Next(-100, 100) ; }
//}
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < collumns; j++)
//    {
//        if (max_arr_2d < arr_2d[i, j]) { max_arr_2d = arr_2d[i, j]; max_count_i = i; max_count_j = j; }
//        if (min_arr_2d > arr_2d[i, j]) { min_arr_2d = arr_2d[i, j]; min_count_i = i; min_count_j = j; }
//        Write($"{arr_2d[i, j]} ");
//    }
//    WriteLine();
//}
//WriteLine($"мин число {min_arr_2d} адресс i:{min_count_i} , j:{min_count_j}");
//WriteLine($"мах число {max_arr_2d} адресс i:{max_count_i} , j:{max_count_j}");
//int sum = 0;
//int start_i,start_j,end_i ,end_j;
//if (max_count_i > min_count_i) { end_i = max_count_i; end_j = max_count_j; start_i = min_count_i; start_j = min_count_j; } 
//else                           { end_i = min_count_i; end_j = min_count_j; start_i = max_count_i; start_j = max_count_j; }
//if (max_count_i == min_count_i) {
//    if (max_count_j > min_count_j)  { end_i = max_count_i; end_j = max_count_j; start_i = min_count_i; start_j = min_count_j; }
//    else                            { end_i = min_count_i; end_j = min_count_j; start_i = max_count_i; start_j = max_count_j; }
//    }
//WriteLine($"старт {start_i} ,{start_j}");
//WriteLine($"стоп {end_i} ,{end_j}");
//int stop = collumns;
//int jj = start_j+1;
//for (int i = start_i; i <= end_i; i++)
//{
//    if (i == end_i) {stop = end_j; }
//    if(i!=start_i||i>start_i)jj=0; 
//    for(; jj < stop; jj++)
//    {
//        sum = sum + arr_2d[i, jj];
//    }
//}
//WriteLine(sum);

/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 3
//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
//Из Википедии:
//Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
//символом, находящимся на некотором постоянном числе 
//позиций левее или правее него в алфавите. Например,
//в шифре со сдвигом вправо на 3, A была бы заменена на 
//D, B станет E, и так далее.
//Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
//Кроме механизма шифровки, реализуйте механизм 
//расшифрования.
WriteLine("Введите текст, который хотите зашифровавать:"); string? text = ReadLine();
WriteLine("Укажите ключ: "); int key = Convert.ToInt32(ReadLine());
string lower_ru = "а б в г д е ё ж з и й к л м н о п р с т у ф х ц ч ш щ ъ ы ь э ю я";
string upper_ru = "А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
string lower_en = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
string upper_en = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
string[] dictionary_lower_ru = lower_ru.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] dictionary_upper_ru = upper_ru.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] dictionary_lower_en = lower_en.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] dictionary_upper_en = upper_en.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

char[] char_dictionary_lower_ru = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
//foreach(string i in dictionary_lower_ru){ Write($"{i} "); }WriteLine();
//foreach(string i in dictionary_upper_ru){ Write($"{i} "); }WriteLine();
//foreach(string i in dictionary_lower_en){ Write($"{i} "); }WriteLine();
//foreach(string i in dictionary_upper_en){ Write($"{i} "); }WriteLine();
char[] cipher = text.ToCharArray();
int x = key;
int j;
for (int i = 0; i < text.Length; i++){
    for (j = 0; j < char_dictionary_lower_ru.Length; j++){
        if (text[i] == char_dictionary_lower_ru[j]) { break; }
    }
    if (j != 26){
        x = j + key;
        if (x > 25) x = x - 26;
        cipher[i] = char_dictionary_lower_ru[x];
    }
}
string s = new string(cipher);
WriteLine(s);
/////////////////////////////////////////////////////////////////////////////////////////////////////
///         abrakadabra ebushki vorobushki wota fack
//string s = "noenxnqnoen rohfuxv ibebohfuxv jbgn snpx";//key = 13;
//int key = 3;
//int j;
//int x = key;
char[] revers = s.ToCharArray();
for (int i = 0;i<s.Length ;i++ ) {
    for (j = 0; j < char_dictionary_lower_ru.Length; j++){
        if (s[i] == char_dictionary_lower_ru[j]) { /*WriteLine(j);*/ break; }
    }
    if (j != 26){
        x = j - key;//x будет отрицательное число
        if (x < 0){  x = 26 + x ;}//
        revers[i] = char_dictionary_lower_ru[x];
    }
}
string rs = new string(revers);
WriteLine(rs);
/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 4
//Создайте приложение, которое производит операции 
//над матрицами:
//■ Умножение матрицы на число;
//■ Сложение матриц;
//■ Произведение матриц.






/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 5
//Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
//его результат.Необходимо поддерживать только две
//операции: + и –.





/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good
//day for walking.i will try to walk near the sea».
//Результат работы приложения: «Today is a good day
//for walking.I will try to walk near the sea».


/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 7
//Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
//должно быть заменено на набор символов*. По итогам
//работы приложения необходимо показать статистику
//действий. 
//Например, если и у нас есть такой текст:
//To be, or not to be, that is the question,
//Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune,
//Or to take arms against a sea of troubles,
//And by opposing end them? To die: to sleep;
//No more; and by a sleep to say we end
//The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation
//Devoutly to be wish'd. To die, to sleep
//Недопустимое слово: die.
//Результат работы:
//To be, or not to be, that is the question,
//Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune,
//Or to take arms against a sea of troubles,
//And by opposing end them? To ***: to sleep;
//No more; and by a sleep to say we end
//The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation
//Devoutly to be wish'd. To ***, to sleep.
//Статистика: 2 замены слова die