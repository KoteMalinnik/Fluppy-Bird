using UnityEngine;

/// <summary>
/// Проверка объекта на выход за границы.
/// </summary>
public class BorderChecker: CachedComponent<Transform>
{
    /// <summary>
    /// Положительное значение высоты, при достижении которой игрок проигрывает. Работает как рамка сверху и снизу относительно направления вправо.
    /// </summary>
    [SerializeField, Range(1, 1000), Tooltip("Положительное значение высоты, при достижении которой игрок проигрывает. Работает как рамка сверху и снизу относительно направления вправо.")]
    float borderHeight = 1.0f;

    private void Update()
    {
        if (borderHeight - Mathf.Abs(Component.position.y) <= 0) //проверка на пересечение границ.
        {
            BorderCrossing();
        }
    }

    /// <summary>
    /// Обработка события пересечения границы.
    /// </summary>
    void BorderCrossing()
    {
        if (tempRele) return;

        Log.Message("Пересечение границы. Конец игры.");
        tempRele = true;
    }

    /// <summary>
    /// Временное реле, которое не позволяет методу BorderCrossing() вызываться постоянно, а только один раз.
    /// </summary>
    bool tempRele = false;
}
