using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length, Karakter uzunluğu.
            Console.WriteLine(degisken.Length);

            //ToUpper, büyük karaktere çevirir. ToLower, küçük karaktere çevirir.
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat, verdiğimiz değişken ile verilen string i birleştirir.
            Console.WriteLine(string.Concat(degisken,"Merhaba!"));

            //Compare, verilen iki değişkeni karşılaştırır, true veya false verilmesine göre büyük-küçük harf duyarlılığı olur. CompareTo, verilen değişken ile karşılaştırır ve değer döndürür.
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains, değişkenin içerisinde olup olmadığını bool döndürür.
            Console.WriteLine(degisken.Contains(degisken2));
            
            //StartsWith, verdiğimiz char veya string ifadenin değişkenin başlangıcında olup olmadığını döndürür. EndsWith ise değişkenin sonunda olup olmadığını döndürür.
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf, verilen ifadenin, var ise index değerinin döndürür. Yoksa -1 verir.
            Console.WriteLine(degisken.IndexOf("CS"));

            //LastIndexOf, sondan başlayarak verien ifadeyi arar ve varsa index i döndürür.
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert, başlangıç index i verilir, sonrasında verilen ifade, indexten itibaren ekler.
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            //PadRight, PadLeft, değişkenin soluna verilen uzunluk ile değişken uzunluğunun farkı kadar(verilen uzunlukk - değişken uzunluğu) boşluk veya verilen karakteri ekler. 
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50) + degisken2);

            //Remove, verilen indexten son index e kadar olanları siler.
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));// verilen indexten, verilen count kadar siler.
            Console.WriteLine(degisken.Remove(0,1));// verilen indexten, verilen count kadar siler.

            //Replace, değişkenin içerisinde bulunan bir ifadeyi verilen yeni ifadeye dönüştürür.
            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //Split, verilen ifadeye göre parçala ve bir diziye aktar.
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring, verilen indexten itibaren getirir.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
