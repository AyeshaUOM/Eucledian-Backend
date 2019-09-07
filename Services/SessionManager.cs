using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant.Services
{
    public class SessionManager
    {
        public byte[] salt
        {
            get
            {
                return Encoding.ASCII.GetBytes("2TiJ4=[Tk-3`~C%5+;b{QryBKOT6?6{gl;HPyhH SC4XFI2,>eC{GC-/s|F AW1R");
            }
        }

        public string Audiance
        {
            get
            {
                return "etudian";
            }
        }

        public string Issuer
        {
            get
            {
                return "com.etudian";
            }
        }
    }
}
