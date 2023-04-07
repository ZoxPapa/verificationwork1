//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] ArrayCreateFill (int size)
{
    string [] array = new string[size];
    for(int i =0; i<size; i++)
    {
        Console.WriteLine($"Input whatever you want {i+1}/{size}: ");
        array[i]= Console.ReadLine();
    }
    return array;
}
// string [] array = ArrayCreateFill(5);
