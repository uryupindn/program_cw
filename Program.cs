using System;
using static System.Console;

WriteLine("Введите элементы массива через пробел: ");
string[] array=GetArrayFromString(ReadLine());
WriteLine($"[{string.Join(", ", array)}]");
string[] answerarray=CheckElements(array);
WriteLine($"[{string.Join(", ", answerarray)}]");

string[] GetArrayFromString(string array) //1) задаем функцию, которая инициализирует массив из строки
{
    string[] arS=array.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    string[] result=new string[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=Convert.ToString(arS[i]);
    }
    return result;