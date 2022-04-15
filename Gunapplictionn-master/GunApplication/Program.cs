using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApplication.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine(@" __      __       .__                            
/  \    /  \ ____ |  |   ____  ____   _____   ____  
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \ 
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/ 
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >
       \/       \/          \/            \/     \/ ");
            Sniper[] mysniperarray = new Sniper[10];
            Smg[] mysmgarray = new Smg[10];
            Pistol[] mypistolarray = new Pistol[10];
            Assaultriffle[] myassaultarray = new Assaultriffle[10];
            Sniper snip1 = new Sniper("Karabiner-98", 1500, "7.62", 4, 760, 0.5, 60);
            Sniper snip2 = new Sniper("M24", 2599.9, "7.62", 6, 1300, 0.8, 72);
            Smg smg1 = new Smg("P90", 1999.99, "5.7×28mm", 50, 1100, 0.7, 100);
            Smg smg2 = new Smg("Uzi", 1799.99, "9mm", 30, 1200, 0.8, 120);
            Pistol pistol1 = new Pistol("DeserEagle", 900, "50Caliber", 9, 470, 0.4, 45);
            Pistol pistol2 = new Pistol("AkdalGhost", 500, "9×19mm", 15, 300, 0.3, 30);
            Assaultriffle assault1 = new Assaultriffle("Ak-47", 1200, "7.62×39mm", 30, 715, 0.3, 90);
            Assaultriffle assult2 = new Assaultriffle("Scar", 1900, "5.56×45mm", 30, 840, 0.6, 120);
            mysniperarray[0] = snip1;
            mysniperarray[1] = snip2;
            mysmgarray[0] = smg1;
            mysmgarray[1] = smg2;
            mypistolarray[0] = pistol1;
            mypistolarray[1] = pistol2;
            myassaultarray[0] = assault1;
            myassaultarray[1] = assult2;
            void inputmethod()
            {
                Console.WriteLine("1-Sniper guns");
                Console.WriteLine("2-Smg type guns");
                Console.WriteLine("3-Pistol type guns");
                Console.WriteLine("4-AssaultRiffle type guns");
                Console.Write("Enter the answer:");
            }
            int snipindex = 1;
            int smgindex = 1;
            int pistolindex = 1;
            int assaultindex = 1;

            while (true)
            {
                Console.WriteLine("What do you want?");
                Console.WriteLine("1-look at the information on guns ");
                Console.WriteLine("2-Add a gun");
                Console.WriteLine("3-Choose a gun for fire");
                Console.WriteLine("4-Delete gun");
                Console.WriteLine("Click Quit for exit");
                Console.Write("Write answer:");
                string answer = Console.ReadLine();
                #region showinfo
                if (answer == "1")
                {
                    Console.WriteLine("what type of gun do you want to see?");
                    inputmethod();
                    string input = Console.ReadLine();
                    Console.WriteLine("--");
                    Console.Clear();
                    if (input == "1")
                    {
                        foreach (var item in mysniperarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoSnipper());
                                Console.WriteLine("--");
                            }                          
                        }
                    }
                    else if (input == "2")
                    {
                        foreach (var item in mysmgarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoSmg());
                                Console.WriteLine("--");
                            }
                        }
                    }
                    else if (input == "3")
                    {
                        foreach (var item in mypistolarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoPistol());
                                Console.WriteLine("--");
                            }
                        }
                    }
                    else if (input == "4")
                    {
                        foreach (var item in myassaultarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoAssaultRiffle());
                                Console.WriteLine("--");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Make the right choice!");
                    }
                }
                #endregion
                #region addinfo
                else if (answer == "2")
                {
                    Console.Clear();
                    Console.WriteLine("what type of gun do you want to add?");
                    inputmethod();
                    string answer2 = Console.ReadLine();
                    Console.WriteLine("---------------");
                    if (answer2 == "1")
                    {
                        Console.Clear();

                    Tryagain:
                        try
                        {
                            snipindex++;
                            Console.Write("Enter sniper name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter Sniper price:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the name of the sniper's bullet:");
                            string bulletname = Console.ReadLine();
                            Console.Write("Enter the sniper's magazine capacity:");
                            int magazinecapacity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet speed: ");
                            int bulletspeed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet price:");
                            double bulletprice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the bullet count:");
                            int bulletcount = Convert.ToInt32(Console.ReadLine());
                            Sniper sniper = new Sniper(name, price, bulletname, magazinecapacity, bulletspeed, bulletprice, bulletcount);
                            if (snipindex < 10)
                            {

                                mysniperarray[snipindex] = sniper;
                                Console.WriteLine("The sniper is added.");
                            }
                            else
                            {
                                Console.WriteLine("There is not so much space in the store");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("pleae enter true type values");
                            goto Tryagain;

                        }
                    }
                    else if (answer2 == "2")
                    {
                    Tryagain:
                        try
                        {
                            smgindex++;
                            Console.Write("Enter Sub-Machine Gun name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter Sub-Machine Gun price:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the name of the Sub-Machine Gun's bullet:");
                            string bulletname = Console.ReadLine();
                            Console.Write("Enter the Sub-Machine Gun's magazine capacity:");
                            int magazinecapacity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet speed: ");
                            int bulletspeed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet price:");
                            double bulletprice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the bullet count:");
                            int bulletcount = Convert.ToInt32(Console.ReadLine());
                            Smg newsmg = new Smg(name, price, bulletname, magazinecapacity, bulletspeed, bulletprice, bulletcount);
                            if (smgindex < 10)
                            {
                                mysmgarray[smgindex] = newsmg;
                                Console.WriteLine("The Sub-Machine Gun is added.");
                            }
                            else
                            {
                                Console.WriteLine("There is not so much space in the store");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("pleae enter true type values");
                            goto Tryagain;
                        }

                    }
                    else if (answer2 == "3")
                    {
                    Tryagain:
                        try
                        {
                            pistolindex++;
                            Console.Write("Enter Pistol Gun name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter Pistol Gun price:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the name of the Pistol Gun's bullet:");
                            string bulletname = Console.ReadLine();
                            Console.Write("Enter the Pistol Gun's magazine capacity:");
                            int magazinecapacity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet speed: ");
                            int bulletspeed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet price:");
                            double bulletprice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the bullet count:");
                            int bulletcount = Convert.ToInt32(Console.ReadLine());
                            Pistol newpistol = new Pistol(name, price, bulletname, magazinecapacity, bulletspeed, bulletprice, bulletcount);
                            if (pistolindex < 10)
                            {
                                mypistolarray[pistolindex] = newpistol;
                                Console.WriteLine("The Pistol Gun is added.");
                            }
                            else
                            {
                                Console.WriteLine("There is not so much space in the store");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("please enter true type values");
                            goto Tryagain;
                        }
                    }
                    else if (answer2 == "4")
                    {
                    Tryagain:
                        try
                        {
                            assaultindex++;
                            Console.Write("Enter assault Gun name:");
                            string name = Console.ReadLine();
                            Console.Write("Enter assault Gun price:");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the name of the assault Gun's bullet:");
                            string bulletname = Console.ReadLine();
                            Console.Write("Enter the assault Gun's magazine capacity:");
                            int magazinecapacity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet speed: ");
                            int bulletspeed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bullet price:");
                            double bulletprice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the bullet count:");
                            int bulletcount = Convert.ToInt32(Console.ReadLine());
                            Assaultriffle newassault = new Assaultriffle(name, price, bulletname, magazinecapacity, bulletspeed, bulletprice, bulletcount);
                            if (assaultindex < 10)
                            {
                                myassaultarray[assaultindex] = newassault;
                                Console.WriteLine("The Pistol Gun is added.");
                            }
                            else
                            {
                                Console.WriteLine("There is not so much space in the store");
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("please enter true type values");
                            goto Tryagain;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Make the right choice!");
                    }
                }
                #endregion
                #region choosfire
                else if (answer == "3")
                {
                    Console.Clear();
                    Console.WriteLine("What type of gun do you want to choose?");
                    inputmethod();
                    string answer3 = Console.ReadLine();
                    Console.WriteLine("--");
                Tryagain:
                    try
                    {
                        if (answer3 == "1")
                        {
                            Console.Clear();
                            foreach (var item in mysniperarray)
                            {
                                if (item != null)
                                {
                                    Console.WriteLine(item?.InfoSnipper());
                                    Console.WriteLine("--");
                                }
                            }
                            Console.Write("Choose the sniper id :");
                            int indexsnip = Convert.ToInt32(Console.ReadLine());
                            if (indexsnip < mysniperarray.Length)
                            {

                                Sniper newsniper = mysniperarray[indexsnip - 1];
                                int magazine = newsniper.MagazineCapacity;
                                Console.WriteLine($"Selected {newsniper.Name}");
                                while (true)
                                {
                                    Console.Write("if do you want to fire click 'f' or 'F' button,for relaod click 'r' or 'R' 'quit' for menu:");
                                    string fireanswer = Console.ReadLine();
                                    if (fireanswer == "f" || fireanswer == "F")
                                    {
                                        if (newsniper.BulletCount > 0 && magazine > 0)
                                        {
                                            magazine--;
                                            newsniper.BulletCount--;
                                            Console.WriteLine($"you have {newsniper.BulletCount} bullet left.");
                                            if (magazine == 0)
                                            {
                                            Reload:
                                                Console.Write("There are no bullets left in your bulletmagazine ,please reload magazin with click 'R' or 'r'");
                                                string reloading = Console.ReadLine();
                                                if (reloading == "r" || reloading == "R")
                                                {
                                                    magazine = newsniper.MagazineCapacity;
                                                }
                                                else
                                                {
                                                    goto Reload;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("the bullet of your sniper gun is over");
                                            break;
                                        }

                                    }
                                    else if (fireanswer == "r" || fireanswer == "R")
                                    {
                                        magazine = newsniper.MagazineCapacity;
                                        Console.WriteLine("reloaded...");
                                    }
                                    else if (fireanswer == "quit" || fireanswer == "Quit")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("there is no such operation,please click for fire or go to menu");
                                    }
                                }
                            }
                        }
                        else if (answer3 == "2")
                        {
                            Console.Clear();
                            foreach (var item in mysmgarray)
                            {
                                if (item != null)
                                {
                                    Console.WriteLine(item?.InfoSmg());
                                    Console.WriteLine("--");
                                }
                            }
                            Console.Write("Choose the smg index :");
                            int indexsmg = Convert.ToInt32(Console.ReadLine());
                            if (indexsmg < mysmgarray.Length)
                            {

                                Smg newsmg = mysmgarray[indexsmg - 1];
                                int magazine = newsmg.MagazineCapacity;
                                Console.WriteLine($"Selected {newsmg.Name}");
                                while (true)
                                {
                                    Console.Write("if do you want to fire click 'f' or 'F' button ,for reload click 'r' or 'R' and 'quit' for menu:");
                                    string fireanswer = Console.ReadLine();
                                    if (fireanswer == "f" || fireanswer == "F")
                                    {
                                        if (newsmg.BulletCount > 0 && magazine > 0)
                                        {
                                            magazine--;
                                            newsmg.BulletCount--;
                                            Console.WriteLine($"you have {newsmg.BulletCount} bullet left.");
                                            if (magazine == 0)
                                            {
                                            Reload:
                                                Console.Write("There are no bullets left in your bulletmagazine ,please reload magazin with click 'R' or 'r'");
                                                string reloading = Console.ReadLine();
                                                if (reloading == "r" || reloading == "R")
                                                {
                                                    magazine = newsmg.MagazineCapacity;
                                                }
                                                else
                                                {
                                                    goto Reload;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("the bullet of your smg gun is over");
                                            break;
                                        }

                                    }
                                    else if (fireanswer == "r" || fireanswer == "R")
                                    {
                                        magazine = newsmg.MagazineCapacity;
                                        Console.WriteLine("reloaded...");
                                    }
                                    else if (fireanswer == "quit" || fireanswer == "Quit")
                                    {
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("there is no such operation,please click for fire or go to menu");
                                    }
                                }
                            }
                        }
                        else if (answer3 == "3")
                        {
                            Console.Clear();
                            foreach (var item in mypistolarray)
                            {
                                if (item != null)
                                {
                                    Console.WriteLine(item?.InfoPistol());
                                    Console.WriteLine("--");
                                }
                            }
                            Console.Write("Choose the pistol index :");
                            int indexsmg = Convert.ToInt32(Console.ReadLine());
                            if (indexsmg < mypistolarray.Length)
                            {

                                Pistol newpistol = mypistolarray[indexsmg - 1];
                                int magazine = newpistol.MagazineCapacity;
                                Console.WriteLine($"Selected {newpistol.Name}");
                                while (true)
                                {
                                    Console.Write("if do you want to fire click 'f' or 'F' button,for reload click 'r' or 'R' and 'quit' for menu:");
                                    string fireanswer = Console.ReadLine();
                                    if (fireanswer == "f" || fireanswer == "F")
                                    {
                                        if (newpistol.BulletCount > 0 && magazine > 0)
                                        {
                                            magazine--;
                                            newpistol.BulletCount--;
                                            Console.WriteLine($"you have {newpistol.BulletCount} bullet left.");
                                            if (magazine == 0)
                                            {
                                            Reload:
                                                Console.Write("There are no bullets left in your bulletmagazine ,please reload magazin with click 'R' or 'r'");
                                                string reloading = Console.ReadLine();
                                                if (reloading == "r" || reloading == "R")
                                                {
                                                    magazine = newpistol.MagazineCapacity;
                                                }
                                                else
                                                {
                                                    goto Reload;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("the bullet of your pistol gun is over");
                                            break;
                                        }

                                    }
                                    else if (fireanswer == "r" || fireanswer == "R")
                                    {
                                        magazine = newpistol.MagazineCapacity;
                                        Console.WriteLine("reloaded...");
                                    }
                                    else if (fireanswer == "quit" || fireanswer == "Quit")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("there is no such operation,please click for fire or go to menu");
                                    }
                                }
                            }
                        }
                        else if (answer3 == "4")
                        {
                            Console.Clear();
                            foreach (var item in myassaultarray)
                            {
                                if (item != null)
                                {
                                    Console.WriteLine(item?.InfoAssaultRiffle());
                                    Console.WriteLine("--");
                                }
                            }
                            Console.Write("Choose the pistol id :");
                            int indexassault = Convert.ToInt32(Console.ReadLine());
                            if (indexassault < myassaultarray.Length)
                            {
                                Assaultriffle newassault = myassaultarray[indexassault - 1];
                                int magazine = newassault.MagazineCapacity;
                                Console.WriteLine($"Selected { newassault.Name}");
                                while (true)
                                {
                  
                                    Console.Write("if do you want to fire click 'f' or 'F' button,for reload click 'r' or 'R' and 'quit' for menu:");
                                    string fireanswer = Console.ReadLine();
                                    if (fireanswer == "f" || fireanswer == "F")
                                    {
                                        if (newassault.BulletCount > 0 && magazine > 0)
                                        {
                                            magazine--;
                                            newassault.BulletCount--;
                                            Console.WriteLine($"you have {newassault.BulletCount} bullet left.");
                                            if (magazine == 0)
                                            {
                                            Reload:
                                                Console.Write("There are no bullets left in your bulletmagazine ,please reload magazin with click 'R' or 'r'");
                                                string reloading = Console.ReadLine();
                                                if (reloading == "r" || reloading == "R")
                                                {
                                                    magazine = newassault.MagazineCapacity;
                                                }
                                                else
                                                {
                                                    goto Reload;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("the bullet of your assault gun is over");
                                            break;
                                        }
                                    }
                                    else if (fireanswer == "r" || fireanswer == "R")
                                    {
                                        magazine = newassault.MagazineCapacity;
                                        Console.WriteLine("reloaded...");
                                    }
                                    else if (fireanswer == "quit" || fireanswer == "Quit")
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("there is no such operation,please click for fire or go to menu");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Make the right choice!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter int not string");
                        goto Tryagain;
                    }
                }
                #endregion
                #region deleteinfo
                else if (answer == "4")
                {
                    Console.Clear();
                    Console.WriteLine("What type of gun do you want to delete?");
                    inputmethod();
                    string answer4 = Console.ReadLine();
                    Console.WriteLine("--");
                    if (answer4 == "1")
                    {
                        foreach (var item in mysniperarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoSnipper());
                                Console.WriteLine("--");
                            }
                        }
                    tryagain:
                        try
                        {
                            int check = 0;
                            Console.Write("Write the id sniper you want to delete:");
                            int deleteid = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < mysniperarray.Length; i++)
                            {
                                if (mysniperarray[i]?.Id == deleteid)
                                {
                                    Console.WriteLine($"{mysniperarray[i].Name} deleted.");
                                    mysniperarray[i] = null;
                                    check++;
                                }
                            }
                            if (check == 0)
                            {
                                Console.WriteLine("There are no sniper with this Id,please write correct id");
                                goto tryagain;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("the id can only be a integer");
                            goto tryagain;
                        }
                    }
                    else if (answer4 == "2")
                    {
                        foreach (var item in mysmgarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoSmg());
                                Console.WriteLine("--");
                            }
                        }
                    tryagain:
                        try
                        {
                            int check = 0;
                            Console.Write("Write the id smg you want to delete:");
                            int deleteid = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < mysmgarray.Length; i++)
                            {
                                if (mysmgarray[i]?.Id == deleteid)
                                {
                                    Console.WriteLine($"{mysmgarray[i].Name} deleted.");
                                    mysmgarray[i] = null;
                                    check++;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("the id can only be a integer");
                            goto tryagain;
                        }
                    }
                    else if (answer4 == "3")
                    {
                        foreach (var item in mypistolarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoPistol());
                                Console.WriteLine("--");
                            }
                        }
                    tryagain:
                        try
                        {
                            int check = 0;
                            Console.Write("Write the id pistol you want to delete:");
                            int deleteid = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < mypistolarray.Length; i++)
                            {
                                if (mypistolarray[i]?.Id == deleteid)
                                {
                                    Console.WriteLine($"{mypistolarray[i].Name} deleted.");
                                    mypistolarray[i] = null;
                                    check++;
                                }
                            }
                            if (check == 0)
                            {
                                Console.WriteLine("There are no pistol with this Id,please write correct id");
                                goto tryagain;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("the id can only be a integer");
                            goto tryagain;
                        }
                    }
                    else if (answer4 == "4")
                    {
                        foreach (var item in myassaultarray)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item?.InfoAssaultRiffle());
                                Console.WriteLine("--");
                            }
                        }
                    tryagain:
                        try
                        {
                            int check = 0;
                            Console.Write("Write the id assaultriffle you want to delete:");
                            int deleteid = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < myassaultarray.Length; i++)
                            {
                                if (myassaultarray[i]?.Id == deleteid)
                                {
                                    Console.WriteLine($"{myassaultarray[i].Name} deleted.");
                                    myassaultarray[i] = null;
                                    check++;
                                }
                            }
                            if (check == 0)
                            {
                                Console.WriteLine("There are no assaultriffle with this Id,please write correct id");
                                goto tryagain;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("the id can only be a integer");
                            goto tryagain;
                        }
                    }
                    #endregion            
                }
                else if (answer == "quit" || answer == "Quit")
                {
                    Console.WriteLine("The program ends...");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct choice");           
                }
            }
        }
    }
}
