# FinalTestCSharp

## Задача :

### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма:

### Объявляем массив из нескольких разных строк. Затем объявляем новый массив, который получит строковые значения меньше или равный трем элементам через метод. Объявляем метод с одним значением. В методе объявляем новый массив и счетчик. Проходимся циклом по длине массива с условием, если длина строки в массиве меньше или равна трем, переносим данную строку в новый массив и увеличиваем счетчик на 1 единицу, возвращаемся в начало цикла. Если длина строки массива не меньше или равна 3, тогда сразу возвращаемся в начало цикла. И так происходит до тех пор пока не закончатся строки в массиве. Меняем размер нового массива на количество счетчика. Возвращаем новый массив. Выводим на экран старый массив и новый массив.
