using System;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Radio and TV
            /* Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.SwitchOn();
            myTV.WatchTV(); */
            #endregion

            #region Animals
            /*Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();*/
            #endregion

            #region Post
            /*Post post1 = new Post("Thanks for Being a good Friend", true, "Kenneth Murithi");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my latest software","Kenneth Murithi", "https://idrinns.com/softwares",true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check out my latest video", "Kenneth Murithi", "https://idrinns.com/videos", true,10);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadKey(); */
            #endregion

            #region Employees
            Employee dennis = new Employee("Mwenda","Dennis", 50000);
            dennis.Work();
            dennis.Pause();

            Boss haveySpecter = new Boss("Ferrari","Specter", "Havey", 1000000);
            haveySpecter.Lead();

            Trainee ken = new Trainee(32, 8, "Kenneth", "Murithi", 10000);
            ken.Learn();
            ken.Work(); 


            Console.ReadKey();
            #endregion
        }
    }
}
