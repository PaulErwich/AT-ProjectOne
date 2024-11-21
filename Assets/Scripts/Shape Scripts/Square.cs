using UnityEngine;

public class Square : TwoDShape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.lengths.Add(new LengthPair(LengthType.width, 10));
        info.lengths.Add(new LengthPair(LengthType.height, 10));

        info.areaCalculation = "The area of a square is Width x Height.";
        info.areaCalculation += $"\n\nIn this case that's {info.lengths[0].value} x {info.lengths[1].value} = {GetArea()}cm^2.";

        info.perimeterCalculation = "The perimeter of a square is the sum of all it's sides.";
        info.perimeterCalculation += $"\n\nIn this case that's {info.lengths[0].value} + {info.lengths[0].value} + " +
            $"{info.lengths[1].value} + {info.lengths[0].value} = {GetPerimeter()}cm.";
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override float GetArea()
    {
        return info.lengths[0].value * info.lengths[1].value;
    }

    public override float GetPerimeter()
    {
        return info.lengths[0].value * 2 + info.lengths[1].value * 2;
    }
}
