using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGame
{
    /// <summary>
    /// Creating data base in c/databases
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new GameContext("four_in_rowDB_AmirBaum_AmitLapid1"))
            {
                ctx.Database.Initialize(force: true);
            }
        }
    }
}
