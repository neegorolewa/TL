namespace Dictionary;

class Program
{
    const string MENU = "Выберите действие: \n" +
            $"(1) Добавить перевод\n" +
            $"(2) Удалить перевод\n" +
            $"(3) Изменить перевод\n" +
            $"(4) Перевести слово\n" +
            $"(5) Выйти";

    string dictFilePath = "dict.txt";

    Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main()
    {
        try
        {
            Program program = new Program();
            program.LoadDictionaryFromFile();
            while (true)
            {
                Console.WriteLine(MENU);
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        program.AddTranslate();
                        break;
                    case "2":
                        Console.Clear();
                        program.DeleteTranslate();
                        break;
                    case "3":
                        Console.Clear();
                        program.ChangeTranslate();
                        break;
                    case "4":
                        Console.Clear();
                        program.TranslateWord();
                        break;
                    case "5":
                        Console.Clear();
                        Console.Write("Хотите сохранить изменения в словаре? Введите y для сохранения перед выходом.: \n");
                        var saveChanges = Console.ReadLine();
                        if (saveChanges == "y")
                        {
                            program.SaveDictionary();
                            Console.WriteLine("Изменения успешно сохранены");
                        }
                        return;
                    default:
                        Console.WriteLine("Неверно введено действие...");
                        continue;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    void AddTranslate()
    {
        try
        {
            Console.Write("Введите слово: ");
            var word = Console.ReadLine();

            Console.Write("Введите перевод: ");
            var translate = Console.ReadLine();

            if (word == "" || translate == "")
            {
                Console.WriteLine("Вы не ввели значение (пустая строка)");
            }
            else
            {
                dictionary[word] = translate;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при удалении перевода: {ex.Message}");
            throw;
        }

    }

    void DeleteTranslate()
    {
        try
        {
            Console.Write("Введите слово, которое хотите удалить: ");
            var word = Console.ReadLine();
            if (word == "")
            {
                Console.WriteLine("Вы не ввели значение (пустая строка)");
            }
            else
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary.Remove(word);
                    Console.WriteLine($"Перевод слова '{word}' удален из словаря");
                }
                else
                {
                    Console.WriteLine($"Слово '{word}' не найдено в словаре");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при удалении перевода: {ex.Message}");
            throw;
        }
    }

    void ChangeTranslate()
    {
        try
        {
            Console.Write("Введите слово, перевод которого хотите изменить: ");
            var word = Console.ReadLine();

            if (word == "")
            {
                Console.WriteLine("Вы не ввели значение (пустая строка)");
            }
            else
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.Write("Введите новый перевод: ");
                    var translate = Console.ReadLine();
                    if (translate == "")
                    {
                        Console.WriteLine("Вы не ввели значение (пустая строка)");
                    }
                    else
                    {
                        dictionary[word] = translate;
                        Console.WriteLine($"Перевод слова '{word}' изменен на '{translate}'");
                    }
                }
                else
                {
                    Console.WriteLine($"Слово '{word}' не найдено в словаре");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при изменении перевода: {ex.Message}");
            throw;
        }
    }

    void TranslateWord()
    {
        try
        {
            Console.Write("Введите слово, которое хотите перевести: ");
            var word = Console.ReadLine();
            if (word == "")
            {
                Console.WriteLine("Вы не ввели значение (пустая строка)");
            }
            else
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод слова '{word}' - {dictionary[word]}");
                }
                else
                {
                    Console.WriteLine($"Слово '{word}' не найдено в словаре");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при переводе слова: {ex.Message}");
            throw;
        }

    }

    async void SaveDictionary()
    {
        try
        {
            using (StreamWriter dictFile = new StreamWriter(dictFilePath, false))
            {
                foreach (var pair in dictionary)
                {
                    await dictFile.WriteLineAsync($"{pair.Key} {pair.Value}");
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при cохранении изменений: {ex.Message}");
            throw;
        }

    }

    async void LoadDictionaryFromFile()
    {
        try
        {
            using (StreamReader dictFile = new StreamReader(dictFilePath))
            {
                string? line;
                while ((line = await dictFile.ReadLineAsync()) != null)
                {
                    string[] wordWithTranslation = line.Split();
                    if (wordWithTranslation.Length == 2)
                    {
                        string word = wordWithTranslation[0].Trim();
                        string translate = wordWithTranslation[1].Trim();
                        dictionary[word] = translate;
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("Ошибка считывания файла");
            throw;
        }
    }
}