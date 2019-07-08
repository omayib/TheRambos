using System;
using System.Collections.Generic;
using System.Text;

namespace Rambo
{
    class ShotGun : Gun
    {
        public ShotGun(string type, string color) : base(type, color)
        {
        }


        public override void shoot()
        {
            if (this.getProjectile() > 1)
            {
                this.decreaseProjectile(1);
                this.getOnShootListener().onShootSucceed("Completed. The projectile was " + this.getProjectile());
            }
            else
            {
                this.getOnShootListener().onShootFailed("Failed. Please reload");
            }
        }
    }
}
