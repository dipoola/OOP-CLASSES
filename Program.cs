namespace OOP___CLASSES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.name = "The cook";
            chef.meal = "pastrami rice";


        }

        class Chef {
         public   string name { get; set; }
          public   string meal { get; set; }


           


            void cooking()
            {
                Console.WriteLine("This is the real chef cooking different delecases");
            }


            class italianchef:Chef
                {
                virtual void  specailDishes() 
                {
                    Console.WriteLine("this is another italian  chef agent cooking pastami rice");

                }


                }
        }

    }

}