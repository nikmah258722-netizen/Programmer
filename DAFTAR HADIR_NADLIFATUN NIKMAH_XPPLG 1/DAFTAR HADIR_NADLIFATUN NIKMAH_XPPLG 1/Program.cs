using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAFTAR_HADIR_NADLIFATUN_NIKMAH_XPPLG_1
{
    internal class Program
    {
        // Struktur data untuk menyimpan nama siswa dan status kehadiran
        class Siswa
        {
            public string Nama { get; set; }
            public string Status { get; set; }  // Hadir / Izin / Sakit / Alfa
        }

        static void Main(string[] args)
        {
            List<Siswa> daftarHadir = new List<Siswa>();
            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("        APLIKASI DAFTAR HADIR SISWA");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Tambah Data Kehadiran");
                Console.WriteLine("2. Tampilkan Daftar Hadir");
                Console.WriteLine("3. Hitung Rekap Kehadiran");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("========================================");
                Console.Write("Pilih menu (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out pilihan))
                    pilihan = 0;

                switch (pilihan)
                {
                    case 1:
                        TambahData(daftarHadir);
                        break;
                    case 2:
                        TampilkanData(daftarHadir);
                        break;
                    case 3:
                        HitungRekap(daftarHadir);
                        break;
                    case 4:
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid! Coba lagi.");
                        break;
                }

                if (pilihan != 4)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
                    Console.ReadLine();
                }

            } while (pilihan != 4);
        }

        // ==================== Fungsi Tambah Data ====================
        static void TambahData(List<Siswa> daftar)
        {
            Console.Clear();
            Console.WriteLine("=== Tambah Data Kehadiran ===");
            Console.Write("Masukkan Nama Siswa : ");
            string nama = Console.ReadLine();

            Console.WriteLine("Pilih Status Kehadiran:");
            Console.WriteLine("1. Hadir");
            Console.WriteLine("2. Izin");
            Console.WriteLine("3. Sakit");
            Console.WriteLine("4. Alfa");
            Console.Write("Masukkan pilihan (1-4): ");
            string status = "";

            switch (Console.ReadLine())
            {
                case "1":
                    status = "Hadir";
                    break;
                case "2":
                    status = "Izin";
                    break;
                case "3":
                    status = "Sakit";
                    break;
                case "4":
                    status = "Alfa";
                    break;
                default:
                    status = "Tidak Diketahui";
                    break;
            }

            daftar.Add(new Siswa { Nama = nama, Status = status });
            Console.WriteLine("\nData berhasil ditambahkan!");
        }

        // ==================== Fungsi Tampilkan Data ====================
        static void TampilkanData(List<Siswa> daftar)
        {
            Console.Clear();
            Console.WriteLine("=== Daftar Kehadiran ===");

            if (daftar.Count == 0)
            {
                Console.WriteLine("Belum ada data kehadiran yang dimasukkan.");
                return;
            }

            int no = 1;
            foreach (var s in daftar)
            {
                Console.WriteLine($"{no}. {s.Nama,-15} | Status: {s.Status}");
                no++;
            }
        }

        // ==================== Fungsi Hitung Rekap ====================
        static void HitungRekap(List<Siswa> daftar)
        {
            Console.Clear();
            Console.WriteLine("=== Rekap Kehadiran ===");

            if (daftar.Count == 0)
            {
                Console.WriteLine("Belum ada data untuk direkap.");
                return;
            }

            int hadir = 0, izin = 0, sakit = 0, alfa = 0;

            foreach (var s in daftar)
            {
                switch (s.Status.ToLower())
                {
                    case "hadir": hadir++; break;
                    case "izin": izin++; break;
                    case "sakit": sakit++; break;
                    case "alfa": alfa++; break;
                }
            }

            Console.WriteLine($"Total Siswa     : {daftar.Count}");
            Console.WriteLine($"Hadir           : {hadir}");
            Console.WriteLine($"Izin            : {izin}");
            Console.WriteLine($"Sakit           : {sakit}");
            Console.WriteLine($"Alfa            : {alfa}");
        }
    }
}
