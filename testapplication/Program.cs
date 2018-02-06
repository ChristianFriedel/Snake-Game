using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapplication
{
    public class Snake
    {
        private int height = 1;
        private int width = 1;
        private double speed = 1.0;
        private string direction;
        private List<Food> body;

        public void Move()
        {

        }

    }

    public class Food
    {
        private int GrowRate = 1;
        private string type;

        public void Spwan()
        {

        }

    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Das wird mal ein Konsolen-Snake");
        }
    }
}
