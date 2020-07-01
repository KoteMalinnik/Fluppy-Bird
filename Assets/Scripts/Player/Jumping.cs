using UnityEngine;

/// <summary>
/// Прыжок объекта (приложение к объекту импульса, направленного вверх) с некоторой силой.
/// </summary>
public class Jumping: CachedComponents
{
    /// <summary>
    /// Сила прыжка объекта.
    /// </summary>
    [SerializeField, Range(0, 1000)]
    float JumpForce = 1.0f;

#if UNITY_EDITOR
    [SerializeField]
    KeyCode JumpKey = KeyCode.Space;
#endif
    private void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(JumpKey))
        {
            Jump();
        }
#else
         if (Input.touchCount > 0)
        {
            Jump();
        }
#endif
    }

    /// <summary>
    /// Приложит силу к объекту вертикально вверх.
    /// </summary>
    void Jump()
    {
        cachedRigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }
}
