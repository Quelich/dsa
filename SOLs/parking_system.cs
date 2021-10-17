namespace SOLs
{

    public class ParkingSystem
    {
        private int Big { get; set; }
        private int Medium { get; set; }
        private int Small { get; set; }
        public ParkingSystem(int big, int medium, int small)
        {
            this.Big = big;
            this.Medium = medium;
            this.Small = small;
        }

        public bool AddCar(int carType)
        {
            //Big Car
            if (carType == 1)
            {
                if (Big > 0)
                {
                    Big--;
                    return true;
                }
                return false;
            }
            //Medium Car
            if (carType == 2)
            {
                if (Medium > 0)
                {
                    Medium--;
                    return true;
                }
                return false;
            }
            //Small Car
            if (carType == 3)
            {
                if (Small > 0)
                {
                    Small--;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}