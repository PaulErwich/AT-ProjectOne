using UnityEngine;

public class Circle : TwoDShape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.lengths.Add(new LengthPair(LengthType.radius, 5));
        info.lengths.Add(new LengthPair(LengthType.diameter, 10));

        info.areaCalculation = "The area of a circle is \u03C0 x Radius^2";
        info.areaCalculation = $"\n\nIn this case that's \u03C0 x {info.lengths[0].value}^2 = {GetArea()}cm^2.";

        info.perimeterCalculation = "The perimeter of a circle is 2 x \u03C0 x Radius.";
        info.perimeterCalculation = $"\n\nIn this case that's 2 x \u03C0 x {info.lengths[0].value} = {GetPerimeter()}cm^2.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override float GetArea()
    {
        return Mathf.Pow(info.lengths[0].value, 2) * Mathf.PI;
    }

    public override float GetPerimeter()
    {
        return 2 * Mathf.PI * info.lengths[0].value;
    }
}
