
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    class PictureClass
    {
        public string Path;
        public double method1;
        public double method2;
        
        public PictureClass(string path, double method1Value, double method2Value)
        {
            this.Path = path;
            this.method1 = method1Value;
            this.method2 = method2Value;
        }
        public double getMethod1()
        {
            return method1;
        }
        
        public double getMethod2()
        {
            return method2;
        }
        public string getPath()
        {
            return Path;
        }
    }
}
