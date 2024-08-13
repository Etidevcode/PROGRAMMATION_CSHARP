namespace ClassesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Mercedes");
            Car anotherCar = new Car("Volkswagen");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(4);
   
            anotherCar.Brake(15);

        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate(int amount)
        {
            speed += amount;        // speed = speed + amount
            showSpeed();
        }

        public void Brake(int speedReduction)
        {
            speed = (speed < speedReduction) ? 0 : speed - speedReduction;
            showSpeed();
        }

        //public void Brake(int speedReduction)
        //{
        //    if (speed < speedReduction)
        //    {
        //        speed = 0;
        //    } else
        //    {
        //        speed -= speedReduction;
        //    }
        //    showSpeed();
        //}

        //public void Brake(int speedReduction)
        //{
        //    speed -= speedReduction;
        //    if (speed < 0)
        //    {
        //        speed = 0;
        //    }
        //    showSpeed();
        //}

        private void showSpeed()
        {
            Console.WriteLine($"{name}  is going {speed} miles per hour..");
        }
    }
}
