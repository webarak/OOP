using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._22_23
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook book = new PhoneBook(2);
            Entry en1 = new Entry("shahf", "mor", "590435843");
            Entry en2= new Entry("segev", "mor", "75243432");
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nYour Electronic Phone Book.");
                Console.WriteLine("Please choose an opration code from menu:");
                Console.WriteLine("1.\tAdd an entery\n2.\tDelete an entry\n3.\tFind an entry\n4.\tPrint phonebool\n5.\tQuit\n");
                Console.WriteLine("Please select the operation code (see output window):");
                int operatin = int.Parse(Console.ReadLine());

                switch(operatin)
                {
                    case 1:
                        Console.WriteLine(book.addEntry(en1));
                        Console.WriteLine(book.addEntry(en2));
                        break;
                    case 2:
                        Console.WriteLine(book.deleteEntry(en1));
                        break;
                    case 3:
                        Console.WriteLine(book.searchPhone("segev", "mor"));
                        break;
                    case 4:
                        Console.WriteLine(book.ToString());
                        break;
                    case 5: quit = true;
                        break;
                    default: Console.WriteLine("illeagal operatin code.");
                        break;
                }
            }
        }
    }
}
