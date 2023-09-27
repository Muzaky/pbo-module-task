
using laptop;
using processor;


laptop.Laptop laptop1 = new laptop.Laptop();
laptop1 = new laptop.VIVOBOOK();
laptop1.vga = new Nvidia();
laptop1.processor = new Corei5();

laptop.Laptop laptop2 = new laptop.Laptop();
laptop2 = new laptop.IdeaPad();
laptop2.vga = new AMD();
laptop2.processor = new Ryzen();

laptop.Predator predator = new laptop.Predator();
predator = new laptop.Predator();
predator.vga = new AMD();
predator.processor = new Corei7();

Console.WriteLine("No.1 :");
laptop2.LaptopDinyalakan();
laptop2.LaptopDimatikan();

Console.WriteLine("No.2 :");
//laptop1.Ngoding();
Console.WriteLine("tidak jalan karena ngoding() tidak ada pada method tipedata laptop");

Console.WriteLine("No.3 :");
Console.WriteLine(laptop1.vga.merk);
Console.WriteLine(laptop1.processor.merk);
Console.WriteLine(laptop1.processor.tipe);

Console.WriteLine("No.4 :");
predator.BermainGame();

Console.WriteLine("No. 5");
laptop.ACER acer = new laptop.ACER();
acer = new laptop.Predator();
//acer.bermaingame();
Console.WriteLine("Codename : CS1061 = Eror)");

namespace laptop
{
    public class Laptop
    {
        public string merk, tipe;
        public VGA vga;
        public processor.Processor processor;


        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }


    }
    public class LENOVO : Laptop
    {
        public LENOVO()
        {
            merk = "LENOVO";
        }
    }

    public class IdeaPad : LENOVO
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }

    public class Legion : LENOVO
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }

    public class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    public class VIVOBOOK : ASUS
    {
        public VIVOBOOK()
        {
            tipe = "VIVOBOOK";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }

    public class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }

    public class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
}



namespace processor
{
    public class Processor
    {
        public string merk, tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            merk = "intel";
        }
    }
    public class Corei3 : Intel
    {
        public Corei3()
        {
            tipe = "core i3";
        }
    }
    public class Corei5 : Intel
    {
        public Corei5()
        {
            tipe = "core i5";
        }
    }
    public class Corei7 : Intel
    {
        public Corei7()
        {
            tipe = "core i7";
        }
    }

    public class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "Rayzen";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "Athlon";
        }
    }
}

public class VGA
{
    public string merk;
}

public class Nvidia : VGA
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

public class AMD : VGA
{
    public AMD()
    {
        merk = "AMD";
    }

}

