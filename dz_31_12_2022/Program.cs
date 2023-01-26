#define ZD1
#define ZD2
#define ZD3
#define ZD4
#define ZD5
#define ZD6
#define ZD7

using static System.Console;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Text;
using static System.String;
using System.Runtime.InteropServices;
using System.Data.SqlTypes;

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
#if ZD1
int rows_zd1 = 3;
int collumn_zd1 = 4;
int[] A = new int[5];
double[,] B = new double[rows_zd1, collumn_zd1];
WriteLine("введите 5 чисел через пробел");//string read = Console.ReadLine();
string? str = Console.ReadLine();
string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int sum_A = 0;
int chetn_sum_A = 0;
int max_A = 0; int min_A = 999999999;
long mul_A = 1;
for (int i = 0; i < words.Length; i++)
{
    if (i < A.Length) { A[i] = Convert.ToInt32(words[i]); }
    mul_A *= A[i];
    sum_A += A[i];
    if (i % 2 == 0) { chetn_sum_A += A[i]; }
    if (max_A < A[i]) max_A = A[i];
    if (min_A > A[i]) min_A = A[i];
}
WriteLine();
foreach (int i in A) { Write($"{i} "); }
WriteLine("\n\n\n");
double sum_B = 0;
double max_B = 0; double min_B = 999999999;
double mul_B = 1;
double nehetn_sum_B = 0;
//int value = rand.Next();
for (int i = 0; i < rows_zd1; i++)
{
    for (int k = 0; k < collumn_zd1; k++) { B[i, k] = rand.Next(0, 99) / 10.0; ; }
}

for (int i = 0; i < rows_zd1; i++)
{
    for (int j1 = 0; j1 < collumn_zd1; j1++)
    {
        sum_B += B[i, j1];
        mul_B *= B[i, j1];
        if (max_B < B[i, j1]) max_B = B[i, j1];
        if (min_B > B[i, j1]) min_B = B[i, j1];
        if (!(j1 % 2 == 0)) nehetn_sum_B += B[i, j1];

        Write($"{B[i, j1]} ");
    }
    WriteLine();

}
WriteLine($" общая сумма всех элементов {Convert.ToDouble(sum_A) + sum_B}"); //общую сумму всех элементов
WriteLine($" сумма чётных чисел массива А {chetn_sum_A}");//сумму четных элементов массива А
WriteLine($" сумма не чётных чисел массива В {nehetn_sum_B}");// сумму нечетных столбцов массива В
if (Convert.ToDouble(max_A) > max_B) { WriteLine($" макс число в массиве A {max_A}"); } else { WriteLine($" макс число в массиве B {max_B}"); }//общий максимальный обьект
if (Convert.ToDouble(min_A) < min_B) { WriteLine($" минимальное число в массиве A {min_A}"); } else { WriteLine($" минимальное число в массиве B {min_B}"); }//общий минимальный обьект


WriteLine($" произведение массива A {mul_A}");
WriteLine($" произведение массива B {mul_B}");
WriteLine($" общее произведение массивовa A и B {Convert.ToDouble(mul_A) * mul_B}");//общее произведение всех элементов
#endif



