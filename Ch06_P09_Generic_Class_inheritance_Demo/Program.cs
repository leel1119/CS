using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_P09_Generic_Class_inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseConcrete bc = new BaseConcrete(12, 34);
            bc.showInternalState();

            BaseGeneric<double> bc_d = new BaseGeneric<double>(12.55, 34.16);
            bc_d.showInternalState();

            Gen1<string> gen1 = new Gen1<string>("Tom", 12, 99);
            gen1.showInternalState();

            Gen2<string> gen2 = new Gen2<string>("Zoe", 54.46, 85.25);
            gen2.showInternalState();

            Gen3<string> gen3 = new Gen3<string>("Hash", "John", "David");
            gen3.showInternalState();

            Console.ReadLine();
        }
    }
    class BaseConcrete
    {
        public int x, y;
        public BaseConcrete(int x, int y)
        {
            this.y = y;
            this.x = x;
        }
        public void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}");
        }
    }
    class BaseGeneric<T>
    {
        public T x, y;
        public BaseGeneric(T x, T y)
        {
            this.y = y;
            this.x = x;
        }
        public virtual void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}");
        }
    }
    class Gen1<T> : BaseConcrete
    {
        T z;
        public Gen1(T z, int x, int y): base(x, y)
        {
            this.z = z;
        }
        public virtual void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}, Point z: {z}");
        }
    }
    class Gen2<T> : BaseGeneric<double>
    {
        T z;
        public Gen2(T z, double x, double y) : base(x, y)
        {
            this.z = z;
        }
        public override void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}, Point z: {z}");
        }
    }
    class Gen3<T> : BaseGeneric<T>
    {
        T z;
        public Gen3(T z, T x, T y) : base(x, y)
        {
            this.z = z;
        }
        public override void showInternalState()
        {
            Console.WriteLine($"Point x: {x}, Point y: {y}, Point z: {z}");
        }
    }
}
