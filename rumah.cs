using System;
using System.Linq;
using System.Collections.Generic;

namespace Latihan
{
    class Home 
    {         
    	static public bool PlayAgain()
        {
    	while(true)
    	{
    		Console.WriteLine("\nMembeli produk lainnya?");
    		Console.WriteLine("[Y] Membeli produk lainnya");
    		Console.WriteLine("[N] Cukup");
    		Console.Write("");
            string answer = Console.ReadLine().ToUpper();
    		if (answer == "Y")
                return true;
            if (answer == "N")
               return false;
    	}
        }
        public void home()
        {
        	do
        	{
        	int jawaban_kategori;
        	Console.WriteLine("\nkategori");
        	Console.WriteLine("1. Fashion");
        	Console.WriteLine("2. Tas");
        	Console.WriteLine("3. Sepatu");
        	Console.WriteLine("Pilihlah produk diatas");
        	do
        	{
        		Console.Write("");
        	    jawaban_kategori = Int32.Parse (Console.ReadLine());
        	}
        	while(jawaban_kategori < 1 || jawaban_kategori> 3);
        	if (jawaban_kategori == 1)
        	{
        		Fashion kategori = new Fashion();
        		kategori.fashion();
        	}
        	if (jawaban_kategori == 2)
        	{
        		Tas kategori = new Tas();
        		kategori.tas();
        	}
        	if (jawaban_kategori == 3)
        	{
        		Sepatu kategori = new Sepatu();
        		kategori.sepatu();
        	}
        	}
        	while(PlayAgain());
        }
    }
}