using System;

namespace Activity2 { 
      public class Cigar
    {
        public string Brand;
        public string Class;
        public int Price;


        static void Main(string[] args)
        {
            List<Cigar> list = new List<Cigar>();

            while (true)
            {
                Console.WriteLine(" Enter new data [Y/N]");

                if(Console.ReadLine() == "N")
                {
                    break;
                }

               Cigar cigar1 = new Cigar();

                Console.WriteLine(" Enter Cigarette Brand : ");
                cigar1.Brand = Console.ReadLine();

                Console.WriteLine(" Enter Cigarette Class (Red Or Menthol) : ");
                cigar1.Class = Console.ReadLine();

                Console.WriteLine(" Enter Cigarette Price : ");
                cigar1.Price = int.Parse(Console.ReadLine());

                list.Add(cigar1);

            }

            list.ForEach(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Class);
                Console.WriteLine(x.Price);
                Console.WriteLine("================================");
            });
        }
    }
}


    