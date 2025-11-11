using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    internal class Program
    {

        static void Main(string[] args)
        {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Колекція документів (назва + вміст)
        List<Document> documents = new List<Document>
        {
            new Document("Інструкція", "Тестовий документ."),
            new Document("Звіт", "Пишеться."),
            new Document("Нотатки", "Існують.")
        };

            // Колекція користувачів редактора
            List<User> users = new List<User>
        {
            new User("Він", "Федр"),
            new User("Вона", "Єва"),
            new User("Воно", "Міядзакі")
        };

            // Колекція історії дій
            List<string> history = new List<string>
        {
            "Створено новий документ: Інструкція",
            "Відредаговано документ: Звіт",
            "Додано користувача: Воно"
        };

            Console.WriteLine("Колекції створені успішно!");

            Console.WriteLine("\nНатисніть...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("=== Вибірка даних за допомогою LINQ ===\n");

            // 1. Where — вибрати документи, що містять слово "LINQ"
            var linqDocs = documents.Where(d => d.Content.Contains("документ"));
            Console.WriteLine("Документи, що містять слово 'документ':");
            foreach (var doc in linqDocs)
                Console.WriteLine($" - {doc.Title}");
            Console.WriteLine();

            // 2. Select — отримати лише назви документів
            var titles = documents.Select(d => d.Title);
            Console.WriteLine("Назви всіх документів:");
            foreach (var title in titles)
                Console.WriteLine($" - {title}");
            Console.WriteLine();

            // 3. Take — взяти перші два документи
            var firstTwo = documents.Take(2);
            Console.WriteLine("Перші два документи:");
            foreach (var doc in firstTwo)
                Console.WriteLine($" - {doc.Title}: {doc.Content}");
            Console.WriteLine();

            Console.WriteLine("\nНатисніть...");
            Console.ReadKey();
            Console.Clear();

            // === Пункт 7 === Зміна порядку даних за допомогою LINQ
            Console.WriteLine("=== Зміна порядку даних за допомогою LINQ ===\n");

            // 1. OrderBy — сортування документів за назвою
            var sortedByTitle = documents.OrderBy(d => d.Title);
            Console.WriteLine("Документи відсортовані за назвою (OrderBy):");
            foreach (var doc in sortedByTitle)
                Console.WriteLine($" - {doc.Title}");
            Console.WriteLine();

            // 2. Reverse — у зворотному порядку
            var reversedDocs = documents.AsEnumerable().Reverse();
            Console.WriteLine("Документи у зворотному порядку (Reverse):");
            foreach (var doc in reversedDocs)
                Console.WriteLine($" - {doc.Title}");
            Console.WriteLine();

            // 3. GroupBy — групування документів за наявністю слова "документ"
            var groupedDocs = documents.GroupBy(d => d.Content.Contains("документ"));
            Console.WriteLine("Групування документів за наявністю слова 'документ' (GroupBy):");
            foreach (var group in groupedDocs)
            {
                Console.WriteLine(group.Key ? "\nДокументи, що містять слово 'документ':" : "\nДокументи без цього слова:");
                foreach (var doc in group)
                    Console.WriteLine($" - {doc.Title}");
            }

            Console.WriteLine("\nНатисніть...");
            Console.ReadKey();
            Console.Clear();

            // === Пункт 8 === Вибірка даних за допомогою LINQ
            Console.WriteLine("=== Зміна порядку даних за допомогою LINQ ===\n");

            // Підрахувати документи, що містять слово "Тестовий"
            var testDocsCount = documents.Count(d => d.Content.Contains("Тестовий"));
            Console.WriteLine($"Кількість документів, що містять слово 'Тестовий': {testDocsCount}");

            // Перевірити, чи є документ з назвою "Звіт"
            bool hasReport = documents.Any(d => d.Title == "Звіт");
            Console.WriteLine($"Чи є документ з назвою 'Звіт'? {hasReport}");

            Console.WriteLine("\nНатисніть...");
            Console.ReadKey();
            Console.Clear();

            // === Пункт 9 === Розширення управління запитами за допомогою LINQ
            Console.WriteLine("=== Зміна порядку даних за допомогою LINQ ===\n");

            // Пропустити перший документ
            var skippedDocs = documents.Skip(1);
            Console.WriteLine("\nДокументи після пропуску першого:");
            foreach (var doc in skippedDocs)
                Console.WriteLine($" - {doc.Title}");

            Console.WriteLine("\nНатисніть...");
            Console.ReadKey();
            Console.Clear();
        }
     }

        class Document
        {
            public string Title { get; set; }
            public string Content { get; set; }

            public Document(string title, string content)
            {
                Title = title;
                Content = content;
            }

            public override string ToString() => $"{Title}: {Content}";
        }

        class User
        {
            public string Name { get; set; }
            public string Password { get; set; }

            public User(string name, string password)
            {
                Name = name;
                Password = password;
            }

            public override string ToString() => $"{Name} (пароль: {Password})";
        }
}
