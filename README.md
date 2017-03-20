1  Разработать unit-тесты с использованием как NUnit Framework, так и MS Unit Test Framework (здесь использовать подход  Data Driven Testing, пример в архиве UnitTesting.zip, проекты DDT.Demo и DDT.Demo.Tests) для тестирования метода из задачи 3 дня 3 


Разработать unit-тесты для тестирования методов задач (дни 2-3). (здесь и далее желательно использовать для тестирования NUnit Framework).


Реализовать метод NextBiggerNumber, который принимает положительное целое число и возвращает ближайше наибольшее  целое, состоящее из цифр исходного числа, и - 1 (null), если такого числа не существует. Примерные тест-кейсы



[TestCase(12, ExpectedResult = 21)]

[TestCase(513, ExpectedResult = 531)]

[TestCase(2017, ExpectedResult = 2071)]

[TestCase(414, ExpectedResult = 441)]

[TestCase(144, ExpectedResult = 414)]

[TestCase(1234321, ExpectedResult = 1241233)]

[TestCase(1234126, ExpectedResult = 1234162)]

[TestCase(3456432, ExpectedResult = 3462345)]

[TestCase(10, ExpectedResult = -1)]

[TestCase(20, ExpectedResult = -1)]


4  Разработать метод, позволяющий вычислять корень n-ой степени (n - целое, положительное) из вещественного числа методом Ньютона с заданной точностью. Придерживаться следующей сингатуры метода

public static double *****(double *****, int *****, double *****)

При  некорректных входных данных выбрасывать соответствующие исключения. Разработать unit-тесты для тестирования полученного метода. 
