## Итоговая проверочная работа.

# Задание:

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

[1, 2, 3, 4] -> [2, 4]

[1, 3, 4, 5, 7, 1, 3] -> [4]

[2, -4, 6] -> [2, -4, 6]

[1, 3, 5] -> []
____________________________________________

## Решение 

1. Задаем массив из 10 целых чисел.
2. Заполняем его случайными числами от -10 до 10.
3. С помощью счетчика count и цикла for выявляем элементы массива, которые являются четными числами. 
4. Создаем новый массив и заполняем его четными числами из предыдущего массива.

