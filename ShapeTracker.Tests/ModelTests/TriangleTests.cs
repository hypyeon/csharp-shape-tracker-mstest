using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
// needed for `List<T>` type
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests : IDisposable
  // ":" extends functionality from `IDisposalbe` to `TriangleTests` class 
  // `IDisposable`: for `Dispose()` method that resets data between tests
  {
    public void Dispose()
    {
      Triangle.ClearAll();
      // `ClearAll()` is NOT a built-in method
    }

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

    [TestMethod]
    public void CheckType_DeterminesWhenIsosceles_String()
    {
      Triangle isoscelesTri = new Triangle(5, 4, 4);
      string triType = isoscelesTri.CheckType();
      Assert.AreEqual("isosceles triangle", triType);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenEquilateral_String()
    {
      Triangle equilateralTri = new Triangle(4, 4, 4);
      string triType = equilateralTri.CheckType();
      Assert.AreEqual("equilateral triangle", triType);
    }

    [TestMethod]
    public void GetAll_ReturnsAllTriangleInstances_List()
    {
      Triangle tri1 = new Triangle(2, 2, 9);
      Triangle tri2 = new Triangle(21, 3, 9);
      Triangle tri3 = new Triangle(1, 3, 9);
      List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
      List<Triangle> actualResult = Triangle.GetAll();
      CollectionAssert.AreEqual(expected, actualResult); 
      // CollectionAssert vs. Assert: meant to compare collections i.e. arrays, lists, or dictionaries
    }

    [TestMethod]
    public void ClearAll_DeletesAllTriangleInList_Void()
    {
      Triangle tri1 = new Triangle(2, 2, 9);
      Triangle tri2 = new Triangle(21, 3, 9);
      Triangle tri3 = new Triangle(1, 3, 9);
      List<Triangle> expected = new List<Triangle> { };
      Triangle.ClearAll();
      CollectionAssert.AreEqual(expected, Triangle.GetAll());
    }
  }
}