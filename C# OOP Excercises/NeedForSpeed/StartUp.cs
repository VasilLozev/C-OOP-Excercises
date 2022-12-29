namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar supra = new SportCar(200, 100000);
            supra.Drive(1);
            System.Console.WriteLine(supra.Fuel);
        }
    }
}
