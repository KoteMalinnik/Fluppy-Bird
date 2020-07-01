using UnityEngine;

/// <summary>
/// Кешированный компонент.
/// </summary>
/// <typeparam name="T">Класс компонента.</typeparam>
public class CachedComponent<T>: MonoBehaviour where T : Component
{
    T component = null;

    /// <summary>
    /// Кешированный компонент.
    /// </summary>
    protected T Component
    {
        get
        {
            if (component == null) component = GetComponent<T>();
            return component;
        }
    }
}