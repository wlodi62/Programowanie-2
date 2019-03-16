using System;

namespace zadanie7
{
    class Device
    {
        public int width
        {
            get;
            protected set;
        }

        public int height
        {
            get;
            protected set;
        }

        public Device()
        {
            this.width = 0;
            this.height = 0;
        }

        public Device(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string returnvalues()
        {
            return " " + this.width + " " + this.height;

        }
    }

    class TV : Device
    {
        public double inches
        {
            get;
            protected set;
        }

        public int refreshRate
        {
            get;
            protected set;
        }

        public TV(int width, int height, double inches, int refreshRate) : base(width, height)
        {
            this.inches = inches;
            this.refreshRate = refreshRate;
        }

        new public string returnvalues()
        {
            return " " + base.returnvalues() + " " + this.inches + " " + this.refreshRate;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TV TVSAMSUNG = new TV(100, 60, 55, 120);
            Console.WriteLine(TVSAMSUNG.returnvalues());
        }
    }
}
