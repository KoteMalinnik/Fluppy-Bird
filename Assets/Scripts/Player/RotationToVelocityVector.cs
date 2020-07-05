 using UnityEngine;

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

    Vector2 position = Vector2.zero;
    private void Update()
    {
        position = transform.position;
        Debug.DrawLine(position, position + Component.velocity);
    }
}
