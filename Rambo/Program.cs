using System;

namespace Rambo
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGunListener theGunListener = new TheGunListener();

            Gun shotGun = new ShotGun("S12K", "Brown");
            shotGun.addProjectile(3);
            shotGun.setOnShootListener(theGunListener);


            Gun deagle = new Deagle("Deagle", "Red");
            deagle.addProjectile(3);
            deagle.setOnShootListener(theGunListener);


            Snipper snipper = new Snipper();

            snipper.setGun(shotGun);
            string info1 = snipper.getGun().getType(); // S12K
            Console.WriteLine(info1);
            string info2 = snipper.getGun().getColor(); // Brown
            Console.WriteLine(info2);
            snipper.shoot(); // Completed. The projectile was 2 
            snipper.shoot(); // Completed. The projectile was 1 
            snipper.shoot(); // Failed. Please reload 

            Console.WriteLine("================================= next gun >>>>>");

            snipper.setGun(deagle);
            string info3 = snipper.getGun().getType(); // Deagle
            Console.WriteLine(info3);
            string info4 = snipper.getGun().getColor(); // Red
            Console.WriteLine(info2);
            snipper.shoot(); // Completed. The projectile was 1 
            snipper.shoot(); // Failed. Please reload 
            snipper.shoot(); // Failed. Please reload 
        }

        class TheGunListener : OnShootListener
        {
            public void onShootFailed(string message)
            {
                Console.WriteLine(message);
            }

            public void onShootSucceed(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
