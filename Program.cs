// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)


int[] Array = {1,3,5,9,7,8}; 
int x;

void PrintArray (int[] ArrayForPrint)
{
for (int i = 0; i < ArrayForPrint.Length; i++)
   {
    System.Console.Write(ArrayForPrint[i] + " ");
   }
}

int[] Perevernut (int[] ArrayForPerevernut)
{
for (int i = 0; i < ArrayForPerevernut.Length; i++)
   {
    x = ArrayForPerevernut[i];
    ArrayForPerevernut[i] = ArrayForPerevernut[ArrayForPerevernut.Length-1-i];
    ArrayForPerevernut[ArrayForPerevernut.Length-1-i] = x;
    return ArrayForPerevernut;
   }
}

void ItogPrintArray (int[] ItogArrayForPrint)
{
for (int i = 0; i < ItogArrayForPrint.Length; i++)
   {
    System.Console.Write(ItogArrayForPrint[i] + " ");
   }
}

PrintArray (Array);
Perevernut (Array);
ItogPrintArray (Array);