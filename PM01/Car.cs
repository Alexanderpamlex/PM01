using System;

namespace PM01
{
    internal class Car
    {
        private string model;
        private bool isClean = true;
        private int maxSpeed;
        private float fuelPercent;
        private float fuelConguption;

        public Car()
        {
        }
        public Car(string model, int maxSpeed, float fuelPercent, float fuelConguption)
        {
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.fuelPercent = fuelPercent;
            this.fuelConguption = fuelConguption;
        }

        public string Model { get => model; set => model = value; }
        public bool IsClean { get => isClean; set => isClean = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public float FuelPercent { get => fuelPercent; set => fuelPercent = value; }
        public float FuelConguption { get => fuelConguption; set => fuelConguption = value; }

        public void Move(int km)
        {
            if (km==50)
            {
                isClean = false;
                Console.WriteLine("У вас испачкалась машина");
            }
                


            if (fuelPercent < km * fuelConguption)
                Console.WriteLine("Вам не хватает топлива для преодоления данного растояния\n");
            else
            {
                fuelPercent -= km * fuelConguption;
                Console.WriteLine($"Вы на {model} проехали: {km}км за {Math.Round((float)(km*60)/maxSpeed,2)} минут\nУ вас осталось: {fuelPercent * 100}% топлива\n");
            }
        }

        public override string ToString()
        {
            return $"Model: {model}; Clean: {(isClean ? "yes" : "no")}; Max speed: {maxSpeed}; Fuel percent: {fuelPercent*100}% " ;
        }

        public void Clear() 
        { 
        }

    }
}
