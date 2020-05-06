using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labos3
{
    //Zad4, zad6, zad7
    public enum Category { ERROR, ALERT, INFO }

    class ConsoleNotification : IPrototype
    {

        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        public IPrototype Clone()
        {
            ConsoleNotification clone = (ConsoleNotification)this.MemberwiseClone();
            return clone;

        }
        //7. u konkretnom slučaju razlike između plitkog i dubokog kopiranja nema 
    }
}
