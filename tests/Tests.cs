using NUnit.Framework;
using System;

namespace Figures.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Round()
        {
            var round = new Round(2);
            Assert.AreEqual(System.Math.PI*4,round.GetArrea());
        }

        [Test]
        public void Triangle(){
           var triangle = new Triangle(3,4,5);
           Assert.AreEqual(6,triangle.GetArrea()) ;
           triangle = new Triangle(8,12,16);
           Assert.AreEqual(Math.Sqrt(18*10*6*2),triangle.GetArrea()) ;
        }


    }
}