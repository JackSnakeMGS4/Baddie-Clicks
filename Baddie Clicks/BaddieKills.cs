using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baddie_Clicks
{
    public class BaddieKills
    {
        public int killCount = 0;
        public int totalAttacks = 0;

        public void Update(bool hits)
        {           
            if (hits == true)
            {
                killCount++;               
            }
            else
            {
                totalAttacks++;
            }
        }

    }
}
