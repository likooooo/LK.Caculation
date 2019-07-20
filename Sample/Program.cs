using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LK.Caculation;
namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] gg = new float[3] { 1f, 2f, 3f };
          var res=  Caculation.Sum(gg);
        }
    }
}
