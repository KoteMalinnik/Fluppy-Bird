 using UnityEngine;

/// <summary>
/// Поворот объекта в направлении движения.
/// </summary>
public class RotationToVelocityVector: CachedComponent<Rigidbody2D>
{
    Transform _transform = null;
  
    new Transform transform
    {
        get
        {
            if (_transform == null) _transform = GetComponent<Transform>();
            return _transform;
        }
    }

    private void Update()
    {
        if (!Statements.GameOver) transform.right = (Vector2)transform.position + Component.velocity;
    }
}
