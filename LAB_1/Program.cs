using System;

public class Program
{
    int x, y, z;
    char str;
    string? ned;
    int[] arr;
    bool prov;

    //МЕТОДЫ
    public int sumLastNums(int x)
    {
        int a = Math.Abs(x);
        return a % 10 + (a / 10) % 10;
    }
    public bool isPositive(int x)
    {
        return x > 0; //возвратит true, если число положительное
    }
    public bool isDivisor(int a, int b)
    {
        return ((a % b) == 0 || (b % a) == 0); //возвратит true, если числа делятся друг на друга целочисленно
    }
    public bool isUpperCase(char x)
    {
        return Char.IsUpper(x);
    }
    public int lastNumSum(int a, int b)
    {
        if (a < 10 & b > 9)
        {
            int c = b % 10;
            return a + c;
        }
        if (a > 9 & b < 10)
        {
            int c = a % 10;
            return c + b;
        }
        if (a > 9 & b > 9)
        {
            int c = a % 10;
            int v = b % 10;
            return c + v;
        }
        return a + b;
    }
    //УСЛОВИЯ
    public double safeDiv(int x, int y)
    {
        if (y > 0) return (double)x / y;
        return 0;
    }
    public String makeDecision(int x, int y)
    {
        if (x > y) return " > ";
        if (x < y) return " < ";
        return " == ";
    }
    public bool sum3(int x, int y, int z)
    {
        if (x + y == z) return true;
        if (x + z == y) return true;
        if (z + y == x) return true;
        return false;
    }
    public String age(int x)
    {
        int d = x % 10;
        int s = x % 100;
        if (d == 1 && x != 11) return " год";
        else if ((d >= 2 && d <= 4) || (s < 12 && s > 14)) return " года";
        return " лет";
    }
    public void printDays(String x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }
    //ЦИКЛЫ
    public String reverseListNums(int x)
    {
        string[] num = new string[x + 1]; //создали массив для добавления в строку чисел
        for (int i = 0; i <= x; i++)
        {
            num[i] = (x - i).ToString(); //добавляем числа в строку
        }
        return string.Join(" ", num);
    }
    public int pow(int x, int y)
    {
        int b = 1;
        for (int i = 1; i <= y; i++) //пока i не станет равным y, число будет умножаться само на себя
        {
            b *= x;
        }
        return b;
    }
    public bool equalNum(int x)
    {
        x = Math.Abs(x); // для работы с положительными числами
        int num = x % 10;
        x /= 10;
        while (x > 0)
        {
            if (num != x % 10)
                return false;
            x /= 10;
        }
        return true;
    }
    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public void guessGame()
    {
        Random random = new Random();
        int y = random.Next(0, 10);
        Console.Write("Введите число от 0 до 9 -> ");
        int x = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        while (x != y)
        {
            Console.Write("Вы не угадали, введите число от 0 до 9 -> ");
            x = Convert.ToInt32(Console.ReadLine());
            c++;
        }
        Console.WriteLine("Вы угадали!");
        Console.Write("Вы отгадали число с " + c + " попытки");
    }