//Задание 2
//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных 
//между минимальным и максимальным элементами.
#if ZD2
int max_arr_2d = 0; int max_count_i = 0; int max_count_j = 0;
int min_arr_2d = 101; int min_count_i = 0; int min_count_j = 0;
int rows_zd2 = 5;
int collumns_zd2 = 5;
int[,] arr_2d = new int[rows_zd2, collumns_zd2];
for (int i = 0; i < rows_zd2; i++)
{
    for (int j2 = 0; j2 < collumns_zd2; j2++) { arr_2d[i, j2] = rand.Next(-100, 100); }
}
for (int i = 0; i < rows_zd2; i++)
{
    for (int j2 = 0; j2 < collumns_zd2; j2++)
    {
        if (max_arr_2d < arr_2d[i, j2]) { max_arr_2d = arr_2d[i, j2]; max_count_i = i; max_count_j = j2; }
        if (min_arr_2d > arr_2d[i, j2]) { min_arr_2d = arr_2d[i, j2]; min_count_i = i; min_count_j = j2; }
        Write($"{arr_2d[i, j2]} ");
    }
    WriteLine();
}
WriteLine($"мин число {min_arr_2d} адресс i:{min_count_i} , j:{min_count_j}");
WriteLine($"мах число {max_arr_2d} адресс i:{max_count_i} , j:{max_count_j}");
int sum = 0;
int start_i, start_j, end_i, end_j;
if (max_count_i > min_count_i) { end_i = max_count_i; end_j = max_count_j; start_i = min_count_i; start_j = min_count_j; }
else { end_i = min_count_i; end_j = min_count_j; start_i = max_count_i; start_j = max_count_j; }
if (max_count_i == min_count_i)
{
    if (max_count_j > min_count_j) { end_i = max_count_i; end_j = max_count_j; start_i = min_count_i; start_j = min_count_j; }
    else { end_i = min_count_i; end_j = min_count_j; start_i = max_count_i; start_j = max_count_j; }
}
WriteLine($"старт {start_i} ,{start_j}");
WriteLine($"стоп {end_i} ,{end_j}");
int stop = collumns_zd2;
int jj = start_j + 1;
for (int i = start_i; i <= end_i; i++)
{
    if (i == end_i) { stop = end_j; }
    if (i != start_i || i > start_i) jj = 0;
    for (; jj < stop; jj++)
    {
        sum = sum + arr_2d[i, jj];
    }
}
WriteLine(sum);
#endif
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
#if ZD3
WriteLine("Введите текст, который хотите зашифровавать:"); string? text = ReadLine();
WriteLine("Укажите ключ: "); int key = Convert.ToInt32(ReadLine());

//char[] char_dictionary_lower_ru = {'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
//char[] char_dictionary_upper_ru = {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
char[] char_dictionary_lower_en = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
//char[] char_dictionary_upper_en = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

char[] cipher = text.ToCharArray();
int x = key;
int j;
int language = 0;
int upper = 0;
for (int i = 0; i < text.Length; i++)
{
    for (j = 0; j < char_dictionary_lower_en.Length; j++)
    {
        if (text[i] == char_dictionary_lower_en[j]) { language = 1; upper = 0; break; }
    }
    if (j != 26)
    {
        x = j + key;
        if (x > 25) x = x - 26;
        cipher[i] = char_dictionary_lower_en[x];
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
//char[] revers = s.ToCharArray();


char[] revers = s.ToCharArray();
for (int i = 0; i < s.Length; i++)
{
    for (j = 0; j < char_dictionary_lower_en.Length; j++)
    {
        if (s[i] == char_dictionary_lower_en[j]) { /*WriteLine(j);*/ break; }
    }
    if (j != 26)
    {
        x = j - key;//x будет отрицательное число
        if (x < 0) { x = 26 + x; }// 
        revers[i] = char_dictionary_lower_en[x];
    }
}
string rs = new string(revers);
WriteLine(rs);

#endif


/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 4
//Создайте приложение, которое производит операции 
//над матрицами:
//■ Умножение матрицы на число;
//■ Сложение матриц;
//■ Произведение матриц.
#if ZD4
const int SIZE_MATRICI = 2;
//int tablica_3_na_3[][3]{{1,2,-1},{3,-1,-1},{-2,2,3}};
const int SIZE_MATRICI_COL_A = 3;
const int SIZE_MATRICI_ROW_A = 2;
const int SIZE_MATRICI_COL_B = 2;
const int SIZE_MATRICI_ROW_B = 3;
const int SIZE_MATRICI_COL_C = 3;
const int SIZE_MATRICI_ROW_C = 3;

int[,] matrica_A_rand = new int[SIZE_MATRICI_COL_A, SIZE_MATRICI_ROW_A];//{ {1, 2}, {3, 4}, {5, 6} };
int[,] matrica_B_rand = new int[SIZE_MATRICI_COL_B, SIZE_MATRICI_ROW_B];// { {1, 2, 3}, { 4, 5, 6 } };
int[,] matrica_C = new int[SIZE_MATRICI_COL_A, SIZE_MATRICI_ROW_B];

for (int i = 0; i < SIZE_MATRICI_COL_A; i++) { for (int j4 = 0; j4 < SIZE_MATRICI_ROW_A; j4++) { matrica_A_rand[i, j4] = rand.Next(0, 21); } }//инициализация массива 1
for (int i = 0; i < SIZE_MATRICI_COL_B; i++) { for (int j4 = 0; j4 < SIZE_MATRICI_ROW_B; j4++) { matrica_B_rand[i, j4] = rand.Next(0, 99); } }//инициализация массива 2
                                                                                                                                              //for (int i = 0; i < SIZE_MATRICI_COL_A; i++) { for (int j = 0; j < SIZE_MATRICI_ROW_B; j++) { matrica_C[i,j] = 0; } }

for (int i = 0; i < SIZE_MATRICI_COL_A; i++)
{
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_A; j4++) { Write($"   {matrica_A_rand[i, j4]} "); }
    WriteLine();
}
WriteLine();//вывод на экран массива 1

for (int i = 0; i < SIZE_MATRICI_COL_B; i++)
{
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_B; j4++) { Write($"   {matrica_B_rand[i, j4]} "); }
    WriteLine();
}
WriteLine();//вывод на экран массива 2


