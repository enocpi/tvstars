using System;

namespace tvstar
{
    class Program : application
    {
        static void Main(string[] args)
        {
            house_hunter applicant = new house_hunter("omar", "smith", 2 / 4 / 1975, "111 bravo way", "LA", "cali", 90001,
                888123123, "omar.smaith@hotmail.com", "web dev", 1000000, "6 months", 3, 2);

            applicant.submit();
            applicant.accept();
               

            paradise_island pd = new paradise_island("patti", "johnson", 5 / 4 / 1994, "211 love rd", "LA", "Cali", 90001, 988444134, "patti.johnson@gmail.com", "female", "carl", 2);
            pd.submit();
            pd.accept();

            above_deck ad = new above_deck("captin", "lee", 7 / 12 / 1964, "311 Bravo way", "la", "cali", 60032, 12312234, "cap.lee@mail.com", 20, "american");
            ad.submit();
            ad.accept();
           
           

        }
                
    }
}
