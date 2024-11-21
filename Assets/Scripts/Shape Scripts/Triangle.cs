using UnityEngine;

public class Triangle : TwoDShape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.lengths.Add(new LengthPair(LengthType.width, 10));
        info.lengths.Add(new LengthPair(LengthType.height, 10));

        info.areaCalculation = "The area of a triangle is 1/2 x Base x Height.";
        info.areaCalculation += $"\n\nIn this case that's 1/2 x {info.lengths[0].value} x {info.lengths[1].value} = {GetArea()}cm^2.";

        info.perimeterCalculation = "The perimeter of a triangle is the sum of all its sides";
        info.perimeterCalculation += $"\n\nIn this case that's {info.lengths[0].value} + {info.lengths[0].value} + " +
            $"{info.lengths[0].value} = {GetPerimeter()}cm.";
    }

    public override float GetArea()
    {
        return 0.5f * info.lengths[0].value * info.lengths[1].value;
    }

    public override float GetPerimeter()
    {
        return info.lengths[0].value * 3;
    }
}
