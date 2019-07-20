using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Objects;//Assembly:System.Data.Entity.dll

namespace LK.Caculation
{
    //参考
    //https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.enumerable?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DZH-CN%26k%3Dk(System.Linq.Enumerable);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.0);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.8


    public static class Caculation
    {
        //数据最大值
        public static float Max(IEnumerable<float> arry)
            => (arry.Max());


        //数据最小值
        public static float Min(IEnumerable<float> arry)
            => (arry.Min());


        //数据长度
        public static float Length(IEnumerable<float> arry)
            => (arry.LongCount());

       
        //两个数组合并
        public static IEnumerable<float> Union(IEnumerable<float> arry,IEnumerable<float> second)
            => (arry.Union(second));


        //求和
        public static float Sum(IEnumerable<float> arry)
            => (arry.Sum());


        //求均值
        public static float Mean(IEnumerable<float> arry)
         => (arry.Average()); //   => (Sum(arry) / Length(arry));


        //方差
        public static float Variance(IEnumerable<float> arry)
        {
            float mean = Mean(arry);
            return Mean(arry.Select(s => (s - mean) * (s - mean)));
        }


        //标准差(存在问题)

        public static float Deviation(IEnumerable<float> arry)
        => (float)Math.Sqrt((double)Variance(arry));
    }
}
