//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ArrayCreateFill(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input whatever you want {i + 1}/{size}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
// string [] array = ArrayCreateFill(5);

string[] ArrayMembersSelectionBySize(string[] array, int size)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
            result += array[i] + ",";
    }
    string[] resultArray = result.Split(",");
    return resultArray;
}

void Main()
{
    Console.WriteLine("Input how many members will be in array: ");
    int sizeOfArray = Convert.ToInt32(Console.ReadLine());

    //Creating an array. User input each member by console.
    string[] array = ArrayCreateFill(sizeOfArray); 

    Console.WriteLine("Input maximum quantity of chars. We will select all members of array with this condition.");
    int sizeOfMember = Convert.ToInt32(Console.ReadLine());

    //Creating new array, filling it by conditional members from first array.
    string[] resultArray = ArrayMembersSelectionBySize(array, sizeOfMember);

    //Output new array
    Console.WriteLine("Result: " + String.Join(" ", resultArray));

}

Main();