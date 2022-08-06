using DayWeekApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }
        public DateTimeOffset UserDateOfBirth { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Hey, jestem botem który podaje dzień tygodnia na podstawie daty Twoich urodzin");
            Calculator = new DayCalculator();
        }
        public void AskUser()
        {
            Console.WriteLine("Podaj mi proszę datę urodzin");
            var userDate = Console.ReadLine();
            var succeded = DateTimeOffset.TryParse(userDate, out DateTimeOffset date);
            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("Podany format był zły. Proszę go podać w formie yyyy-dd-mm");
            AskUser();
        }
        public void CalculateTheDate()
        {
            if (UserDateOfBirth == null)
            {
                Console.WriteLine("Próbowano obliczyć dzień bez podania daty");
                return;
            }
            UserDayOfTheWeek = Calculator.CalculateTheDate(UserDateOfBirth);
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: " + UserDayOfTheWeek);
        }

    }
}
