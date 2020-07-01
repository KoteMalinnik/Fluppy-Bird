using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movement : CachedComponents
{
    /// <summary>
    /// Горизонтальная скорость движения объекта.
    /// </summary>
    [SerializeField, Range(0, 1000)]
    float Speed = 1.0f;
}