//#########################################################################################################################
WriteLine("Уможение матриц друг на друга ");//матрицы должны быть противоположными по колличеству столбцов и строк
for (int i = 0; i < SIZE_MATRICI_COL_A; i++)
{//получаем доступ к ячейкам  матрицы С// умножение матриц
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_B; j4++)
    {
        for (int k = 0; k < SIZE_MATRICI_ROW_A; k++)
        {
            matrica_C[i, j4] += matrica_A_rand[i, k] * matrica_B_rand[k, j4];
        }
    }
}
for (int i = 0; i < SIZE_MATRICI_COL_A; i++)
{
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_B; j4++) { Write($"   {matrica_C[i, j4]} "); }
    WriteLine();
}
WriteLine();
//#########################################################################################################################
//#########################################################################################################################
WriteLine("Сложение матриц ");//матрицы должны быть одинаковыми по колличеству столбцов и строк
int[,] matrica_A = new int[SIZE_MATRICI, SIZE_MATRICI];//{ {1, 2}, {3, 4}, {5, 6} };
int[,] matrica_B = new int[SIZE_MATRICI, SIZE_MATRICI];// { {1, 2, 3}, { 4, 5, 6 } };
int[,] matrica_D = new int[SIZE_MATRICI, SIZE_MATRICI];// { {1, 2, 3}, { 4, 5, 6 } };
for (int i = 0; i < SIZE_MATRICI; i++) { for (int j4 = 0; j4 < SIZE_MATRICI; j4++) { matrica_A[i, j4] = rand.Next(0, 21); } }//инициализация массива 1
for (int i = 0; i < SIZE_MATRICI; i++) { for (int j4 = 0; j4 < SIZE_MATRICI; j4++) { matrica_B[i, j4] = rand.Next(0, 99); } }//инициализация массива 2
for (int i = 0; i < SIZE_MATRICI; i++) { for (int j4 = 0; j4 < SIZE_MATRICI; j4++) { Write($"   {matrica_A[i, j4]} "); } WriteLine(); }
WriteLine();//вывод на экран массива 1
for (int i = 0; i < SIZE_MATRICI; i++) { for (int j4 = 0; j4 < SIZE_MATRICI; j4++) { Write($"   {matrica_B[i, j4]} "); } WriteLine(); }
WriteLine();//вывод на экран массива 2
for (int i = 0; i < SIZE_MATRICI; i++)
{//получаем доступ к ячейкам  матрицы С// сложение матриц
    for (int j4 = 0; j4 < SIZE_MATRICI; j4++)
    {
        matrica_D[i, j4] = matrica_A[i, j4] + matrica_B[i, j4];
    }
}

for (int i = 0; i < SIZE_MATRICI; i++) { for (int j4 = 0; j4 < SIZE_MATRICI; j4++) { Write($"   {matrica_D[i, j4]} "); } WriteLine(); }
WriteLine();//вывод на экран массива 3

//#########################################################################################################################
//#########################################################################################################################
WriteLine("Умножение матрицы на число ");
for (int i = 0; i < SIZE_MATRICI_COL_A; i++)
{//получаем доступ к ячейкам  матрицы С// умножение матрицы на число
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_A; j4++)
    {
        matrica_A_rand[i, j4] *= 2;
    }
}

