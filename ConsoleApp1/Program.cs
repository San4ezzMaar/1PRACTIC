using System;

namespace Prakticheskaya19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Box box = new Box();

            box.Width = 2;
            box.Height = 3;
            box.Length = 5;

            box.Show();

            Console.WriteLine($"Объем коробки: {box.Volume()} куб. ед.");
            Console.ReadKey();
        }
    }
    class Box
    {
 
        public float Height;
        public float Width;
        public float Length;
  
        public void Show()
        {
            Console.WriteLine("Данные о коробке:");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Длина: {Length}");
        }
     
        public float Volume()
        {
            return Width * Height * Length;
        }
    }
}