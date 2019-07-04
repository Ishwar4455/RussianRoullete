using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russain_roullete_assiment
{
    class make
    {
        public int loader;
        public int shotter = 2; 
        public int total = 6;
        
        public int amissbullete()
        {
            int track = 0;
            if (total > 0 && shotter == 2 && loader == 1 )
            {

                track = 10;


            }
            if (total > 0 && loader == 1 && shotter == 1)
            {

                track = 5;

            }

            else if (total > 0 && loader != 1)
            {
                track = 0;
                total = total - 1;
                if (loader == 6)
                {
                    loader = 1;//bullete is 1
                }
                else
                {
                    loader++;//increase the value of bullete
                }



            }
            return track;
        }
    }
}