for (int i = 0; i < SIZE_MATRICI_COL_A; i++)
{
    for (int j4 = 0; j4 < SIZE_MATRICI_ROW_A; j4++) { Write($"   {matrica_A_rand[i, j4]} "); }
    WriteLine();
}
WriteLine();
//#########################################################################################################################           
#endif


/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 5
//Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
//его результат.Необходимо поддерживать только две
//операции: + и –.
#if ZD5
WriteLine("Введите выражение:");
string? operation = ReadLine();
char[] delimiterChars = { '+', '-', '*', ',', ' ' };
char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' };
string[] xz = operation.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
string[] xt = operation.Split(delimiterInt, StringSplitOptions.RemoveEmptyEntries);
double Left = Convert.ToDouble(xz[0]);
char operators = Convert.ToChar(xt[0]);
double Right = Convert.ToDouble(xz[1]);
double otvet = 0;
switch (operators)
{
    case '+': otvet = Left + Right; break;
    case '-': otvet = Left - Right; break;
    case '*': otvet = Left * Right; break;
    case '/': otvet = Left / Right; break;
    default:
        break;
}
WriteLine($"{Left}{operators}{Right}={otvet}");
WriteLine();
#endif

/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good
//day for walking.i will try to walk near the sea».
//Результат работы приложения: «Today is a good day
//for walking.I will try to walk near the sea».
#if ZD6
string stroka = "«today is a good day for walking.i will try to walk near the sea».";
//WriteLine(stroka);
char[] delimiterCharss = { '.', '!', '?' };
string[] podstroki = stroka.Split(delimiterCharss); //string[] podstroki = stroka.Split(delimiterCharss, StringSplitOptions.RemoveEmptyEntries);
for (int j6 = 0; j6 < podstroki.Length; j6++)
{
    char[] char_str = podstroki[j6].ToCharArray();
    for (int i = 0; i < char_str.Length - 1; i++)
    {
        char c = char_str[i];
        int xvx = Convert.ToInt32(c);
        if ((xvx >= 97 && xvx <= 122))// || (x >= 65 && x <= 91) || x == 32)
        {
            xvx = xvx - 32;
            c = (char)xvx;
            char_str[i] = c;
            podstroki[j6] = new string(char_str);
            break;
        }
    }
}
stroka = string.Join(".", podstroki);
WriteLine(stroka);

//foreach (var word in stroka){Write(word);}
WriteLine();
#endif

/////////////////////////////////////////////////////////////////////////////////////////////////////
//Задание 7
//Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
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
//string text =
//"To be, or not to be, that is the question,\n" +
//"Whether 'tis nobler in the mind to suffer\n" +
//"The slings and arrows of outrageous fortune,\n" +
//"Or to take arms against a sea of troubles,\n" +
//"And by opposing end them? To die: to sleep;\n" +
//"No more; and by a sleep to say we end\n" +
//"The heart-ache and the thousand natural shocks\n" +
//"That flesh is heir to, 'tis a consummation\n" +
//"Devoutly to be wish'd. To die, to sleep";
#if ZD7

string text7 =
"To be, or not to be, that is the question,\n" +
"Whether die 'tis nobler in the mind to suffer\n" +
"The die slings and arrows die of outrageous fortune,\n" +
"Or die to take arms against a sea of troubles,\n" +
"And by opposing end them? To die: to sleep;\n" +
"No die more; and by a die sleep to say we end\n" +
"The heart-ache and the thousand natural shocks\n" +
"That flesh is heir to, 'tis a consummation\n" +
"Devoutly to be wish'd. To die, to sleep";

string substring = "die";
int lengthSubstring = substring.Length;
string zamena = "";
for (int i = 0; i < lengthSubstring; i++) { zamena += '*'; }
int indexOfsubstring = 0;
int count = 0;

while (true)
{
    indexOfsubstring = text7.IndexOf(substring);
    if (indexOfsubstring != -1)
    {
        count++;
        text7 = text7.Remove(indexOfsubstring, lengthSubstring);
        text7 = text7.Insert(indexOfsubstring, zamena);
    }
    else { break; }
}
WriteLine($"Недопустимое слово: {substring}");
WriteLine("Результат работы:");
WriteLine(text7);
WriteLine($"Статистика: {count} замены слова {substring}");
#endif