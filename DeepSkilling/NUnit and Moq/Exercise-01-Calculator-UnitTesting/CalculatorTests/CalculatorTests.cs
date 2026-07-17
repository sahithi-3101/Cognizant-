using NUnit.Framework;
using CalcLibrary;
namespace CalculatorTests;
[TestFixture]
public class CalculatorTests{
Calculator c;
[SetUp] public void Setup(){c=new Calculator();}
[TearDown] public void Cleanup(){c=null;}
[TestCase(2,3,5)]
[TestCase(10,15,25)]
[TestCase(-1,1,0)]
public void Add_Test(int a,int b,int expected){
Assert.That(c.Add(a,b),Is.EqualTo(expected));
}
}