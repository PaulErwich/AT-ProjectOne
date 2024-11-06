using UnityEngine;

public class Sphere : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.surfaceAreaCalculation = "The surface area of a sphere is 4 x \u03C0 x Radius^2.";
        info.surfaceAreaCalculation += $"\n\nIn this case that would be 4 x \u03C0 x {info.lengths[0].value}^2 = {4 * Mathf.PI * Mathf.Pow(info.lengths[0].value, 2)}cm^2";

        info.volumeCalculation = "The volume of a sphere is 4/3 x \u03C0 x Radius^3";
        info.volumeCalculation += $"\n\nIn this case that would be 4/3 x \u03C0 x {info.lengths[0].value}^3 = {4.0f/3.0f * Mathf.PI * Mathf.Pow( info.lengths[0].value, 3)}cm^3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
