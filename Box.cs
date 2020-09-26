using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Box
    {
        int height;
        int length;
        int width;

        public void setHeight(int param)
        {
            this.height = param;
        }

        public void setLength(int param)
        {
            this.length = param;
        }

        public void setWidth(int param)
        {
            this.width = param;
        }

        public int getVolume()
        {
            int volume = this.height * this.length * this.width;
            return volume;
        }
    }

}
