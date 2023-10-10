**Решение задачи**

_Алгоритм решния задачи_

1. Ввод строки с клавиатуры и сохранение ее в переменную inputLine.
2. Инициализация переменных:
   - resultStrings: массив строк для хранения результатов
   - resultIndex: индекс текущей строки в массиве результатов
   - currentString: текущая строка для сбора символов
   - spaceCount: счетчик пробелов в строке
3. Перебор каждого символа c в inputLine:
   a. Если c не равен пробелу:
      - Добавить c к currentString.
   b. Иначе:
      i. Проверить длину currentString:
         - Если длина меньше или равна 3 символам:
           - Добавить currentString в resultStrings по индексу resultIndex.
           - Увеличить resultIndex на 1.
         - Сбросить currentString.
4. Проверить длину currentString после завершения цикла:
   - Если длина меньше или равна 3 символам:
     - Добавить currentString в resultStrings по индексу resultIndex.
5. Вывод результатов:
   a. Создать массив finalResult и скопировать непустые элементы из resultStrings в finalResult.
   b. Вывести элементы массива finalResult.

    
