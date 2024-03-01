using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todas as variáveis
            //sbyte
            sbyte sbytemx = sbyte.MaxValue;
            sbyte sbytemn = sbyte.MinValue;

            //short
            short shortmx = short.MaxValue;
            short shortmn = short.MinValue;

            //int
            int intmx = int.MaxValue;
            int intmn = int.MinValue;

            //long
            long longmx = long.MaxValue;
            long longmn = long.MinValue;

            //byte
            byte bytemx = byte.MaxValue;
            byte bytemn = byte.MinValue;

            //ushort
            ushort ushortmx = ushort.MaxValue;
            ushort ushortmn = ushort.MinValue;

            //uint
            uint uintmx = uint.MaxValue;
            uint uintmn = uint.MinValue;

            //ulong
            ulong ulongmx = ulong.MaxValue;
            ulong ulongmn = ulong.MinValue;

            //char
            char charmx = char.MaxValue;
            char charmn = char.MinValue;

            //float
            float floatmx = float.MaxValue;
            float floatmn = float.MinValue;

            //double
            double doublemx = double.MaxValue;
            double doublemn = double.MinValue;

            //decimal
            decimal decimalmx = decimal.MaxValue;
            decimal decimalmn = decimal.MinValue;


            //print das variáveis
            //sbyte
            Console.WriteLine($"sbyte max: {sbytemx}, sbyte min: {sbytemn}");

            //short
            Console.WriteLine($"short max: {shortmx}, short min: {shortmn}");

            //int
            Console.WriteLine($"int max: {intmx}, int min: {intmn}");

            //long
            Console.WriteLine($"long max: {longmx}, long min: {longmn}");

            //byte
            Console.WriteLine($"byte max: {bytemx}, byte min: {bytemn}");

            //ushort
            Console.WriteLine
            ($"ushort max: {ushortmx}, ushort min: {ushortmn}");
            //uint
            Console.WriteLine($"uint max: {uintmx}, uint min: {uintmn}");
            //ulong
            Console.WriteLine($"ulong max: {ulongmx}, ulong min: {ulongmn}");
            //char
            Console.WriteLine($"char max: {charmx}, char min: {charmn}");
            //float
            Console.WriteLine($"float max: {floatmx}, float min: {floatmn}");
            //double
            Console.WriteLine
            ($"double max: {doublemx}, double min: {doublemn}");
            //decimal
            Console.WriteLine
            ($"decimal max: {decimalmx}, decimal min: {decimalmn}");

            //infinito e nan
            float posinfinite = float.PositiveInfinity;
            float neginfinite = float.NegativeInfinity;
            double notanumber = double.NaN;
            Console.WriteLine
            ($"+infinity: {posinfinite}, -infinity: {neginfinite}");
            Console.WriteLine($"Not a Number: {notanumber}");

            //Exercice 7
            uint uintmx2 = ushort.MaxValue;
            Console.WriteLine((ushort)(uintmx2+1));
            float overflow = 2*float.MaxValue;
            Console.WriteLine(overflow);
            float overflow1 = float.MaxValue + 1;
            Console.WriteLine(overflow1);


            

        }
    }
}
