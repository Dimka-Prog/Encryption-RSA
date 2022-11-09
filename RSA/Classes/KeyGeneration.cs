using System;

namespace RSA
{
    public class KeyGeneration
    {
        private long p = 0;
        private long q = 0;
        public long compositionPQ = 0;
        public long funcEuler = 0;
        public long e = 0;
        public long d = 0;

        public KeyGeneration(long p, long q)
        {
            this.p = p;
            this.q = q;
            compositionPQ = this.p * this.q;
            funcEuler = (p - 1) * (q - 1);
            e = createE();
            d = createD();
        }

        private long createE()
        {
            for (long i = 2; i < funcEuler; i++)
            {
                if (Algorithm.simplicity(i))
                    if (Algorithm.mutualSimplicity(i, funcEuler))
                        return i;
            }
            return 0;
        }

        private long createD()
        {
            long D = 1;

            while ((D * e) % funcEuler != 1) 
            {
                D++;
                if (D == e)
                    D++;
            }

            return D;
        }
    }
}
