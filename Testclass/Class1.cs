﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemostration;

namespace Testclass
{
    public class TestClass

    {
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
           int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60; 

            string expected = "The triangle is valid";

            string actual =Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

         
            Assert.AreEqual(expected,actual);
            
        }
    }
}