using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım kampı", "java", "Python" };

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            } 
            
            foreach (string kurs in kurslar) 
            {  
                
                Console.WriteLine(kurs); 
            }


        }
    }
}
