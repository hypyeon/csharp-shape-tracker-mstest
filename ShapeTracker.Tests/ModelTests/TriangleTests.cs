using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTraingle_Triangle()
    // public: allows the tools running our tests to access them. 
    // void: because this method does not return anything. 
    // naming convention: 
    // 1) TriangleConstructor: method being tested
    // 2) CreatesInstanceOfTriange: behavior of method
    // 3) Triangle: expected return value of tested method 
    {
      Triangle newTriangle = new Triangle(2);
      // behavior being tested 

      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
      // typeof(): type of a class 
      // GetType(): returns data type of a specific obj 
      // example: Assert.AreEqual(true, 1 == 1) => passed test
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    // organizational trick: arrange - act - assert 
    {
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1);
      // arrange: gather necessary components 

      int result = newTriangle.Side1;
      // act: invoke functionality by calling a method 

      Assert.AreEqual(length1, result);
      // assert: confirm functionality by comparing actual and anticipated outputs
    }
  }
}