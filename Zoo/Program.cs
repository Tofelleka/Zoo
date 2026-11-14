namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            ZooObserver observer = new ZooObserver(zoo);
            observer.Run();
        }
    }
}