namespace ejednevnik
{
  
    class Date07
    {
        public void DATE07()
        {
            Console.WriteLine("07.11.22");
            Console.WriteLine(" 1.Убраться дома");
            Console.WriteLine(" 2.Сходить на пары");
        }
    }

    class Date08
    {
        public void DATE08()
        {
            Console.WriteLine("08.11.22");
            Console.WriteLine(" Сделать практические по С# ");
            Console.WriteLine(" Отдахнуть ");
        }
    }


    class Date09
    {
        public void DATE09()
        {
            Console.WriteLine("09.11.22");
            Console.WriteLine(" Посмотреть туторы на ютубе  ");
            Console.WriteLine(" Отдахнуть ");
        }
    }




    class MainClass
    {

        public static void Main(string[] ages)
        {


            int position = 1;
            string[] Day8 = new string[] { "Сделать практические по С# \n —----------------------------------------\n Описание: Нужно сделать очнь много практических.\n Дата:08.11.22" };
            string[] Day08 = new string[] { "Хорошенечко отдахнуть \n —----------------------------------------\n Описание : лежат на кровати. \n Дата :08.11.22" };

            Date08 date08 = new Date08();
            date08.DATE08();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, position);

                }
                Console.Clear();
                date08.DATE08();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (key.Key == ConsoleKey.Enter && position == 1)
                {
                    Console.Clear();
                    Console.WriteLine(Day8[0]);
                }

                if (key.Key == ConsoleKey.Enter && position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Day08[0]);
                }

                string[] Day7 = new string[] { "Убраться дома \n —----------------------------------------\n Описание: Нужно сделать генеральную уборку по дому. \n Дата: 07.11.22 " };
                string[] Day07 = new string[] { "Сходить на пары \n —----------------------------------------\n Описание : Прийти на 1,2 и 3 пару. \n Дата : 07.11.22" };

                Date07 date07 = new Date07();


                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    int positi = 1;
                    date07.DATE07();
                    while (true)
                    {
                        ConsoleKeyInfo k = Console.ReadKey();
                        if (k.Key == ConsoleKey.UpArrow)
                        {
                            positi--;
                        }

                        else if (k.Key == ConsoleKey.DownArrow)
                        {
                            positi++;
                        }
                        else if (k.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positi);

                        }
                        Console.Clear();
                        date07.DATE07();
                        Console.SetCursorPosition(0, positi);
                        Console.WriteLine("->");

                        if (k.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day7[0]);
                        }

                        if (k.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day07[0]);
                        }
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            date08.DATE08();
                        }
                    }

                }

                string[] Day9 = new string[] { "Посмотреть туторы на ютубе \n —----------------------------------------\n Описание: Посмотреть 2 тутроиала на ютубе по С#. \n Дата:09.11.22" };
                string[] Day09 = new string[] { "Отдахнуть \n —----------------------------------------\n Описание : Лежать на кровати и ничего не далать. \n Дата :09.11.22" };
                Date09 date09 = new Date09();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    int positio = 1;
                    date09.DATE09();
                    while (true)
                    {
                        ConsoleKeyInfo ke = Console.ReadKey();
                        if (ke.Key == ConsoleKey.UpArrow)
                        {
                            positio--;
                        }

                        else if (ke.Key == ConsoleKey.DownArrow)
                        {
                            positio++;
                        }
                        else if (ke.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positio);

                        }
                        Console.Clear();
                        date09.DATE09();
                        Console.SetCursorPosition(0, positio);
                        Console.WriteLine("->");

                        if (ke.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day9[0]);
                        }

                        if (ke.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day09[0]);
                        }


                    }

                }

            }

        }

    }

}