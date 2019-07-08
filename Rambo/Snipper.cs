using System;
using System.Collections.Generic;
using System.Text;

namespace Rambo
{
    class Snipper
    {
        private Gun gun;

        public void setGun(Gun gun)
        {
            this.gun = gun;
        }
        public Gun getGun()
        {
            return this.gun;
        }
        public void shoot()
        {
            this.gun.shoot();
        }
    }
}
