const string menu = "Выберите действие: \n" +
        $"(1) Добавить перевод\n" +
        $"(2) Удалить перевод\n" +
        $"(3) Изменить перевод\n" +
        $"(4) Перевести слово\n" +
        $"(5) Выйти";

string dictFilePath = "dict.txt";

Dictionary<string, string> dictionary = new Dictionary<string, string>();

void Wait()
{
    Console.WriteLine("Введите любую клавишу для продолжения...");
    Console.ReadKey();
    Console.Clear();
}

void AddTranslate()
{
    Console.Write("Введите слово: ");
    var word = Console.ReadLine();

    Console.Write("Введите перевод: ");
    var translate = Console.ReadLine();

    if (word == "" || translate == "")
    {
        Console.WriteLine("Вы не ввели значение (пустая строка)");
        Wait();
    }
    else
    {
        translate.ToString();
        word.ToString();

        dictionary[word] = translate;

        Wait();
    }
    
}

void DeleteTranslate()
{
    Console.Write("Введите слово, которое хотите удалить: ");
    var word = Console.ReadLine();
    if (word == "")
    {
        Console.WriteLine("Вы не ввели значение (пустая строка)");
        Wait();
    }
    else
    {
        word.ToString();

        if (dictionary.ContainsKey(word))
        {
            dictionary.Remove(word);
            Console.WriteLine($"Перевод слова '{word}' удален из словаря");
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не найдено в словаре");
        }

        Wait();
    }
}

void ChangeTranslate()
{
    Console.Write("Введите слово, перевод которого хотите изменить: ");
    var word = Console.ReadLine();

    if (word == "")
    {
        Console.WriteLine("Вы не ввели значение (пустая строка)");
        Wait();
    }
    else
    {
        word.ToString();

        if (dictionary.ContainsKey(word))
        {
            Console.Write("Введите новый перевод: ");
            var translate = Console.ReadLine();
            if (translate == "")
            {
                Console.WriteLine("Вы не ввели значение (пустая строка)");
                Wait();
            }
            else
            {
                dictionary[word] = translate;
                Console.WriteLine($"Перевод слова '{word}' изменен на '{translate}'");
                Wait();
            }
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не найдено в словаре");
            Wait();
        }
    }
}

void TranslateWord()
{
    Console.Write("Введите слово, которое хотите перевести: ");
    var word = Console.ReadLine();
    if (word == "")
    {
        Console.WriteLine("Вы не ввели значение (пустая строка)");
        Wait();
    }
    else
    {
        word.ToString();

        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine($"Перевод слова '{word}' - {dictionary[word]}");
            Wait();
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не найдено в словаре");
            Wait();
        }
    }
}

async void SaveDictionary()
{
    using (StreamWriter file = new StreamWriter(dictFilePath, false))
    {
        foreach(var pair in dictionary)
        {
            await file.WriteLineAsync($"{pair.Key} {pair.Value}");
        }

    }
}

try
{
    using (StreamReader inFile = new StreamReader(dictFilePath))
    {
        string? line;
        while ((line = await inFile.ReadLineAsync()) != null)
        {
            string[] parts = line.Split();
            if (parts.Length == 2)
            {
                string word = parts[0].Trim();
                string translate = parts[1].Trim();
                dictionary[word] = translate;
            }
        }
    }
}
catch
{
    Console.WriteLine("Ошибка считывания файла");
}

while (true)
{
    Console.WriteLine(menu);
    var choice = Console.ReadLine();

    if (choice == "")
    {
        Console.WriteLine("Введите номер действия...");
        Wait();
        continue;
    }

    choice.ToString();

    switch (choice)
    {
        case "1":
            Console.Clear();
            AddTranslate();
            break;
        case "2":
            Console.Clear();
            DeleteTranslate();
            break;
        case "3":
            Console.Clear();
            ChangeTranslate();
            break;
        case "4":
            Console.Clear();
            TranslateWord();
            break;
        case "5":
            Console.Clear();
            Console.Write("Хотите сохранить изменения в словаре? Введите y для сохранения перед выходом.: \n");
            var saveChanges = Console.ReadLine();
            if (saveChanges == "y")
            {
                SaveDictionary();
            }
            return 0;
    }
}
