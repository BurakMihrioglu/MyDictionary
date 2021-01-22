using System;
using System.Collections.Generic;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sayilar = new MyDictionary<int, string>();
            sayilar.Add(1, "Bir");
            sayilar.Add(2, "İki");
            sayilar.Add(3, "Üç");
            sayilar.Add(4, "Dört");
            sayilar.Add(5, "Beş");
            sayilar.Add(6, "altı");
            sayilar.Add(7, "yedi");
            sayilar.Add(8, "Sekiz");
            sayilar.Add(9, "Dokuz");
            sayilar.Add(10, "On");
            sayilar.Add(11, "On bir");
            sayilar.Add(12, "On iki");
            sayilar.Add(13, "On üç");
            sayilar.Add(14, "On dört");
            sayilar.Add(15, "On beş");
            sayilar.Add(16, "On altı");
            sayilar.Add(17, "On yedi");
            sayilar.Add(18, "On sekiz");
            sayilar.Add(19, "On dokuz");
            sayilar.Add(20, "Yirmi");
            sayilar.Add(21, "Yirmi bir");
            sayilar.Add(22, "Yirmi iki");
            sayilar.Add(23, "Yirmi üç");
            sayilar.Add(24, "Yirmi dört");
            sayilar.Add(25, "Yirmi beş");
            sayilar.Add(26, "Yirmi altı");
            sayilar.Add(27, "Yirmi yedi");
            sayilar.Add(28, "Yirmi sekiz");
            sayilar.Add(29, "Yirmi dokuz");
            sayilar.Add(30, "Otuz");
            sayilar.Add(31, "Otuz bir");
            sayilar.Add(32, "Otuz iki");
            sayilar.Add(33, "Otuz üç");
            sayilar.Add(34, "Otuz dört");
            sayilar.Add(35, "Otuz beş");
            sayilar.Add(36, "Otuz altı");
            sayilar.Add(37, "Otuz yedi");
            sayilar.Add(38, "Otuz sekiz");
            sayilar.Add(39, "Otuz dokuz");
            sayilar.Add(40, "Kırk");
            sayilar.Add(41, "Kırk bir");
            sayilar.Add(42, "Kırk iki");
            sayilar.Add(43, "Kırk üç");
            sayilar.Add(44, "Kırk dört");
            sayilar.Add(45, "Kırk beş");
            sayilar.Add(46, "Kırk altı");
            sayilar.Add(47, "Kırk yedi");
            sayilar.Add(48, "Kırk sekiz");
            sayilar.Add(49, "Kırk dokuz");
            sayilar.Add(50, "Elli");
            sayilar.Add(51, "Elli bir");
            sayilar.Add(52, "Elli iki");
            sayilar.Add(53, "Elli üç");
            sayilar.Add(54, "Elli dört");
            sayilar.Add(55, "Elli beş");
            sayilar.Add(56, "Elli altı");
            sayilar.Add(57, "Elli yedi");
            sayilar.Add(58, "Elli sekiz");
            sayilar.Add(59, "Elli dokuz");
            sayilar.Add(60, "Altmış	");
            sayilar.Add(61, "Altmış bir");
            sayilar.Add(62, "Altmış iki");
            sayilar.Add(63, "Altmış üç");
            sayilar.Add(64, "Altmış dört");
            sayilar.Add(65, "Altmış beş");
            sayilar.Add(66, "Altmış altı");
            sayilar.Add(67, "Altmış yedi");
            sayilar.Add(68, "Altmış sekiz");
            sayilar.Add(69, "Altmış dokuz");
            sayilar.Add(70, "Yetmiş");
            sayilar.Add(71, "Yetmiş bir");
            sayilar.Add(72, "Yetmiş iki");
            sayilar.Add(73, "Yetmiş üç");
            sayilar.Add(74, "Yetmiş dört");
            sayilar.Add(75, "Yetmiş beş");
            sayilar.Add(76, "Yetmiş altı");
            sayilar.Add(77, "Yetmiş yedi");
            sayilar.Add(78, "Yetmiş sekiz");
            sayilar.Add(79, "Yetmiş dokuz");
            sayilar.Add(80, "Seksen");
            sayilar.Add(81, "Seksen bir");
            sayilar.Add(82, "Seksen iki");
            sayilar.Add(83, "Seksen üç");
            sayilar.Add(84, "Seksen dört");
            sayilar.Add(85, "Seksen beş");
            sayilar.Add(86, "Seksen altı");
            sayilar.Add(87, "Seksen yedi");
            sayilar.Add(88, "Seksen sekiz");
            sayilar.Add(89, "Seksen dokuz");
            sayilar.Add(90, "Doksan");
            sayilar.Add(91, "Doksan bir");
            sayilar.Add(92, "Doksan iki");
            sayilar.Add(93, "Doksan üç");
            sayilar.Add(94, "Doksan dört");
            sayilar.Add(95, "Doksan beş");
            sayilar.Add(96, "Doksan altı");
            sayilar.Add(97, "Doksan yedi");
            sayilar.Add(98, "Doksan sekiz");
            sayilar.Add(99, "Doksan dokuz");
            sayilar.Add(100, "Yüz");




            foreach (var sayi in sayilar.Keys)
            {
                Console.WriteLine(sayi);
            }

            foreach (var okunus in sayilar.Values)
            {
                Console.WriteLine(okunus);
            }

        }
    }
}