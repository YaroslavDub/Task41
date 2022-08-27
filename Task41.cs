// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите кол-во элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];
int sum = 0;
for (int count = 0; count < i; count++) {
    Console.WriteLine($"Введите {count + 1} элемент массива");
    array[count] = Convert.ToInt32(Console.ReadLine());
    if (array[count] > 0) {
        sum++; 
    }
}
Console.WriteLine(string.Join (", ", array));
Console.WriteLine($"Колличество выеденных чисел больше 0 = {sum}");