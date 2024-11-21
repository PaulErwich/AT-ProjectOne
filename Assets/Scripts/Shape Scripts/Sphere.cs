using UnityEngine;

public class Sphere : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.lengths.Add(new LengthPair(LengthType.radius, 5));
        info.lengths.Add(new LengthPair(LengthType.diameter, 10));

        info.surfaceAreaCalculation = "The surface area of a sphere is 4 x \u03C0 x Radius^2.";
        info.surfaceAreaCalculation += $"\n\nIn this case that would be 4 x \u03C0 x {info.lengths[0].value}^2 = {GetSurfaceArea()}cm^2";

        info.volumeCalculation = "The volume of a sphere is 4/3 x \u03C0 x Radius^3";
        info.volumeCalculation += $"\n\nIn this case that would be 4/3 x \u03C0 x {info.lengths[0].value}^3 = {GetVolume()}cm^3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override float GetSurfaceArea() 
    {
        return 4 * Mathf.PI * Mathf.Pow(info.lengths[0].value, 2);
    }

    public override float GetVolume()
    {
        return 4.0f / 3.0f * Mathf.PI * Mathf.Pow(info.lengths[0].value, 3);
    }
}
