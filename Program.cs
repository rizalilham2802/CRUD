using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 12) ";
            List<Karyawan> Tampung = new List<Karyawan>();
            int pilihan;
            do
            {
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Data Karyawan");
            Console.WriteLine("2. Hapus Data Karyawan");
            Console.WriteLine("3. Tampilkan Data Karyawan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();

            Console.Write("Nomor Menu [1..4] :");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Tambah Data Karyawan\n");
                    Console.WriteLine("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Seles] :");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (pilih)
                    {
                        case 1:
                            KaryawanTetap karyawanTetap = new KaryawanTetap();
                            Console.Write("NIK : ");
                            karyawanTetap.Nik = Console.ReadLine();
                            Console.Write("Nama : ");
                            karyawanTetap.Nama = Console.ReadLine();
                            Console.Write("Gaji Bulanan : ");
                            karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                            Tampung.Add(karyawanTetap);
                            break;
                        case 2:
                            KaryawanHarian karyawanHarian = new KaryawanHarian();
                            Console.Write("NIK : ");
                            karyawanHarian.Nik = Console.ReadLine();
                            Console.Write("Nama : ");
                            karyawanHarian.Nama = Console.ReadLine();
                            Console.Write("Jumlah Jam Kerja : ");
                            karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Upah Per Jam : ");
                            karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                            Tampung.Add(karyawanHarian);
                            break;
                        case 3:
                            Seles seles = new Seles();
                            Console.Write("NIK : ");
                            seles.Nik = Console.ReadLine();
                            Console.Write("Nama : ");
                            seles.Nama = Console.ReadLine();
                            Console.Write("Jumlah Penjualan :");
                            seles.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Komisi : ");
                            seles.Komisi = Convert.ToDouble(Console.ReadLine());
                            Tampung.Add(seles);
                            break;
                        default:
                            Console.WriteLine("Menu Yang Anda Masukkan Salah");
                            break;
                    }
                    break;
                case 2 :
                    int no = -1, hapus = -1;
                    Console.WriteLine("Hapus Data Karyawan\n");
                    Console.Write("NIK : ");
                    string nik = Console.ReadLine();
                    foreach (Karyawan karyawan in Tampung)
                    {
                        no++;
                        if(karyawan.Nik == nik)
                        {
                            hapus = no;
                        }
                    }
                    if (hapus != -1)
                    {
                        Tampung.RemoveAt(hapus);
                        Console.WriteLine("\nData Nik Berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("\nData Nik Tidak ditemukan");
                    }
                    
                    break;
                 case 3:
                        int NoUrut = 0;
                        string golongan=" ";
                        Console.WriteLine("Data Karyawan\n");
                        foreach (Karyawan karyawan in Tampung)
                        {
                            if(karyawan is KaryawanTetap)
                            {
                                golongan = "Karyawan Tetap";
                            }
                            else if(karyawan is KaryawanHarian)
                            {
                                golongan = "Karyawan Harian";
                            }
                            else
                            {
                                golongan = "Sales";
                            }
                            NoUrut++;
                            Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}, {4}", NoUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), golongan);
                        }
                        if (NoUrut < 1)
                        {
                            Console.WriteLine("Data Karyawan Kosong");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                        break;
                }
                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}
