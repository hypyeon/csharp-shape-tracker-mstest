using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    // public: allows the tools running our tests to access them. 
    // void: because this method does not return anything. 
    // naming convention: 
    // 1) TriangleConstructor: method being tested
    // 2) CreatesInstanceOfTriange: behavior of method
    // 3) Triangle: expected return value of tested method 
    {
      Triangle newTriangle = new Triangle(2, 3, 8);
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
      Triangle newTriangle = new Triangle(length1, 2, 8);
      // arrange: gather necessary components 

      int result = newTriangle.Side1;
      // act: invoke functionality by calling a method 

      Assert.AreEqual(length1, result);
      // assert: confirm functionality by comparing actual and anticipated outputs
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Triangle newTriangle = new Triangle(3, 3, 8);
      int newLength1 = 44;
      newTriangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2, 8);
      int result = newTriangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength2 = 6;
      newTriangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_int()
    {
      int length3 = 55;
      Triangle newTriangle = new Triangle(2, 3, length3);
      int result = newTriangle.GetSide3();
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_SetsValueOfSide3_void()
    {
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength3 = 6;
      newTriangle.SetSide3(newLength3);
      Assert.AreEqual(newLength3, newTriangle.GetSide3());
    }

    [TestMethod]
    public void CheckType_DeterminesWhenNotATriangle_String()
    {
      Triangle notATriangle = new Triangle(3, 4, 88);
      string triType = notATriangle.CheckType();
      Assert.AreEqual("not a triangle", triType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenScalene_String()
    {
      Triangle scaleneTri = new Triangle(3, 4, 5);
      string triType = scaleneTri.CheckType();
      Assert.AreEqual("scalene triangle", triType);
    }
  }
}