using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Sort
{
    class Program
    {
        //deklaralasi array int dengan ukuran penambahan 2 nim terakhir + 10 + 20 + 20 - 2 x 15
        private int[] dewo = new int[26];
        //deklarasi variabel int untuk menyimpan banyak data
        private int n;

        //method untuk menerima masukan
        public void read()
        {
            //function menerima angka utuk menetukan banyaknya data yang disimpan dalam array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 26)
                    break;
                else
                    Console.WriteLine("\n Array hanya dapat menampung 26 elemen. \n");
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Masukkan elemen array");
            Console.WriteLine("----------------------");

            //pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dewo[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Element array yang sudah tersusun. ");
            Console.WriteLine("------------------------------------");
            //function untuk menampilkan array yang sudah tersusun
            for(int ed = 0; ed < n; ed++)
            {
                Console.WriteLine(dewo[ed]);

            }
            Console.WriteLine("");
        }
        public void SelectionSort()
        {
            //fungsi untuk passes  
            for(int j= 0; j <= n-2;j++)
            {
                //mendeklarasikan variabel tempat kosong dan min index
                int ed, temp;
                //mengubah min index menjadi variabel j
                ed = j;

                //fungsi untuk melihat isi array hingga akhir
                for(int i = j + 1; i <= n-1; i++)
                {
                    //fungsi jika ada nilai array i yang lebih rendah dari nilai array ed
                    if (dewo[i] < dewo[ed])
                    {
                        //maka ed memiliki nilai sama seperti i
                       ed = i ;
                    }                  
                }
                //memindahan min indeks ke tempat kosong
                temp = dewo[ed];
                //memindahkan nilai terkecil ke min indeks
                dewo[ed] = dewo[j];
                //memindahkan tempat kosong ke array kosong
                dewo[j] = temp;
            }
        }

        static void Main(string[] args)
        {
            //membuat objek untuk kelas program
            Program mylist = new Program();
            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            //pemanggilan fungsi untuk pengurutan array
            mylist.SelectionSort();
            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            //keluar
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar. ");
            Console.Read();
        }
    }
}
