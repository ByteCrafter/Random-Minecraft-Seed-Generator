using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSeedGenerator
{
    class Generator
    {
        public static Int64 SeedGenerator(SeedOption option)
        {
            if (option == SeedOption.Small)
            {
                Random rnd = new Random();
                var buffer = new byte[sizeof(Int32)];
                rnd.NextBytes(buffer);
                return BitConverter.ToInt32(buffer, 0);
            }
            else if (option == SeedOption.Big)
            {
                Random rnd = new Random();
                var buffer = new byte[sizeof(long)];
                rnd.NextBytes(buffer);
                return BitConverter.ToInt64(buffer, 0);
            }
            return 0;
        }


        public enum SeedOption
        {
            Small,
            Big
        }

    }

}