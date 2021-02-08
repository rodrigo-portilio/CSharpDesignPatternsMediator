using MediatorDemo.ChatApp;
using MediatorDemo.Structural;
using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamChat = new TeamChatroom();

            var steve = new Developer("Steve");
            var justin = new Developer("Justin");
            var jenna = new Developer("Jenna");
            var kim = new Tester("Kim");
            var julia = new Tester("Julia");
            teamChat.RegisteMembers(steve, justin, jenna, kim, julia);

            steve.Send("Hey everyone, we're going to be deploying at 2pm today.");
            kim.Send("Ok, thanks gor letting us know.");

            Console.WriteLine();
            steve.SendTo<Developer>("Make sure to execute your unit tests before checking in!");
        }

        private static void StructuralExample()
        {
            var mediator = new ConcreteMediator();
            //var c1 = new Collegue1();
            //var c2 = new Collegue2();
            //mediator.Collegue1 = c1;
            //mediator.Collegue2 = c2;
            //mediator.Register(c1);
            //mediator.Register(c2);
            var c1 = mediator.CreateColleague<Collegue1>();
            var c2 = mediator.CreateColleague<Collegue2>();

            c1.Send("Hello, World! (from c1)");
            c2.Send("hi, there! (from c2)");
        }
    }
}
