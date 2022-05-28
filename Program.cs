
/*
Знакомство с языками программирования (семинары)
Урок 10. Рекурсия продолжение
Задача 1: Задайте массив строк. Напишите программу, 
считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/
/*
string [] a = {"qwe", "wer", "ert", "rty", "tyu", "yui", "uio", "asd"};
int count = 0;
for (int i = 0; i < a.Length; i++)
{
    if(a[i][0] == 'e' || a[i][0] == 'i' || a[i][0] == 'o' || a[i][0] == 'u' ||
            a[i][0] == 'y' || a[i][0] == 'a') count += 1;
    Console.Write(a[i] + "," + " ");
}
Console.WriteLine(" -> " + count);

*/
/*
Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
// объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/
string[] words = {"qwe", "wer", "ert", "rty", "tyu", "yui", "uio", "asd"};
int i = 0; int k = 0;
string[] stringArray = new string[4];
while (i < words.Length)
{
    stringArray[k] = words[i] + words[i + 1];
    Console.Write(stringArray[k] + "," + " ");
    i += 2; k += 1;
}
Console.WriteLine();