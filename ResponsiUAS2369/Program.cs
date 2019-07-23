using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiUAS2369
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();
        static Produk prod = new Produk();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS 2369 Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Hapus produk");
            Console.WriteLine("3. Tampilkan produk");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            prod = new Produk();
            Console.WriteLine("Tambah data prdoduk");
            Console.Write("Kode Produk   : ");
            prod.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk   : ");
            prod.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli  : ");
            prod.HargaBeli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual   : ");
            prod.HargaJual = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(prod);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            string kodep = Console.ReadLine();
            var itemRemove = daftarProduk.SingleOrDefault(f => f.KodeProduk == kodep);
            if (itemRemove == null)
            {
                Console.WriteLine("Kode Produk Tidak Ditemukan");
            }
            else
            {
                daftarProduk.Remove(itemRemove);
                Console.WriteLine();
                Console.WriteLine("Data Produk Berhasil Dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Produk\n");
            foreach (Produk objProd in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4}", no, objProd.KodeProduk, objProd.NamaProduk, objProd.HargaBeli, objProd.HargaJual);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
