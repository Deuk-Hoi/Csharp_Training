using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    class Box
    {
        private int width;

        public int Width
        {
            get { return width; }
            set { 
                if(value > 0)
                    width = value;
                else
                {
                    throw new Exception("너비를 자연수로 입력하시오");
                }
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set {
                if(value > 0)
                    height = value;
                else
                {
                    throw new Exception("높이를 자연수로 입력하시오");
                }
            }
        }
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
}
