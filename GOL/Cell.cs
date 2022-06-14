using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Cell
    {
        private bool bIsAlive = false;
        private int generationsAlive = 0; 

        public bool getIsAlive() { return bIsAlive; } 
        public void setIsAlive(bool isalive) { bIsAlive = isalive; }
        public int getGenAlive() { return generationsAlive; } 
        public void setGenAlive(int genAlive) { generationsAlive = genAlive; } 
    }
}
