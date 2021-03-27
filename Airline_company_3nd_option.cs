using System;
using System.Collections.Generic;

namespace OOP_PROJECT
{
    class Contact_information  // Класс жұмысы : бұл класта клиенттер туралы ақпарат сақталады.
    {
        // Проект : ӘУЕ АРҚЫЛЫ ЗАТ ТАСЫМАЛДАУ ҚЫЗМЕТІ. Алдыңғы проектке зат тасымалдау қызметін қостым. 

        private string company;     // Компанияның аты
        private string name;        // Заказ берушінің аты
        private string country;     // Елі
        private string phone_number;   //  Телефон номері 
        private string email;   //  Электронды почтасы

        public Contact_information()    // Бос конструктор
        {
            Console.Write("\nCompany : ");
            this.company = Console.ReadLine();
            Console.Write("\nName : ");
            this.name = Console.ReadLine();
            Console.Write("\nCountry: ");
            this.country = Console.ReadLine();
            this.phone_number = Phone_tekseru();
            this.email = Email_tekseru();

        }

        public Contact_information(string company, string name,string country, string phone_number, string email) // Параметрлі конструктор
        {
            this.company = company;
            this.name = name;
            this.country = country;
            this.phone_number = phone_number;
            this.email = email;
        }
        public string Phone_tekseru()
        {
            string phone_number = "";
            bool tekseru = true;
            while (tekseru)
            {
                Console.WriteLine("Пожалуйста, укажите свой номер телефона в формате: +7 707 777 77 77\nБез пробелов\n");
                phone_number = Console.ReadLine();
                if (phone_number.Length == 12)
                {
                    tekseru = false;
                }
                else
                {
                    Console.WriteLine("Введите номер правильно: +7 777 777 77 77");
                }
            }
            return phone_number;
        }

        public string Email_tekseru()
        {
            string email = "";
            bool tekseru = true;
            while (tekseru)
            {

                Console.Write("\nПожалуйста, напишите свой почту (! gmail.com ) : ");
                email = Console.ReadLine();
                string gmail_com = email.Substring(email.Length - 10); // Мұнда клиенттің почтасын тексеремін. Почтаның ұзындығынан 10-ды алған себебім, @gmail.com
                if (gmail_com == "@gmail.com")                         // ұзындығы 10-ға тең. Сол арқылы почта ұзындығынан @gmail.com деген бөлікті алып, тексеремін.
                {                                                      // Себебі клиент басқа почта немесе басқа ақпарат енгізіп жібермес үшін.
                    tekseru = false;
                }

                else
                {
                    Console.WriteLine("Введите почту правильно !");
                }

            }

            return email;
        }

        public void Shygaru()
        {
            Console.WriteLine($"Компания : {company}  Имя : {name}  Email : {email}");
        }

    }

    class Marshrut  // Класс жұмысы:  маршруттардың бағыты, ұшу-қону уақыты, самолетті таңдау мүмкіндігі қарастырылған. 
    {
        public int id_air;    // Кестедегі маршрут номері
        public string aircraft;  // Самолет түрі
        public string source_port;  // Жүкті салып жіберетін орын(ел)
        public string destination_port;  // Жүк жеткізілетін орын(ел)
        public DateTime source_time;   // Жүкті тасымалдау басталатын уақыт
        public DateTime destination_time;  // Жүк жеткізілетін уақыт

        public Marshrut() { }
        public Marshrut(int id_air, string aircraft, string source_port,string destination_port, DateTime source_time, DateTime destination_time)
        {
            this.id_air = id_air;
            this.aircraft = aircraft;
            this.source_port = source_port;
            this.destination_port = destination_port;
            this.source_time = source_time;
            this.destination_time = destination_time;
        }

        public void Show()
        {
            Console.WriteLine($"{id_air}) Тип самолета: {aircraft} , {source_port} ---> {destination_port} , Время вылета: {source_time} , Время посадки: {destination_time} \n");
        }

