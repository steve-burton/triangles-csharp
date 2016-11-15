namespace Triangles.Objects
{
  public class Triangle
  {
    private int _length1;
    private int _length2;
    private int _length3;

    public Triangle(int side1, int side2, int side3)
    {
      _length1 = side1;
      _length2 = side2;
      _length3 = side3;
    }

    public void SetLength1(int inputLength)
    {
      _length1 = inputLength;
    }
    public int GetLength1()
    {
      return _length1;
    }

    public void SetLength2(int inputLength)
    {
      _length2 = inputLength;
    }
    public int GetLength2()
    {
      return _length2;
    }

    public void SetLength3(int inputLength)
    {
      _length3 = inputLength;
    }
    public int GetLength3()
    {
      return _length3;
    }

    public string TriangleType()
    {
      bool same1And2 = _length1 == _length2;
      bool same2and3 = _length2 == _length3;
      bool same1and3 = _length1 == _length3;

      bool anySideGreater = (_length1 > _length2 + _length3) || (_length2 > _length1 + _length3) || (_length3 > _length2 + _length1);

      if (anySideGreater)
      {
        return "not a triangle";
      }
      else if (same1And2 && same2and3)
      {
        return "equilateral";
      }
      else if (same1And2 ^ same2and3)
      {
        return "isosceles";
      }
      else if (!same1And2 || !same1and3 || !same2and3)
      {
        return "scalene";
      }
      else
      {
        return "";
      }
    }
  }
}
