using System.Collections.Generic;
using System.Linq;

namespace MediatorDemo.Structural
{
    public class ConcreteMediator : Mediator
    {
        //public Collegue1 Collegue1 { get; set; }
        //public Collegue2 Collegue2 { get; set; }
        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.colleagues.Add(c);
            return c;
        }

        public override void Send(string message, Colleague colleague)
        {
            //if (colleague == this.Collegue1)
            //{
            //    this.Collegue2.HandleNotification(message);
            //}
            //else
            //{
            //    this.Collegue1.HandleNotification(message);
            //}

            this.colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
