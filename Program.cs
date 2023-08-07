using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // tạo đối tượng
            // có kiểu Dictionary
            Dictionary<string, string> dt_TuDien = new Dictionary<string, string>();

            // thêm phần tử
            // vào trong từ điển
            dt_TuDien.Add("Trang 1", "Hello World");
            dt_TuDien.Add("Trang 2", "Lap trinh .NET");
            dt_TuDien.Add("Trang 3", "Su dung lop Dictionary<T,T>");

            // in dữ liệu ra màn hình
            Console.WriteLine("---------- HIEN THI DU LIEU ----------");
            for (int i = 1; i <= dt_TuDien.Count(); i++)
            {
                Console.WriteLine(dt_TuDien[$"Trang {i}"]);
            }
        }
    }
}