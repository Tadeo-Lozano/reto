using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arrayList team1 = new arrayList();
            arrayList team2 = new arrayList();
            arrayList team3 = new arrayList();

            team1.addAtTail("Jesus");
            team1.addAtTail("Salomon");
            team1.addAtTail("Yael");

            team2.addAtFront("Christian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            ArrayListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debio haber impreso 
            //Jesus
            //Salomon
            //Yael

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debio haber impreso 
            //Diego
            //Daniel
            //Christian

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes ");//Debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            //Debió haber impreso
            //Rebeca
            //Salomón
            //Yael

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes ");

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

            team3.remove(0);
            team3.remove(0);

            team3.addAtTail("Isai");
            team3.addAtFront("Tadeo");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Tadeo
            // Isai

            if (team1.getAt(1).Equals("Salomon"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Rebeca
            // Luis
            // Yael
        }
    }
}
