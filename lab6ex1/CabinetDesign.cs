using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6ex1
{
    class CabinetDesign
    {

        //proprietati 
       private int lenght;
       private int width;
       private int height;



        public CabinetDesign(int lenght, int width, int height)
        {

            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }


        public int VolumCalc()
        {
            return lenght * width* height;
        }
    }
 }

 


