using UnityEngine;
using System.Collections.Generic;

public class Cube : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Face area calculation is done by Width x Height
        info.areaCalculation = "The area of the face of a cube is Width x Height.";
        info.areaCalculation += $"\n\nIn this case that would be {info.lengths[0].value} x {info.lengths[1].value} = {info.lengths[0].value * info.lengths[1].value}cm^2";

        // Surface area calculation is done by Width x Height x 6 as Cube has 6 faces
        info.surfaceAreaCalculation = "The surface area of a cube is Width x Height x 6. This is because a cube has 6 identical faces";
        info.surfaceAreaCalculation += $"\n\nIn this case it's {info.lengths[0].value} x {info.lengths[1].value} x 6 = {info.lengths[0].value * info.lengths[1].value * 6}cm^2";

        // Volume calculation is done by Width x Height x Depth
        info.volumeCalculation = "The volume of a cube is Width x Height x Depth.";
        info.volumeCalculation += $"\n\nIn this case that would be {info.lengths[0].value} x " +
            $"{info.lengths[1].value} x {info.lengths[2].value} = {info.lengths[0].value * info.lengths[1].value * info.lengths[2].value}cm^3.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
