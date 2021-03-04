using System;
using System.Collections.Generic;
namespace foo
{
    class Client
    {
        private string name; //Имя
        private string surname; //Фамилия
        private string iin; //Клиент ИИН-і
        public string phone; //Клиент телефон номері
        public Client()
        {
            Console.WriteLine("Введите ваше имя: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            this.surname = Console.ReadLine();
            this.iin = IIN_tekseru();
            this.phone = Phone_tekseru();

        }
        public Client(string name, string surname, string iin, string phone) //Параметрлі конструктор
        {
            this.name = name;
            this.surname = surname;
            this.iin = iin;
            this.phone = phone;
        }
        public string Phone_tekseru()
        {
            string phone = "";
            bool tekseru = true;
            while (tekseru)
            {
                Console.WriteLine("Пожалуйста, укажите свой номер телефона в формате: +7 777 000 00 00\nБез пробелов");
                phone = Console.ReadLine();
                if (phone.Length == 12)
                {
                    tekseru = false;
                }
                else
                {
                    Console.WriteLine("Введите номер правильно: +7 777 000 00 00");
                }
            }
            return phone;
        }
        public string IIN_tekseru()
        {
            string iin = "";
            bool tekseru = true;
            while (tekseru)
            {
                Console.WriteLine("Пожалуйста, укажите свой ИИН в формате: 12 чисел \nБез пробелов");
                iin = Console.ReadLine();
                if (iin.Length == 12)
                {
                    tekseru = false;
                }
                else
                {
                    Console.WriteLine("Введите ИИН правильно: 010203123456");
                }
            }
            return iin;
        }
        public void Shygaru()
        {
            Console.WriteLine($"{surname.ToUpper()} {name.ToUpper()}\nВаши данные ИИН: {iin}\n            Номер: {phone}");
        }
    }
    class Reister
    {
        public int id;
        public string bagyt;
        public DateTime ushu;
        public DateTime qonu;
        public int baga;
        public int clas;
        public int bagaj;
        public void Mejgorodbagklass()
        {
            Console.WriteLine("Выберите класс  1: Business class\n\t\t2: Economy class");
            clas = Convert.ToInt32(Console.ReadLine());
            if (clas == 1)
            {
                baga += 30000;
            }
            else
            {
                baga += 0;
            }
            Console.WriteLine("У вас есть багаж?\nВы можете брать собой до 20кг груза, если лимит повышен за каждый киллограмм по 1500 тг");
            Console.Write("У меня собой= ");
            bagaj = Convert.ToInt32(Console.ReadLine());
            if (bagaj > 20)
            {
                baga += (bagaj - 20) * 1500;
            }
            else
                baga += 0;
        }
        public void Bilet_shygaru()
        {
            if (clas == 1)
            {
                Console.WriteLine("Откуда: Almaty;\nКудa: " + bagyt + "\tКласс: Business class" + "\tБагаж= " + bagaj + "\nВремя вылета: " + ushu + "\tВремя посадки: " + qonu + "\nВы летите: " + (qonu - ushu) + "\nОбщая стоимость: " + baga + " тг");
            }
            else
                Console.WriteLine("Откуда: Almaty;\nКудa: " + bagyt + "\tКласс: Economy class" + "\tБагаж= " + bagaj + "\nВремя вылета: " + ushu + "\tВремя посадки: " + qonu + "\nВы летите: " + (qonu - ushu) + "\nОбщая стоимость: " + baga + " тг");

        }
        public Reister(int id, string bagyt, DateTime ushu, DateTime qonu, int baga)
        {
            this.id = id;
            this.bagyt = bagyt;
            this.ushu = ushu;
            this.qonu = qonu;
            this.baga = baga;
        }
        public void show()
        {
            Console.WriteLine(id + ")Город: " + bagyt + "\tВремя вылета: " + ushu + "\n\t\t\tВремя посадки: " + qonu + "\t\tЦена: " + baga);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Reister> qalalar = new List<Reister>();
            qalalar.Add(new Reister(1, "Nursultan", new DateTime(2021, 02, 26, 17, 45, 00), new DateTime(2021, 02, 26, 19, 30, 00), 18925));
            qalalar.Add(new Reister(2, "Shymkent ", new DateTime(2021, 02, 26, 19, 35, 00), new DateTime(2021, 02, 26, 21, 05, 00), 17797));
            qalalar.Add(new Reister(3, "Uralsk   ", new DateTime(2021, 02, 26, 09, 55, 00), new DateTime(2021, 02, 26, 14, 25, 00), 38360));
            qalalar.Add(new Reister(4, "Qyzylorda", new DateTime(2021, 02, 27, 12, 45, 00), new DateTime(2021, 02, 27, 13, 30, 00), 43401));
            qalalar.Add(new Reister(5, "Aqtobe   ", new DateTime(2021, 02, 26, 17, 50, 00), new DateTime(2021, 02, 26, 19, 35, 00), 26376));

            List<Reister> shetel = new List<Reister>();
            shetel.Add(new Reister(1, "Dubai", new DateTime(2021, 02, 27, 04, 50, 00), new DateTime(2021, 02, 27, 08, 10, 00), 330312));
            shetel.Add(new Reister(2, "Stambul", new DateTime(2021, 02, 26, 17, 55, 00), new DateTime(2021, 02, 27, 21, 10, 00), 333595));
            shetel.Add(new Reister(3, "Minsk", new DateTime(2021, 03, 06, 20, 05, 00), new DateTime(2021, 03, 07, 03, 55, 00), 171467));
            shetel.Add(new Reister(4, "Moskva", new DateTime(2021, 02, 26, 18, 50, 00), new DateTime(2021, 02, 26, 21, 10, 00), 289176));
            shetel.Add(new Reister(5, "Tashkent", new DateTime(2021, 02, 28, 23, 50, 00), new DateTime(2021, 03, 01, 01, 20, 00), 49344));

            List<Client> clients = new List<Client>();
            clients.Add(new Client("Meiirzhan", "Boribek", "000229501066", "+77021856931"));
            clients.Add(new Client("Serzhan", "Qaiyrkhanov", "000000000000", "+77021856931"));
            clients.Add(new Client("Yerkegali", "Suleimen", "010102500970", "+77786290178"));
            clients.Add(new Client("Bakbergen", "Tolen", "010105501599", "+77021856931"));

            Console.WriteLine("Добро пожаловать на Авиакомпанию СИБ"); //www.aviacompany.com деген сайтқа кірген секілді
            clients.Add(new Client());
            Console.WriteLine("Выберите путь Межгород");
            Console.WriteLine("              Другие страны");
            Console.WriteLine("Если Межгород нажмите 1 если нет нажмите любое другое число");
            int vxod = Convert.ToInt32(Console.ReadLine());
            switch (vxod)
            {
                case 1:
                    Console.WriteLine("Куда Вы желаете полететь?");
                    Console.WriteLine("Наши рейсы: ");
                    foreach (var s in qalalar)
                    {
                        s.show();
                    }
                    Console.WriteLine("Выберите число стоящий перед городом");
                    int sany = Convert.ToInt32(Console.ReadLine());
                    qalalar[sany - 1].Mejgorodbagklass();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Line();
                    Console.WriteLine();
                    Console.WriteLine("Ваш билет");
                    clients[4].Shygaru();
                    qalalar[sany - 1].Bilet_shygaru();
                    Line();
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("\bУдачного полета");
                    break;
                case 2:
                    Console.WriteLine("Куда Вы желаете полететь?");
                    Console.WriteLine("Наши рейсы: ");
                    foreach (var s in shetel)
                    {
                        s.show();
                    }
                    Console.WriteLine("Выберите число стоящий перед городом");
                    sany = Convert.ToInt32(Console.ReadLine());
                    shetel[sany - 1].Mejgorodbagklass();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Line();
                    Console.WriteLine();
                    Console.WriteLine("Ваш билет");
                    clients[4].Shygaru();
                    shetel[sany - 1].Bilet_shygaru();
                    Line();
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("\t\tУдачного полета");
                    break;
            }
        }
        public static void Line()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.Write("-");
            }
        }
}
