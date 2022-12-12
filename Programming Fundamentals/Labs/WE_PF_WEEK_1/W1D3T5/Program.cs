using System;

namespace W1D3T5
{
    internal class Program
    {
        class Sports
        {
            public virtual String getName()
            {
                return "Generic Sports";
            }
            public virtual void getNumberOfTeamMembers()
            {
                Console.WriteLine("Each team has n players in " + getName());
            }
        }
        class Soccer : Sports
        {
            public override String getName()
            {
                return "Soccer Class";
            }
            public override void getNumberOfTeamMembers()
            {
                Console.WriteLine("Each team has 11 players in " + getName());
            }
        }
        static void Main()
        {
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();
            Console.WriteLine(c1.getName());
            c1.getNumberOfTeamMembers();
            Console.WriteLine(c2.getName());
            c2.getNumberOfTeamMembers();
        }
    }
}
