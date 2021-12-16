using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre JAVA", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre JS", "orientacao-objetos"));

            // foreach (var article in articles)
            // {
            //     Console.Write(article.Id);
            //     Console.Write(article.Title);
            //     Console.Write(article.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos");
            var courseJAVA = new Course("Fundamentos JAVA", "fundamentos");
            var courseJS = new Course("Fundamentos JS", "fundamentos");
            courses.Add(courseOOP);
            courses.Add(courseJAVA);
            courses.Add(courseJS);



            var careers = new List<Career>();
            var careerDotNet = new Career("Especialisata .NET", "especialista-dotnet");
            var carrerItem2 = new CareerItem(1, "Comece por aqui", "", courseJS);
            var carrerItem = new CareerItem(2, "Depois java", "", courseJAVA);
            var carrerItem3 = new CareerItem(3, "Comece e OOP", "", null);
            careerDotNet.Items.Add(carrerItem);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }

        }
    }
}
