// Задача: Написать программу, которая из 
// имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Hello Geek");

        // Вводим исходную строку с клавиатуры
        Console.WriteLine("Введите строки, разделенные пробелами:");
        string inputLine = Console.ReadLine();

        // Подсчитываем количество пробелов, чтобы определить размер массива
        int spaceCount = 0;
        foreach (char c in inputLine)
        {
            if (c == ' ')
            {
                spaceCount++;
            }
        }

        // Создаем массив строк для хранения результатов
        string[] resultStrings = new string[spaceCount + 1];

        int resultIndex = 0; // Индекс текущей строки в массиве результатов
        string currentString = ""; // Текущая строка для сбора символов

        // Проходим по каждому символу в исходной строке
        foreach (char c in inputLine)
        {
            // Если текущий символ не пробел, добавляем его к текущей строке
            if (c != ' ')
            {
                currentString += c;
            }
            else
            {
                // Если текущий символ пробел, проверяем длину текущей строки и добавляем ее в результат, если она меньше или равна 3 символам
                if (currentString.Length <= 3)
                {
                    resultStrings[resultIndex] = currentString;
                    resultIndex++;
                }

                // Сбрасываем текущую строку
                currentString = "";
            }
        }

        // Проверяем и добавляем последнюю строку после завершения цикла
        if (currentString.Length <= 3)
        {
            resultStrings[resultIndex] = currentString;
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in resultStrings)
        {
            if (!string.IsNullOrEmpty(str))
            {
                Console.WriteLine(str);
            }
        }
    