        public void Marshrut_info()
        {
            Console.WriteLine($"{source_port} --> {destination_port}  Вылет из : {source_time} Пребытие : {destination_time}");
        }
    }

    class Freight  // Бұл класста қандай затты жөнелту керек және оны бағасы туралы ақпарат. Жалпы грузға байланысты класс.
    {
        // Жүк тасымалдаудың 2 түрі бар : 1) Контейнер арқылы  2) Қорап арқылы 
        
        public int conteiner_q_ty;           // Контейнер саны
        public int conteiner_weight;   // Контейнер салмағы
        public int box_volume;  // Қораптың көлемі. Өлшем бірлік м3
        public int box_weight;  // Қораптың салмағы
        public int box_q_ty;  //  Қораптың саны 
        public int total;      // Барлық тауардың соңғы бағасы
        public int select;    // Контейнер түрін таңдау үшін

        public int Conteiner() // Әдістің жүмысы : Егер клиент жүкті контейнерлермен жіберетін болса. Яғни жүк көлемі үлкен. (1т - 20т)
        {
            Console.WriteLine("\nВы выбрали услугу контейнерных грузоперевозок !\n");
            string[] conteiner_type = new string[] { "20 Стандарт","40 Стандарт", "20 Высокий куб" , "40 Высокий куб" , "20 Открытый верх" , "40 Открытый верх" };
            Console.Write("\nВведите количество контейнеров : "); 
            conteiner_q_ty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nТипы контейнеров !\n");
            int j = 1;
            for (int i=0; i < conteiner_type.Length; i++)
            {
                Console.WriteLine($"{j}) {conteiner_type[i]}"); 
                j=j+1;
            }
            Console.Write("\nВыберите тип контейнера : ");
            int select = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите вес контейнера (1т - 20т) : ");
            conteiner_weight = Convert.ToInt32(Console.ReadLine());

            if (conteiner_weight < 5)   // Жүктің салмағы 5т - дан төмен болса, әр тоннаға 300$ - дан болады. 
            {
                return total = conteiner_q_ty * conteiner_weight * 300;
            }
            else if ( conteiner_weight > 5 && conteiner_weight < 10) // Жүктің салмағы 5т - дан жоғары, 10т - дан кіші болса, әр тоннаға 500$ - дан болады.
            {
                return total = conteiner_q_ty * conteiner_weight * 500;
            }
            else if (conteiner_weight > 10 && conteiner_weight < 20)  // Жүктің салмағы 10т - дан жоғары, 20т - дан кіші болса, әр тоннаға 1000$ - дан болады.
            {
                return total = conteiner_q_ty * conteiner_weight * 1000;  
            }
            else
            {
                return total = conteiner_q_ty * conteiner_weight;
            }

        }

        public int Box() // Әдіс жұмысы : Егер клиент жүкті қораптар арқылы жібергісі келсе. Жүк салмағы кіші жағдай. ()
        {
            Console.WriteLine("\nВы выбрали услугу грузоперевозки через коробку !");
            Console.Write("\nВведите количество коробок : ");
            box_q_ty = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите объем коробки (м3): ");
            box_volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите вес коробки (10кг - 100кг): ");
            box_weight = Convert.ToInt32(Console.ReadLine());

            if(box_weight>10 && box_weight < 50)   // Жүктің салмағы 10кг мен 50кг аралығы болса, әр кг-ға 10$ болады.
            {
                return total = box_q_ty * box_weight * 10;
            }
            else if (box_weight > 50 && box_weight < 100)  // Жүктің салмағы 50кг мен 100кг аралығы болса, әр кг-ға 30$ болады.
            {
                return total = box_q_ty * box_weight * 30;
            }
            else
            {
                return total = box_q_ty*box_weight;
            }
            
        }

        public void Conteiner_info()
        {
            Console.WriteLine($"Количество : {conteiner_q_ty}  Вес : {conteiner_weight}т");
        }

