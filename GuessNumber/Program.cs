// Console.Write("\nВведите номер месяца (1-12): ");
string month = Console.ReadLine();
switch (month) {
    case "12":
    case "1":
    case "2":
        Console.WriteLine("Сезон: Зима");
        break;
    case "3":
    case "4":
    case "5":
        Console.WriteLine("Сезон: Весна");
        break;
    case "6":
    case "7":
    case "8":
        Console.WriteLine("Сезон: Лето");
        break;
    case "9":
    case "10":
    case "11":
        Console.WriteLine("Сезон: Осень");
        break;
    default:
        Console.WriteLine("Ошибка: введён не тот номер месяца. Используй от 1 до 12");
        break;
}