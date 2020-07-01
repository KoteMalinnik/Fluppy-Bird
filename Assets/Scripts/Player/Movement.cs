using UnityEngine;

/// <summary>
/// Горизонтальное движение объекта с постоянной скоростью.
/// </summary>
public class Movement : CachedComponent<Rigidbody2D>
{
    /// <summary>
    /// Горизонтальная скорость движения объекта.
    /// </summary>
    [SerializeField, Range(0, 1000)]
    float Speed = 1.0f;

    private void FixedUpdate()
    {
        Component.velocity = new Vector2(Speed, Component.velocity.y);
    }
}
