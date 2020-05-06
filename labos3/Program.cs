using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labos3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad1
            //DataSet dataset = new DataSet();
            //var newdataset = dataset.Clone();
            //dataset.LoadDataFromCSV(@"C:\Users\Elena\Source\Repos\labos3\labos3\bin\Debug\LV3");
            //Console.WriteLine(dataset.PrintList());

            //Zad2
            //double[][] matrix = MatrixGenerator.GetInstance().GenerateMatrix(5, 5);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matrix[i][j].ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Zad3
            //Logger.GetInstance().LogToFile("\nUpis teksta");

            //Zad4
            ConsoleNotification notification = new ConsoleNotification("Elena", "simpex", "text", DateTime.Now, Category.INFO, ConsoleColor.Magenta);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}







