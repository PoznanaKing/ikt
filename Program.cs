using System;

namespace ConsoleApp2
{
    class Program
    {
        static bool Van_e_szam(string password)
        {
        
        bool s = false;
        string chs = "0123456789";
        int i = 0;
        while ((!s)&&(i<chs.Length))
            {
                if (password.IndexOf(chs[i])>=0)
                {
                    s = true;
                }
                i++;
            }
            return (s);
            
        }
        static bool Van_e_kisbetu(string password)
        {
            bool s = false;
            string chs = "öüóqwertzuiopőúasdfghjkléáűíyxcvbnm";
            int i = 0;
            while ((!s) && (i < chs.Length))
            {
                if (password.IndexOf(chs[i]) >= 0)
                {
                    s = true;
                }
                i++;
            }
            return (s);

        }
        static bool Van_e_nagybetu(string password)
        {
            bool s = false;
            string chs = "ÖÜÓQWERTZUIOPŐÚASDFGHJKLÉÁŰÍYXCVBNM";
            int i = 0;
            while ((!s) && (i < chs.Length))
            {
                if (password.IndexOf(chs[i]) >= 0)
                {
                    s = true;
                }
                i++;
            }
            return (s);

        }
        static double mer (int hossz,string password)
        {
            DateTime a =DateTime.Now;
            Van_e_kisbetu(password);
            Van_e_nagybetu(password);
            Van_e_szam(password);
            DateTime b = DateTime.Now;

            TimeSpan c = b - a;
            return (c.TotalSeconds);
        }
        static double mer1(int hossz, string password)
        {
            DateTime a = DateTime.Now;
            Van_e_kisbetu(password);
            Van_e_nagybetu(password);
            Van_e_szam(password);
            DateTime b = DateTime.Now;

            TimeSpan c = b - a;
            return (c.TotalMinutes);
        }
        static double mer2(int hossz, string password)
        {
            DateTime a = DateTime.Now;
            Van_e_kisbetu(password);
            Van_e_nagybetu(password);
            Van_e_szam(password);
            DateTime b = DateTime.Now;

            TimeSpan c = b - a;
            return (c.TotalHours);
        }
        static double mer3(int hossz, string password)
        {
            DateTime a = DateTime.Now;
            Van_e_kisbetu(password);
            Van_e_nagybetu(password);
            Van_e_szam(password);
            DateTime b = DateTime.Now;

            TimeSpan c = b - a;
            return (c.TotalDays);
        }
        static double mer4(int hossz, string password)
        {
            DateTime a = DateTime.Now;
            Van_e_kisbetu(password);
            Van_e_nagybetu(password);
            Van_e_szam(password);
            DateTime b = DateTime.Now;

            TimeSpan c = b - a;
            return (c.TotalDays*365);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A jelszó: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Van-e számjegy: {Van_e_szam(password)}\nVan-e kisbetű: {Van_e_kisbetu(password)}\nVan-e nagybetu: {Van_e_nagybetu(password)}");

            int hossz = password.Length;
            long s = 0;
            if (Van_e_szam(password))
            {
                s += 10;
            }
            if (Van_e_kisbetu(password))
            {
                s += 35;
            }
            if (Van_e_nagybetu(password))
            {
                s += 35;
            }
            
            
            double muveletek = Math.Pow(s, hossz);

            Console.WriteLine($"Az időtényező: {(mer(hossz, password) * s) *muveletek/1} Másodperc");
            Console.WriteLine($"Az időtényező: {(mer1(hossz, password) * s) * muveletek / 1000} Perc");
            Console.WriteLine($"Az időtényező: {(mer2(hossz, password) * s) * muveletek / 10000} Óra");
            Console.WriteLine($"Az időtényező: {(mer3(hossz, password) * s) * muveletek / 100000} Nap");
            Console.WriteLine($"Az időtényező: {(mer4(hossz, password) * s) * muveletek / 1000000} Év");
        }
    }
}
