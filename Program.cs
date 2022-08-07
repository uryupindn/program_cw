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
string[] CheckElements(string[] array) //2) задаем функцию, которая проверяет массив по условию задачи и формирует новый массив, которые состоит из элементов, которые удовл условию задачи
{
    int index=0;
    int n=3;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length<=n)
        {
        index++;
        }
    }