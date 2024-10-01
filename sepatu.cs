using System;

using System.Linq;

using System.Collections.Generic;

namespace Latihan
{
    class Sepatu
    {         
        public void sepatu()
        {
        	string[] nama = new string[4];
            nama[0]="Tidak ada";
            nama[1]="Geoff Max";    
            nama[2]="Pierro";    
            nama[3]="NAH Project";    
            int[] harga = new int[4];    
            harga[0]=0;    
            harga[1]=9000000;    
            harga[2]=8000000;    
            harga[3]=7000000;
            int jawaban1;
            int jawaban2;
            
            Console.WriteLine("\nFashion");
            Console.WriteLine("1. {0} dengan harga {1}",nama[1],harga[1]);                                             
            Console.WriteLine("2. {0} dengan harga {1}",nama[2],harga[2]);                                             
            Console.WriteLine("3. {0} dengan harga {1}",nama[3],harga[3]); 
            Console.WriteLine("0. Kembali");
            Console.WriteLine("Pilih barang yang akan di beli");
            do 
            {
                Console.Write("");
                jawaban1=Int32.Parse(Console.ReadLine());
            }
            while(jawaban1 < 0 || jawaban1 > 3);
            if (jawaban1 == 0)
            {
                Home fashion = new Home();
    	        fashion.home();
            }
            Console.WriteLine("\nIngin tambah produk lagi? ");
            Console.WriteLine("[0] Tidak ada");
            Console.WriteLine("ketik kode nomor produk jika ingin menambah produk lagi");
            do
            {
                Console.Write("");
                jawaban2=Int32.Parse(Console.ReadLine());
            }
            while(jawaban2 <0 || jawaban2>3);
            if (jawaban2 == 0)
            {
                Console.WriteLine("\nAnda membeli {0} dengan harga {1}", nama[jawaban1], harga[jawaban1]);
            }
            if (jawaban2 == jawaban1)
        	{
        		int jumlah = harga[jawaban1]+harga[jawaban2];
                int jumlah2 = jumlah * 10/100;
                int jumlah3 = jumlah - jumlah2;
        		Console.WriteLine("\nAnda membeli 2 buah {0} dengan diskon 10%, harga {1}", nama[jawaban1], jumlah3);
        	}
            if (jawaban2 != jawaban1 && jawaban2 != 0)
            {
                int jumlah = harga[jawaban1]+harga[jawaban2];
                int jumlah2 = jumlah * 10/100;
                int jumlah3 = jumlah - jumlah2;
                Console.WriteLine("\nAnda membeli {0} dan {1} dengan diskon 10%, harga {2}", nama[jawaban1], nama[jawaban2], jumlah3);
            }
        }
    }
}