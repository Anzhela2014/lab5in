// // Console.Write("\nВведите номер месяца (1-12): ");
// string month = Console.ReadLine();
// switch (month) {
//     case "12":
//     case "1":
//     case "2":
//         Console.WriteLine("Сезон: Зима");
//         break;
//     case "3":
//     case "4":
//     case "5":
//         Console.WriteLine("Сезон: Весна");
//         break;
//     case "6":
//     case "7":
//     case "8":
//         // Console.WriteLine("Сезон: Лето");
//         break;
//     case "9":
//     case "10":
//     case "11":
//         Console.WriteLine("Сезон: Осень");
//         break;
//     default:
//         Console.WriteLine("Ошибка: введён не тот номер месяца. Используй от 1 до 12");
//         break;
// }
Random random = new Random();
int secret = random.Next(1, 101);
int attempts = 0;
bool guessed = false;
Console.WriteLine("Угадай число (1-100)");
Console.WriteLine("Я загадал число. Попробуй угадать!");
while (!guessed) {
    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int guess)) {
        Console.WriteLine("!!! Введи целое число, а не текст!");
        continue;
    }
    if (guess < 1 || guess > 100) {
        Console.WriteLine("!!! Число должно быть от 1 до 100!");
        continue;
    }
    attempts++;
    if (guess < secret) {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"↑ Больше! {hint}\n");
    }
    else if (guess > secret) {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"↓ Меньше! {hint}\n");
    }
    else {
        guessed = true;
    }
}
string result = attempts <= 7
    ? $"Отличный результат! Всего {attempts} попыток."
    : $"Число найдено за {attempts} попыток. Можно лучше!";
Console.WriteLine($"\n🎉 Правильно! Загаданное число: {secret}");
Console.WriteLine($"{result}");
string GetHint(int difference) {
    switch (difference) {
        case <= 3:
            return "🔥 Горячо!";
        case <= 10:
            return "🌡️ Тепло.";
        case <= 25:
            return "🌀 Прохладно.";
        default:
            return "❄️ Холодно!";
    }
};