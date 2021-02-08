using System;

namespace MediatorDemo.Structural
{
    public class Collegue1 : Colleague
    {
        //public Collegue1(Mediator mediator) : base(mediator)
        //{
        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Collegue1 receives notification message: {message}");
        }
    }
}
