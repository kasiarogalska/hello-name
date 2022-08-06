using DayWeekApp.Core;
using System;

namespace DayWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUser();
            guesser.CalculateTheDate();
            guesser.PrintDayOfTheWeek();
        }
    }
}
