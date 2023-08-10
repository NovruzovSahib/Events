internal partial class Program
{
    public class Car
    {
        public delegate void CarDelegate();
        public event CarDelegate Onmoving;

        public void StartMoving()
        {
            Console.WriteLine("Car is successfully moved");
        }

        public void StartEvent()
        {
            Onmoving.Invoke(); // Use ?. to safely invoke the event
        }
    }

}
