using System;

namespace Авиакомпания123
{
    class Client
    {
        private string name; //Имя
        private string surname; //Фамилия
        private string iin; //Клиент ИИН-і
        public string phone; //Клиент телефон номері
        public Client() // Бос конструктор
        {
            this.name = "name";
            this.surname = "surname";
            this.IIN = "IIN";
            this.phone = "phone";
        }
        public Client(string name, string surname, string iin, string phone) //Параметрлі конструктор
        {
            this.name = name;
            this.surname = surname;
            this.iin = iin;
            this.phone = phone;
        }
        //set get қасиеттері
        public string Name
        {
            set
            {
                name = value.ToUpper();
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value.ToUpper();
            }
            get
            {
                return surname;
            }
        }
        public string IIN
        {
            set
            {
                if (value.Length == 12) //12сан болуы тиіс
                {
                    iin = value;
                }
                else
                {
                    Console.WriteLine("ИИН-іңіз қате");
                }
            }
            get
            {
                return iin;
            }
        }
        public void Bilet()
        {
            Console.WriteLine("Аты-жөні: " + Name+" "+Surname+"\nТелефон номері: "+phone);
        }
    }
    class Bilet //Билетте жазылу туратын ақпараттар
    {
        private string qaidan; //Ұшатын орыны
        private int qaida; //Түсетін орыны (Обылыс номерімен)
        private string data_ushu; //Ұшқан уақыты     
        private int jyk; //Озімен алып шыққан жүгінің салмағы
        private int klass; //Бизнес н/е Эконом класс
        public Bilet(int qaida, string data, int klass, int jyk)
        {
            qaidan = "Almaty";
            data_ushu = data;
            this.qaida = qaida;
            this.klass = klass;
            this.jyk = jyk;
        }
        public int baga;
        public double QorytyndyBaga() //Билеттің құны   
        {
            Console.WriteLine("01| Almaty → Dubai\n02| Almaty → Antalya\n03| Almaty → Pariz \n04| Almaty → Buxarest \n05| Almaty → Rim \n06| Almaty → Moskva \n07| Almaty → Minsk \n08| Almaty → Seul \n09| Almaty → Stambul \n10| Almaty → London");
            double jyk_baga;
            int klass_baga;
            switch (qaida)
            {
                case 01:
                    baga = 112475;
                    break;
                case 02:
                    baga = 180411;
                    break;
                case 03:
                    baga = 186102;
                    break;
                case 04:
                    baga = 187988;
                    break;
                case 05:
                    baga =195567;
                    break;
                case 06:
                    baga = 104895;
                    break;
                case 07:
                    baga = 122742;
                    break;
                case 08:
                    baga = 222171;
                    break;
                case 09:
                    baga = 151629;
                    break;
                case 10:
                    baga =218865;
                    break;
            }
            if(jyk>10)
            {
                jyk_baga = (jyk - 10) * 3500;
            }
            else
            {
                jyk_baga = 0;
            }       
            if(klass==1)
            {
                klass_baga = 125000;
            }
            else
            {
                klass_baga = 0;
            }
            return (double)(klass_baga + baga + jyk_baga);
        }       

        public void BILET()
        {
            string klasss;
            if (klass == 1)
            {
                klasss = "VIP";
            }
            else
            {
                klasss = "Эконом";
            }
            Console.WriteLine("Откуда: Almaty;\nКудa: "+qaida+"\tКласс: "+klasss+"\tБагаж= "+jyk+"\nОбщая стоимость: "+QorytyndyBaga()+" тг");
        }              
    }
    class Rasxod
    {
        public int reis_sany; //рейс саны
        private int toplivo; //Жанаржағар май
        private int eda; //Самолетта берілетін тамақ
        private int zp; //Сотрудниктердің зарплатасы
        private int remont; //Самолеттің запчастьтары немесе аэропорт ремонты
        private int melkie_rasxody; //Әр түрлі тазалыққа арналған расходтар
        public Rasxod(int reis_sany)
        {
            this.reis_sany = reis_sany;
            toplivo = 3000000;
            eda = 700000;
            zp = 40000000;
            remont = 5000000;
            melkie_rasxody = 1000000;
        }
        public int Rasxod_esep()
        {
            return (int)((eda + toplivo + melkie_rasxody + remont) * reis_sany + zp);
        }
    }
    class Sotrudnik
    {
        private string name;
        private string surname;
        private int Letchik_zp;
        private int Dispetcher_zp;
        private int Vtoroi_letchik_zp;
        private int Styardessa_zp;
        private int Ostalnye_zp;
        public Sotrudnik(string name, string surname) //Параметрлі конструктор
        {
            this.name = name;
            this.surname = surname;
            Letchik_zp = 4500000;
            Dispetcher_zp = 900000;
            Vtoroi_letchik_zp = 2000000;
            Styardessa_zp = 450000;
            Ostalnye_zp = 20000000;
        }
        //set get қасиеттері
        public string Name
        {
            set
            {
                name = value.ToUpper();
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value.ToUpper();
            }
            get
            {
                return surname;
            }
        } 
        public int Zarplata()
        {
            return (int)((Letchik_zp + Vtoroi_letchik_zp) * 10+(Styardessa_zp*30)+Dispetcher_zp*15+Ostalnye_zp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int vxod;
            Console.WriteLine("Добро пожаловать :)"); //www.aviacompany.com деген сайтқа кірген секілді
            Console.WriteLine("Если вы Клиент нажмите 1\nЕсли вы Сотрудник нажмите 0\nЕсли вы директор введите пароль"); //
            vxod = Convert.ToInt32(Console.ReadLine());
            if (vxod == 1)
            {

            }
            else if (vxod==2111)
            {

            }
            else
            {

            }

        }
    }
}