        public void Box_info()
        {
            Console.WriteLine($"Количество : {box_q_ty}  Вес : {box_weight}кг");
        }

    }

    class Order_back  // Класс жұмысы : Клиент берген тапсырысын қайтарып алу қызметі. 
    {
        /* Егер клиент берген тапсырысын қайтарып алғысы келсе. Авиокомпания оның толық тапсырысқа кеткен
           ақшасының 10%-ын алып қалады. Себебі компания талабы солай болады. Егер клиент көп жүк тиеген болса
           көп шығынға ұшырайды.
        */

        Freight fr = new Freight();
        public double total_back;

        public double ClientTotal()
        {
            return total_back = fr.total - fr.total * 0.1;
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {


            Freight f = new Freight();
            Order_back o = new Order_back();
            Marshrut m = new Marshrut();


            List<Contact_information> client = new List<Contact_information>();

            client.Add(new Contact_information("Ceva Holdings LLC", "Bob","USA","+18557763836","ceva@gmail.com"));
            client.Add(new Contact_information("FedEx Corporation", "Trasy", "England", "+42347410014", "FedEx@gmail.com"));
            client.Add(new Contact_information("XPO Logistics, Inc.", "Lee", "Japan", "+87014957457", "XPO@gmail.com"));
            client.Add(new Contact_information("Kenco Group, Inc.", "Sayasat", "Kazakhstan", "+77779554544", "Kenco@gmail.com"));
            client.Add(new Contact_information("Deutsche Post DHL Group", "Lukas", "Spain", "+34040159110", "Post@gmail.com"));

            List<Marshrut> air_route = new List<Marshrut>();

            air_route.Add(new Marshrut(1, "AN 12", "Spain", "USA", new DateTime(2021, 03, 26, 17, 45, 00), new DateTime(2021, 03, 26, 20, 30, 00)));
            air_route.Add(new Marshrut(2, "IL – 76", "Kazakhstan", "Brazil", new DateTime(2021, 04, 10, 12, 53, 00), new DateTime(2021, 04, 30, 16, 10, 00)));
            air_route.Add(new Marshrut(3, "AN 124", "France", "China", new DateTime(2021, 04, 06, 20, 05, 00), new DateTime(2021, 04, 07, 03, 55, 00)));
            air_route.Add(new Marshrut(4, "B 737-400", "England", "Turkey", new DateTime(2021, 05, 28, 23, 50, 00), new DateTime(2021, 05, 28, 01, 20, 00)));
            air_route.Add(new Marshrut(5, "MD 11", "Japan", "Germany", new DateTime(2021, 06, 27, 12, 45, 00), new DateTime(2021, 06, 27, 13, 30, 00)));


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tАвиакомпания СИБ 18-2А\n");
            Console.ResetColor();
            Console.WriteLine("Добро пожаловать в наш отдел грузоперевозок !!!");
            Line();
            bool tr = true;
            while (tr)
            {
                Console.WriteLine("Нажмите 1, Если вы хотите воспользоваться услугой грузоперевозок.\nНажмите 2, Если вы хотите вернуть свой заказ.\nНажмите 3, Если вы хотите прекратить обслуживание.\n");
                int tanda = Convert.ToInt32(Console.ReadLine());

                if (tanda == 1 || tanda == 2 || tanda == 3)
                {
                    switch (tanda)
                    {
                        case 1:
                            Console.WriteLine("\nНиже приведены маршруты грузоперевозок нашей компании.\n");
                            Line();
                            foreach (var s in air_route)
                            {
                                s.Show();
                            }
                            Console.WriteLine("\nВыберите нужный вам маршрут грузоперевозки. \n");
                            int selectM = Convert.ToInt32(Console.ReadLine());
                            bool t = true;
                            while (t)
                            {
                                Console.WriteLine("\nКакой вид грузоперевозок вы хотите использовать. Наша компания предлагает :" +
                                    "\n 1) Услуги по перевозке грузов через Контейнер. Вес груза: от 1т до 20т. " +
                                    "\n 2) Услуги по перевозке грузов через коробку. Вес груза: от 10кг до 100кг.\n");

                                int selectF = Convert.ToInt32(Console.ReadLine());
                                if (selectF == 1) 
                                {
                                    f.Conteiner();
                                    client.Add(new Contact_information());
                                    Console.WriteLine();
                                    Line();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ПОДТВЕРЖДЕНИЕ БРОНИРОВАНИЯ !");
                                    Console.ResetColor();
                                    Line();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Заказчик");
                                    Console.ResetColor();
                                    client[5].Shygaru();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nИнформация о грузе. (Контейнер)");
                                    Console.ResetColor();
                                    f.Conteiner_info();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nМаршрут.");
                                    Console.ResetColor();
                                    air_route[selectM-1].Marshrut_info();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nОплата заказа.");
                                    Console.ResetColor();
                                    Console.WriteLine($"{f.total}$");
                                    Line();
                                    Console.WriteLine("Если вы подтвердите нажмите 1, если нет нажмите 2.\n");
                                    int selectP = Convert.ToInt32(Console.ReadLine());
                                    if (selectP == 1)
                                    {
                                        Console.WriteLine("\nСлужба выполнена успешно. Спасибо за доверие к нашей компании !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nБольшое спасибо, что выбрали нас !");
                                    }
                                    t = false;
                                }
                                else if (selectF == 2)
                                {
                                    f.Box();
                                    client.Add(new Contact_information());
                                    Console.WriteLine();
                                    Line();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ПОДТВЕРЖДЕНИЕ БРОНИРОВАНИЯ !");
                                    Console.ResetColor();
                                    Line();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Заказчик");
                                    Console.ResetColor();
                                    client[5].Shygaru();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nИнформация о грузе. (Коробка)");
                                    Console.ResetColor();
                                    f.Box_info();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nМаршрут.");
                                    Console.ResetColor();
                                    air_route[selectM-1].Marshrut_info();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nОплата заказа.");
                                    Console.ResetColor();
                                    Console.WriteLine($"{f.total}$");
                                    Line();
                                    Console.WriteLine("Если вы подтвердите нажмите 1, если нет нажмите 2.\n");
                                    int selectP = Convert.ToInt32(Console.ReadLine());
                                    if (selectP == 1)
                                    {
                                        Console.WriteLine("\nСлужба выполнена успешно. Спасибо за доверие к нашей компании !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nБольшое спасибо, что выбрали нас !");
                                    }

                                    t = false;
                                }
                                else { Console.WriteLine($"\nВы ввели ошибку (такого выбора нет : {selectF}). Введите снова !\n"); }
                            }

                            break;
                             
                        case 2:

                            if (f.total == 0) { Console.WriteLine("\nВы не воспользовались услугами нашей компании !\n"); }
                            else
                            {
                                Console.WriteLine("\nНапоминаем, что при отзыве заказа 10% от оплаченных средств остается на услуги нашей компании.");
                                Console.WriteLine($"\nВаши деньги, оплаченные за полный заказ : {f.total}$" +
                                    $"\n10% уплаченных денег комиссии банка : {f.total * 0.1}$" +
                                    $"\nВозвращенные вам деньги : {o.ClientTotal()}$\n");

                                Console.WriteLine("Большое спасибо, что выбрали нас !");
                            }
                            break;

                        case 3:

                            Console.WriteLine("\nБольшое спасибо, что выбрали нас !\n");

                            break;
                    }

                    tr = false;
                }

                else { Console.WriteLine($"\nВы ввели ошибку (такого выбора нет : {tanda}). Введите снова !\n"); }
            }

        }
        static void Line()
        {
            for (int i=0;i<80;i++)
            {
                Console.Write('-');
            }

            Console.WriteLine();
        }
    }
}
