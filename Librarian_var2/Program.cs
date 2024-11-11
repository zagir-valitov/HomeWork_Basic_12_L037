using System.Collections.Concurrent;

Console.WriteLine(" ---- Home work 12. Librarian var. 2 ----");

ConcurrentDictionary<string, int> books = new();
bool showBookList = true;

Parallel.Invoke(
    () =>
    {
        while (showBookList)
        {
            foreach (var book in books)
            {
                var k = book.Key;
                var v = book.Value;
                books.AddOrUpdate(k, v, (key, OldValue) => OldValue + 1);
                if (book.Value == 100)
                {
                    books.TryRemove(k, out v);
                }
            }
            Thread.Sleep(1000);
        }
    },

    () =>
    {
        do
        {
            Console.Write(
                "\n--------------------------------" +
                "\n\t   Operation:" +
                "\n1 - add book" +
                "\n2 - display list of unread books" +
                "\n3 - exit" +
                "\n--------------------------------" +
                "\nEnter command: ");

            string? inputLine = Console.ReadLine();
            if (inputLine == "1")
            {
                Console.WriteLine("\nEnter book name to add:");
                inputLine = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputLine))
                {
                    books.TryAdd(inputLine, 0);
                }
                else
                {
                    Console.WriteLine("You have not entered a book title!!!");
                }
            }
            else if (inputLine == "2")
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("\t   Book List:");
                if (books.IsEmpty)
                {
                    Console.WriteLine(" Empty!!!");
                }
                else
                {
                    int count = 1;
                    foreach (var book in books)
                    {
                        Console.WriteLine($"{count}) {book.Key}\t{book.Value}%");
                        count++;
                    }
                }
                Console.WriteLine("--------------------------------");
            }
            else if (inputLine == "3")
            {
                Console.WriteLine("Exit!");
                showBookList = false;
                break;
            }
        } while (true);
    }
);