using UnityEngine;

/// <summary>
/// Прыжок объекта (приложение к объекту импульса, направленного вверх) с некоторой силой.
/// </summary>
public class Jumping: CachedComponent<Rigidbody2D>
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
            if (Input.GetTouch(0).phase == TouchPhase.Began) Jump();
        }
#endif
    }

    /// <summary>
    /// Приложит силу к объекту вертикально вверх.
    /// </summary>
    void Jump()
    {
        Component.velocity = new Vector2(Component.velocity.x, JumpForce);
        SoundController.PlaySound();
    }
}
