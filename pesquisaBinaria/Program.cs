using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pesquisaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Usuários/1018998/Downloads/ecompletos.txt";

            Eleitor [] eleitores = new Eleitor[70304];

            string[] lines = File.ReadAllLines(@path);

            PesquisaBinaria funct = new PesquisaBinaria();

            int i = 0;

            foreach (string line in lines)
            {
                eleitores[i] = new Eleitor();
                string [] aux = line.Split('-');
                eleitores[i].name = aux[0];
                eleitores[i].gender = aux[1];
                eleitores[i].registrationNum = aux[2];
                eleitores[i].zone = int.Parse(aux[3]);
                eleitores[i].section = int.Parse(aux[4]);
                i ++;
            }

            Array.Sort(eleitores, (x, y) => String.Compare(x.name, y.name));
            Random random = new Random();
            int randomNumber = 0;
           
            int oneOp = 0;

            for (int j = 0; j < 10; j++) {
               randomNumber = random.Next(0, 70303);
                Console.WriteLine(funct.binarySearchName(0, eleitores.Length, eleitores[randomNumber].name, eleitores));
                oneOp = funct.eachOp;
               
            }
           
            Console.WriteLine(oneOp);
            Console.WriteLine("-------------------------------------------------------------");

            for (int j = 0; j < 10; j++) {
                randomNumber = random.Next(0, 70303);
                Console.WriteLine(funct.seqSearch(eleitores, eleitores[randomNumber].name));
                oneOp = funct.eachOp;
                
            }

          
            Console.WriteLine(oneOp);


            Console.ReadKey();



        }
    }
}
