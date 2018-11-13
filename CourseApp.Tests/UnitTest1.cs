using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {

         [Fact]
        public void Test1()
        {
            var res = Program.Fan(0.7,1.2,0.48); 
            Assert.Equal(0.326, res, 3);
       }

         [Fact]
        public void Test2()
        {
            var res = Program.Fan(1.0,1.2,0.48); 
            Assert.Equal(0.584, res, 3);
       }

         [Fact]
        public void Test3()
        {
            var res = Program.Fan(1.3,1.2,0.48); 
            Assert.Equal(0.968, res, 3);
       }

         [Fact]
        public void Test4()
        {
            var res = Program.Fan(1.6,1.2,0.48); 
            Assert.Equal(Double.NaN, res, 3);
       }

         [Fact]
        public void Test5()
        {
            var res = Program.Fan(1.9,1.2,0.48); 
            Assert.Equal(Double.NaN, res, 3);
       }
       
         double[] xx = {0.25, 0.36, 0.56, 0.94, 1.28};

         [Fact]
        public void Test6()
        {          
            double[] o = new double[5] {0.082,0.122,0.229,0.528,0.930}; 
            foreach (int i in xx)
            {
                var res = Program.Fan(xx[i],1.2,0.48);         
                    Assert.Equal(o[i], res, 3);              
            }    
       }    
    }
}