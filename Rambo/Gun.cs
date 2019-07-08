using System;
using System.Collections.Generic;
using System.Text;

namespace Rambo
{
    abstract class Gun
    {
        private string color, type;
        private int projectileCount;
        private OnShootListener listener;
        private Telescope telescope;

        public Gun(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        public void addProjectile(int projectileNumber)
        {
            this.projectileCount = projectileNumber;
        }
        public int getProjectile()
        {
            return this.projectileCount;
        }
        public OnShootListener getOnShootListener()
        {
            return this.listener;
        }
        public string getColor()
        {
            return this.color;
        }

        public string getType()
        {
            return this.type;
        }

        public void setOnShootListener(OnShootListener listener)
        {
            this.listener = listener;
        }

        public void decreaseProjectile(int number)
        {
            this.projectileCount = this.projectileCount-number;
        }

        public void addTelescope()
        {

        }
        abstract public void shoot();
    }

    interface Telescope
    {
        string getType();
        void setType();
        void zoomIn();
        void zoomOut();
    }

    interface OnShootListener{
        void onShootSucceed(string message);
        void onShootFailed(string message);
    }
}
