using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200089
{
    internal class KodePos
    {
        private int kode;
        private String lur;
        public String getKodePos()
        {
            return lur + " " + kode;
        }

        public void setKodePos(String Lur, int Kode)
        {
            lur = Lur;
            kode = Kode;
        }
    }
}
