using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.WriteLine("Informe um número inteiro qualquer para somar seus múltiplos de 3 e 5:");
            val = Console.ReadLine();
            int num = Convert.ToInt32(val);
            int total = 0;           
            
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    total += i;
                }
                
            }

            Console.WriteLine("A soma dos múltiplos de 3 e 5 do número {0} é:{1}", num, total);


        }
    }
}