    //МАССИВЫ
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    public int[] add(int[] arr, int x, int pos)
    {
        int[] new_arr = new int[arr.Length + 1];
        for (int i = 0; i <= arr.Length; i++)
        {
            if (i == pos) new_arr[i] = x;
            else if (i > pos) new_arr[i] = arr[i - 1];
            else new_arr[i] = arr[i];
        }
        return new_arr;
    }
    public void reverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) { Console.Write(arr[i] + " "); }
    }
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] arr12 = arr1.Concat(arr2).ToArray(); //последовательное объединение двух массивов в один
        return arr12;
    }
    public int[] deleteNegative(int[] arr)
    {
        int[] new_arr = arr.Where(x => x >= 0).ToArray(); //фильтруем исходный массив и преобразуем обратно в массив (х - каждый эллемент массива)
        return new_arr;
    }
    public static void Main()
    {
        var res = new Program();
        Console.Write("Введите номер задачи (от 1 до 20) -> ");
        int m = Convert.ToInt32(Console.ReadLine());
        while (!Enumerable.Range(1, 100).Contains(m))
        {
            Console.Write("Ошибка ввода! Нужно ввести число от 1 до 20 ->");
            m = Convert.ToInt32(Console.ReadLine());
        }
        //МЕТОДЫ
        if (m == 1)
        {
            Console.Write("Введите число не менее двух знаков -> ");
            res.x = Convert.ToInt32(Console.ReadLine());
            int k = Math.Abs(res.x);
            while (k < 10)
            {
                Console.Write("Введите число не менее двух знаков -> ");
                res.x = Convert.ToInt32(Console.ReadLine());
                k = Math.Abs(res.x);
            }
            Console.WriteLine("Сумма двух последних знаков числа {0} равна {1}", res.x, res.sumLastNums(res.x));
        }
        if (m == 2)
        {
            Console.Write("Введите число -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine(res.isPositive(res.x));
        }
        if (m == 3)
        {
            Console.Write("Введите букву -> ");
            res.str = Console.ReadLine()[0];
            Console.WriteLine(res.isUpperCase(res.str));
        }
        if (m == 4)
        {
            Console.Write("Введите число a -> ");
            res.x = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число b -> ");
            res.y = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine(res.isDivisor(res.x, res.y));
        }
        if (m == 5)
        {
            int i = 0;
            Console.Write("Введите число a -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            while (i < 4)
            {
                Console.Write("Введите число b -> ");
                while (!int.TryParse(Console.ReadLine(), out res.y))
                {
                    Console.WriteLine("Ошибка ввода! Введите число -> ");
                }
                i++;
                Console.WriteLine("{0} + {1} это " + res.lastNumSum(res.x, res.y), res.x, res.y);
                res.x = res.lastNumSum(res.x, res.y);
            }
            Console.Write("Введите число b -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine("Итого: " + res.lastNumSum(res.x, res.y));
        }
        //УСЛОВИЯ
        if (m == 6)
        {
            Console.Write("Введите число х (делимое) -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число у (делитель) -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine("результат: " + res.safeDiv(res.x, res.y));
        }
        if (m == 7)
        {
            Console.Write("Введите число х -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число у -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine("результат: " + res.x + res.makeDecision(res.x, res.y) + res.y);
        }
        if (m == 8)
        {
            Console.Write("Введите число х -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число у -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число z -> ");
            while (!int.TryParse(Console.ReadLine(), out res.z))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine("результат: " + res.sum3(res.x, res.y, res.z));
        }
        if (m == 9)
        {
            Console.Write("Введите число х -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine("результат: " + res.x + res.age(res.x));
        }
        if (m == 10)
        {
            Console.Write("Введите день недели -> ");
            res.ned = Console.ReadLine();
            res.printDays(res.ned);
        }
        //ЦИКЛЫ
        if (m == 11)
        {
            Console.Write("Введите число -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write(res.reverseListNums(res.x));
        }
        if (m == 12)
        {
            Console.Write("Введите число х -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите число у -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write(res.pow(res.x, res.y));
        }
        if (m == 13)
        {
            Console.Write("Введите число -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write(res.equalNum(res.x));
        }
        if (m == 14)
        {
            Console.Write("Введите высоту треугольника -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            res.leftTriangle(res.x);
        }
        if (m == 15)
        {
            res.guessGame();
        }
        //МАССИВ
        if (m == 16)
        {
            Console.Write("Введите кол-во чисел в массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Random random = new Random();
            int[] arr = new int[res.x];
            for (int i = 0; i < res.x; i++)
            {
                arr[i] = random.Next(1, 11);
            }
            for (int i = 0; i < res.x; i++) { Console.Write(arr[i] + " "); }
            Console.WriteLine();
            Console.Write("Введите число -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.WriteLine(res.findLast(arr, res.y));
        }
        if (m == 17)
        {
            Console.Write("Введите кол-во чисел в массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            } //кол-во чисел в массиве
            Random random = new Random();
            int[] arr = new int[res.x];
            for (int i = 0; i < res.x; i++) //заполнение массива рандоиными чмслами в диапазоне от 1 до 10
            {
                arr[i] = random.Next(1, 11);
            }
            for (int i = 0; i < res.x; i++) { Console.Write(arr[i] + " "); }// вывод массива
            Console.WriteLine();
            Console.Write("Введите число, которое хотите вставить в массив -> ");
            while (!int.TryParse(Console.ReadLine(), out res.z))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            Console.Write("Введите позицию в массиве куда вставить число -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            }
            int[] new_arr = res.add(arr, res.z, res.y);
            Console.WriteLine(string.Join(" ", new_arr));//обЪединяем массив в строку и выводим через пробел
        }
        if (m == 18)
        {
            Console.Write("Введите кол-во чисел в массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            } //кол-во чисел в массиве
            Random random = new Random();
            int[] arr = new int[res.x];
            for (int i = 0; i < res.x; i++) //заполнение массива
            {
                arr[i] = random.Next(1, 11);
            }
            for (int i = 0; i < res.x; i++) { Console.Write(arr[i] + " "); }// вывод массива
            Console.WriteLine();
            res.reverse(arr);
        }
        if (m == 19)
        {
            Console.Write("Введите кол-во чисел в первом массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            } //кол-во чисел в массиве
            Console.Write("Введите кол-во чисел во втором массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.y))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            } //кол-во чисел в массиве
            Random random = new Random();
            int[] arr1 = new int[res.x];
            int[] arr2 = new int[res.y];
            for (int i = 0; i < res.x; i++) //заполнение массива
            {
                arr1[i] = random.Next(1, 11);
            }
            for (int i = 0; i < res.y; i++) //заполнение массива
            {
                arr2[i] = random.Next(1, 11);
            }
            for (int i = 0; i < res.x; i++) { Console.Write(arr1[i] + " "); }// вывод массива
            Console.WriteLine();
            for (int i = 0; i < res.y; i++) { Console.Write(arr2[i] + " "); }// вывод массива
            Console.WriteLine();
            int[] new_arr = res.concat(arr1, arr2);
            Console.WriteLine(string.Join(" ", new_arr));//обЪединяем массив в строку и выводим через пробел
        }
        if (m == 20)
        {
            Console.Write("Введите кол-во чисел в массиве -> ");
            while (!int.TryParse(Console.ReadLine(), out res.x))
            {
                Console.WriteLine("Ошибка ввода! Введите число -> ");
            } //кол-во чисел в массиве
            Random random = new Random();
            int[] arr1 = new int[res.x];
            for (int i = 0; i < res.x; i++) //заполнение массива
            {
                arr1[i] = random.Next(-10, 11);
            }
            for (int i = 0; i < res.x; i++) { Console.Write(arr1[i] + " "); }// вывод массива
            Console.WriteLine();
            int[] new_arr = res.deleteNegative(arr1);
            Console.WriteLine(string.Join(" ", new_arr));//обЪединяем массив в строку и выводим через пробел
        }
    }
}
