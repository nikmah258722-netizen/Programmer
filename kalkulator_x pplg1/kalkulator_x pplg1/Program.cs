using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_x_pplg1
{
    internal class Program`
    {
        //Methot main adalah titik awal eksekusi program 
        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pilihan pengguna (y/n)

            // Perulangan do-while akan menjalankan blok kode setidaknya satu kali
            // dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                // Memanggil fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                // Variabel untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // Struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // Penjumlahan
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // Pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // Pembagian
                            // Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            break;
                        default: // Jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang Anda masukkan tidak valid.");
                            break;
                    }
                }

                Console.Write("\nHitung lagi? (y/n): ");
                hitungLagi = Console.ReadLine();

            } while (hitungLagi.ToLower() == "y");

            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini!");

        }


        // Fungsi untuk menampilkan menu
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        // Fungsi untuk mengambil input angka dan validasi
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            angka1 = 0;
            angka2 = 0;

            Console.Write("Masukkan angka pertama: ");
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
                return false;
            }

            return true; // jika kedua input valid
        }

        // Fungsi untuk operasi penjumlahan
        static double Tambah(double a, double b)
        {
            return a + b;
        }

        // Fungsi untuk operasi pengurangan
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        // Fungsi untuk operasi perkalian
        static double Kali(double a, double b)
        {
            return a * b;
        }

        // Fungsi untuk operasi pembagian
        static double Bagi(double a, double b)
        {
            return a / b;
        }
    }
}
        
    

