using System;
using System.Collections.Generic;
using System.Text;

namespace Rambo
{
    class Deagle : Gun
    {
        public Deagle(string type, string color) : base(type, color)
        {
        }


        public override void shoot()
        {
            if (this.getProjectile() > 2)
            {
                this.decreaseProjectile(2);
                this.getOnShootListener().onShootSucceed("Completed. The projectile was " + this.getProjectile());
            }
            else
            {
                this.getOnShootListener().onShootFailed("Failed. Please reload");
            }

        }

        public void zoomIn()
        {
            throw new NotImplementedException();
        }

        public void zoomOut()
        {
            throw new NotImplementedException();
        }
    }
}
