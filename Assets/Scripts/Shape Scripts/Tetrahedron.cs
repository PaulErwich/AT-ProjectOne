using UnityEngine;

public class Tetrahedron : Shape
{
    private void Awake()
    {
        info.lengths.Add(new LengthPair(LengthType.width, 10));
        info.lengths.Add(new LengthPair(LengthType.height, 8.16f));

        info.surfaceAreaCalculation = "The surface area of a tetrahedron is Square root of 3 x width^2.";
        info.surfaceAreaCalculation += $"\n\nIn this case it's Square root of 3 x {info.lengths[0].value} = {GetSurfaceArea()}cm^2";

        info.volumeCalculation = "The volume of a tetrahedron is width^3 / (6 x Square root 2).";
        info.volumeCalculation += $"\n\nIn this case that would be {info.lengths[0].value}^3 / (6 x Square root 2) = {GetVolume()}cm^3.";
    }

    public override float GetSurfaceArea()
    {
        return Mathf.Sqrt(3) * Mathf.Pow(info.lengths[0].value, 2);
    }

    public override float GetVolume()
    {
        return Mathf.Pow(info.lengths[0].value, 3) / (6 * Mathf.Sqrt(2));
    }
}
