using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    interface IRouteStrategy
    {
        void BuildRoute(string a, string b);
    }

    class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute(string a, string b)
        {
            Console.WriteLine($@"Road Way for cars");
            Console.WriteLine("You can see a lot of traffic light");
        }
    }

    class AirStrategy : IRouteStrategy
    {
        public void BuildRoute(string a, string b)
        {
            Console.WriteLine("Route for air vehicles");
            Console.WriteLine("You are managed from airport");
        }
    }

    class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(string a, string b)
        {
            Console.WriteLine("You should go over padesterian way");
        }
    }

    class Navigator
    {
        IRouteStrategy _routeStrategy;

        public Navigator(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void ChangeStrategy (IRouteStrategy strategy)
        {
            _routeStrategy = strategy;
        }

        public void BuildRoute(string a, string b)
        {
            _routeStrategy.BuildRoute(a, b);    
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Navigator navigator = new Navigator(new AirStrategy());
            navigator.BuildRoute("Koroghlu Rehimov 71", "Xirdalan Dairesi");
            navigator.ChangeStrategy(new WalkingStrategy());
            navigator.BuildRoute("Koroghlu Rehimov 71", "Xirdalan Dairesi");
        }
    }
}
