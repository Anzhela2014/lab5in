// // // // Console.Write("\nВведите номер месяца (1-12): ");
// // // string month = Console.ReadLine();
// // // switch (month) {
// // //     case "12":
// // //     case "1":
// // //     case "2":
// // //         Console.WriteLine("Сезон: Зима");
// // //         break;
// // //     case "3":
// // //     case "4":
// // //     case "5":
// // //         Console.WriteLine("Сезон: Весна");
// // //         break;
// // //     case "6":
// // //     case "7":
// // //     case "8":
// // //         // Console.WriteLine("Сезон: Лето");
// // //         break;
// // //     case "9":
// // //     case "10":
// // //     case "11":
// // //         Console.WriteLine("Сезон: Осень");
// // //         break;
// // //     default:
// // //         Console.WriteLine("Ошибка: введён не тот номер месяца. Используй от 1 до 12");
// // //         break;
// // // }
// // // Random random = new Random();
// // int secret = random.Next(1, 101);
// // int attempts = 0;
// // bool guessed = false;
// // Console.WriteLine("Угадай число (1-100)");
// // Console.WriteLine("Я загадал число. Попробуй угадать!");
// // while (!guessed) {
// //     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
// //     string input = Console.ReadLine();
// //     if (!int.TryParse(input, out int guess)) {
// //         Console.WriteLine("!!! Введи целое число, а не текст!");
// //         continue;
// //     }
// //     if (guess < 1 || guess > 100) {
// //         Console.WriteLine("!!! Число должно быть от 1 до 100!");
// //         continue;
// //     }
// //     attempts++;
// //     if (guess < secret) {
// //         int diff = secret - guess;
// //         string hint = GetHint(diff);
// //         Console.WriteLine($"↑ Больше! {hint}\n");
// //     }
// //     else if (guess > secret) {
// //         int diff = guess - secret;
// //         string hint = GetHint(diff);
// //         Console.WriteLine($"↓ Меньше! {hint}\n");
// //     }
// //     else {
// //         guessed = true;
// //     }
// // }
// // string result = attempts <= 7
// //     ? $"Отличный результат! Всего {attempts} попыток."
// //     : $"Число найдено за {attempts} попыток. Можно лучше!";
// // Console.WriteLine($"\n🎉 Правильно! Загаданное число: {secret}");
// // Console.WriteLine($"{result}");
// // string GetHint(int difference) {
// //     switch (difference) {
// //         case <= 3:
// //             return "🔥 Горячо!";
// //         case <= 10:
// //             return "🌡️ Тепло.";
// //         case <= 25:
// //             return "🌀 Прохладно.";
// //         default:
// //             return "❄️ Холодно!";
// //     }
// // };
// //ZADANIE 1
// // Console.Write("Введите пароль: ");
// // string pass=Console.ReadLine();

// // Console.Write("Подтвердите пароль: ");
// // string c = Console.ReadLine();
// // if (pass == c) {
// //     Console.WriteLine("Пароль принят");
// // }
// // else {
// //     Console.WriteLine("Пароль не принят");
// // }
// //ZADANIE 2
// // Console.Write("Введите ваш возраст: ");
// // if (int.TryParse(Console.ReadLine(), out int age)) {
// //     if (age >= 18) {
// //         Console.WriteLine("Доступ разрешён");
// //     } else {
// //         Console.WriteLine("Доступ запрещён");
// //     }
// // } else {
// //     Console.WriteLine("введено не число");
// // }
// //ZADANIE 3
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// string o = Console.ReadLine();
// switch (o) {
//     case "+": Console.WriteLine($"{a} + {b} = {a + b}"); break;
//     case "-": Console.WriteLine($"{a} - {b} = {a - b}"); break;
//     case "*": Console.WriteLine($"{a} * {b} = {a * b}"); break;
//     case "/":
//         if (b != 0) Console.WriteLine($"{a} / {b} = {a / b}");
//         else Console.WriteLine("НЕТ: деление на ноль!");
//         break;
// }
// //ZADANIE 4
// int s = 0;
// int a = int.Parse(Console.ReadLine());
// if (a > 0) s += a;
// int b = int.Parse(Console.ReadLine());
// if (b > 0) s += b;
// int c = int.Parse(Console.ReadLine());
// if (c > 0) s += c;
// Console.WriteLine(s);
// //ZADANIE 5 
// Console.WriteLine("путь A или B?");
// string x = Console.ReadLine();
// if (x == "А") {
//     Console.WriteLine("загадка дракона:");
//     string y = Console.ReadLine();
//     if (y == "рыба") Console.WriteLine("дракон открыл дверь!");
//     else Console.WriteLine("дракон вас съел!");
// } 
// else if (x == "B") {
//     Console.WriteLine("дверь 1 или 2?");
//     string z = Console.ReadLine();
//     if (z == "1") Console.WriteLine("ты нашлёл сокровище");
//     else Console.WriteLine("ты попал в капкан");
// }
