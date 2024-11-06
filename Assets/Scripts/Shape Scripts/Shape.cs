using UnityEngine;
using System;
using System.Collections.Generic;

public class Shape : MonoBehaviour
{
    [SerializeField]
    public ShapeInfo info;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.areaCalculation += $"\nIn this case that would be {info.lengths[0].value} x {info.lengths[1].value} = {info.lengths[0].value * info.lengths[1].value}";
        info.volumeCalculation += $"\nIn this case that would be {info.lengths[0].value} x " +
            $"{info.lengths[1].value} x {info.lengths[2].value} = {info.lengths[0].value * info.lengths[1].value * info.lengths[2].value}.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class ShapeInfo
{
    public ShapeType type;
    public string areaCalculation;
    public string surfaceAreaCalculation;
    public string volumeCalculation;
    public List<LengthPair> lengths = new List<LengthPair>();
}
public enum ShapeType
{
    Cube,
    Cuboid,
    Sphere,
    Cylinder,
    SquareBasePyramid,
}

public enum LengthType
{
    width,
    height,
    depth,
    radius,
    diameter
}
[Serializable]
public struct LengthPair
{
    public LengthPair(LengthType _type, float _value)
    {
        type = _type;
        value = _value;
    }

    public LengthType type;
    public float value;
}