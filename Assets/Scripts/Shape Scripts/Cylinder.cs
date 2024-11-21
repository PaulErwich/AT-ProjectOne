using UnityEngine;

public class Cylinder : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.lengths.Add(new LengthPair(LengthType.height, 10));
        info.lengths.Add(new LengthPair(LengthType.radius, 5));
        info.lengths.Add(new LengthPair(LengthType.diameter, 10));

        info.areaCalculation = "A cylinder has 2 faces. The area of them is calculated differently.";
        info.areaCalculation += "\n\nThe circle is calculated by \u03C0 x Radius^2";
        info.areaCalculation += "\n\nThe cylindrical face is calculated by 2 x \u03C0 x Radius x Height";

        info.surfaceAreaCalculation = "The surface area of a cylinder is 2 x \u03C0 x Radius x Height + 2 x \u03C0 x Radius^2.";
        info.surfaceAreaCalculation += $"\n\nIn this case it's 2 x \u03C0 x {info.lengths[1].value} x {info.lengths[0].value} + 2 x \u03C0 x {info.lengths[1].value}^2";
        info.surfaceAreaCalculation += $" = {GetSurfaceArea()}cm^2.";

        info.volumeCalculation = "The volume of a cylinder is \u03C0 x Radius^2 x Height.";
        info.volumeCalculation += $"\n\nIn this case that would be \u03C0 x {info.lengths[1].value}^2 x {info.lengths[0].value} = {GetVolume()}^3.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override float GetSurfaceArea()
    {
        return (2.0f * Mathf.PI * info.lengths[1].value * info.lengths[0].value) + (2 * Mathf.PI * Mathf.Pow(info.lengths[1].value, 2));
    }

    public override float GetVolume()
    {
        return Mathf.PI * Mathf.Pow(info.lengths[1].value, 2) * info.lengths[0].value;
    }
}
