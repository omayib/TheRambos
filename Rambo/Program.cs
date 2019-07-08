using System;

namespace Rambo
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGunListener theGunListener = new TheGunListener();

            //Shot Gun take out one projectile per shot
            Gun shotGun = new ShotGun("S12K", "Brown");
            shotGun.addProjectile(3);
            shotGun.setOnShootListener(theGunListener);

            //deagle Gun take out two projectile per shot
            Gun deagle = new Deagle("Deagle Ultimed", "Red");
            deagle.addProjectile(3);
            deagle.setOnShootListener(theGunListener);


            Snipper snipper = new Snipper();

            snipper.setGun(shotGun);
            string info1 = snipper.getGun().getType(); 
            Console.WriteLine(info1);// S12K
            string info2 = snipper.getGun().getColor();
            Console.WriteLine(info2); // Brown
            snipper.shoot(); // Completed. The projectile was 2 
            snipper.shoot(); // Completed. The projectile was 1 
            snipper.shoot(); // Failed. Please reload 

            Console.WriteLine("================================= next gun >>>>>");

            snipper.setGun(deagle);
            string info3 = snipper.getGun().getType(); 
            Console.WriteLine(info3);// Deagle Ultimed
            string info4 = snipper.getGun().getColor();
            Console.WriteLine(info2); // Red
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
