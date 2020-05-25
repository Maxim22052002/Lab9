using System;
using System.Collections.Generic;
namespace Number1._1_9_
{
    public enum Type { К, О }//русские буквы
    public struct PriceList
    {
        public string nameofprod;
        public Type type;
        public double price;
        public double quantity;
    }
    class Program
    {
        
        public struct LogoSee
        {
            public DateTime TimeForLogo;
            public string lineLogo;
        }
        static void Main(string[] args)
        {
            List<LogoSee> log = new List<LogoSee>();
            DoublyLinkedList dataDoubLinked = new DoublyLinkedList();
            dataDoubLinked.Add("Папка", Type.К, 4.75, 400);
            dataDoubLinked.Add("Бумага А4 (пачка)", Type.О, 45.90, 100);
            dataDoubLinked.Add("Калькулятор", Type.О, 411.00, 10);
            int selector = 0;
            DateTime Datenow;
            while (selector != 7)
            {
                InteractiveMenu();
                string inlet = Console.ReadLine();
                selector = int.Parse(inlet);
                switch (selector)
                {
                    case 1:
                        Console.Clear();
                        dataDoubLinked.View();
                        LogSee(log, selector);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Add(dataDoubLinked);
                        LogSee(log, selector);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                         Datenow = DateTime.Now;
                        Delete(dataDoubLinked);
                        LogSee(log, selector);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Datenow = DateTime.Now;
                        Update(dataDoubLinked);
                        LogSee(log, selector);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Введите минимальную цену: ");
                        string srchTxt = Console.ReadLine();
                        dataDoubLinked.Search(srchTxt);
                        LogSee(log, selector);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        LogSee(log, selector);
                        ViewLogo(log);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Неверно. Введите число от 1 до 7");
                        break;
                }
            }

        }
        public static void LogSee(List<LogoSee> logo, int selector)
        {
            DateTime Datenow = DateTime.Now;
            switch (selector)
            {
                case 1:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Просмотр таблицы завершён." });
                    break;
                case 2:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Запись добавлена." });
                    break;
                case 3:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Запись удалена." });
                    break;
                case 4:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Запись обновлена." });
                    break;
                case 5:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Запись найдена." });
                    break;
                case 6:
                    logo.Add(new LogoSee() { TimeForLogo = Datenow, lineLogo = "Лог просмотрен." });
                    break;
                default:
                    break;
            }
        }
        public static void InteractiveMenu()
        {
            Console.WriteLine("1 - Просмотр таблицы");
            Console.WriteLine("2 - Добавить запись");
            Console.WriteLine("3 - Удалить запись");
            Console.WriteLine("4 - Oбновить запись");
            Console.WriteLine("5 - Поиск записей");
            Console.WriteLine("6 - Просмотреть лог");
            Console.WriteLine("7 - Выход");
        }
        public static void Add(DoublyLinkedList dataDoubLinked)
        {
            Console.WriteLine("Введите наименование товара:");
            string nameofprod = Console.ReadLine();
            Console.WriteLine("Введите тип товара: К-канцтовары, О-оргтехника");
            Type type = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
            Console.WriteLine("Введите цену товара за 1 шт (грн): ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество товара: ");
            double quantity = double.Parse(Console.ReadLine());
            dataDoubLinked.Add(nameofprod, type, price, quantity);
            Console.WriteLine("Запись добавлена.");
        }
        public static void Delete(DoublyLinkedList dataDoubLinked)
        {
            Console.WriteLine("Введите номер удаляемой строки: ");
            int deleteSelectIndexStr = int.Parse(Console.ReadLine());
            dataDoubLinked.Delete(deleteSelectIndexStr);
            Console.WriteLine("Запись удалена.");
        }
        public static void Update(DoublyLinkedList dataDoubLinked)
        {
            Console.WriteLine("Введите номер редактируемой строки: ");
            int updateSelectIndexStr = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое наименование товара: ");
            string nameofprod = Console.ReadLine();
            Console.WriteLine("Введите новый тип товара: К - канцтовары, О-оргтехника");
            Type type = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
            Console.WriteLine("Введите новую цену за 1 шт (грн): ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое количество товара: ");
            double quantity = double.Parse(Console.ReadLine());
            dataDoubLinked.Update(updateSelectIndexStr, nameofprod, type, price, quantity);
            Console.WriteLine("Запись обновлена.");
        }
        
        public static void ViewLogo(List<LogoSee> logo)
        {
            
            
            foreach (LogoSee log in logo)
            {
                Console.WriteLine( log.TimeForLogo+ " - "+ log.lineLogo);
            }
            
            Console.WriteLine();
            try
            {
                TimeSpan longerperiodactivity = logo[1].TimeForLogo.Subtract(logo[0].TimeForLogo);
                for (int i = 1; i < logo.Count; i++)
                {
                    if (logo[i].TimeForLogo.Subtract(logo[i - 1].TimeForLogo) > longerperiodactivity)
                        longerperiodactivity = logo[i].TimeForLogo.Subtract(logo[i - 1].TimeForLogo);
                }
                Console.WriteLine($"{longerperiodactivity.Hours}:{longerperiodactivity.Minutes}:{longerperiodactivity.Seconds}" + " - Наибольший период бездействия пользователя.");
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Несовершены действия.");
            }
        }
    }
}
