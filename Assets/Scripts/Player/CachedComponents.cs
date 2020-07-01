using UnityEngine;
using System.Collections;

/// <summary>
/// Кешированные компоненты Rigidbody2D и BoxCollider2D.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class CachedComponents: MonoBehaviour
{
    Rigidbody2D rigidody = null;

    /// <summary>
    /// Компонент Rigidbody2D объекта.
    /// </summary>
    protected Rigidbody2D Rigidbody
    {
        get
        {
            if (rigidody == null) rigidody = GetComponent<Rigidbody2D>();
            return rigidody;
        }
    }

    BoxCollider2D boxCollider = null;

    /// <summary>
    /// Компонент BoxCollider2D объекта.
    /// </summary>
    protected BoxCollider2D BoxCollider
    {
        get
        {
            if (boxCollider == null) boxCollider = GetComponent<BoxCollider2D>();
            return boxCollider;
        }
    }
}
