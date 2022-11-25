/*Написать программу, которая из имеющегося массива строк сформирует массивиз строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами. */
string[] array= {"Name","Age","Adress","2342","-2", "@"};
void PrintArray (string[]array)
{
  if (array.Length>0)  
  { for (int i = 0; i < array.Length-1; i++)
    {
      Console.Write($"{array[i]}, ");
    }
  Console.Write($"{array[array.Length-1]}");
  }
  else Console.Write("");
}
string[] CreateArrayFromSelectedElements (string[]array)
{
  string[]newArray=new string[0];
  for (int i = 0; i < array.Length; i++)
{
  //int length = array[i].Length; 

  if (array[i].Length<=3)
  {
    Array.Resize(ref newArray, newArray.Length + 1);
    newArray[newArray.Length - 1] = array[i];
  }
}
return newArray;
}

Console.Write("[");
PrintArray(array);
Console.Write("] -> [");
string[]resultArray=CreateArrayFromSelectedElements(array);
PrintArray(resultArray);
Console.Write("]");
