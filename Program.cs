using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte valueSByte = -100;
            byte valueByte = 100;
            short valueShort = -20000;
            ushort valueUshort = 50000;
            int valueInt = -1000000000;
            uint valueUInt = 4000000000;
            long valueLong = -800000000000;
            ulong valueULong = 9000000000000000000;

            float valueFloat = 3.1415F;
            double valueDouble = 3.1415926535;

            char valueChar = 'A';
            string valueString = "C#PROGRAM";

            bool valueBool = true;

            Console.WriteLine("{1} : {0}", valueSByte,valueSByte.GetType().Name);
            Console.WriteLine("{1} : {0}", valueByte.GetType().Name);
            Console.WriteLine("{1} : {0}", valueShort.GetType().Name);
            Console.WriteLine("{1} : {0}", valueUshort.GetType().Name);
            Console.WriteLine("{1} : {0}", valueInt.GetType().Name);
            Console.WriteLine("{1} : {0}", valueUInt.GetType().Name);
            Console.WriteLine("{1} : {0}", valueLong.GetType().Name);
            Console.WriteLine("{1} : {0}", valueULong.GetType().Name);
            Console.WriteLine("{1} : {0}", valueFloat.GetType().Name);
            Console.WriteLine("{1} : {0}", valueDouble.GetType().Name);
            Console.WriteLine("{1} : {0}", valueChar.GetType().Name);
            Console.WriteLine("{1} : {0}", valueString.GetType().Name);
            Console.WriteLine("{1} : {0}", valueBool.GetType().Name);
        }
    }
}
