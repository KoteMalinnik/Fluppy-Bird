using UnityEngine;

public class Movement : CachedComponents
{
    /// <summary>
    /// Горизонтальная скорость движения объекта.
    /// </summary>
    [SerializeField, Range(0, 1000)]
    float Speed = 1.0f;

    private void FixedUpdate()
    {
        cachedRigidbody.velocity = new Vector2(Speed, cachedRigidbody.velocity.y);
    }
}
