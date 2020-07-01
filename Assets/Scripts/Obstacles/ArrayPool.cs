using UnityEngine;

/// <summary>
/// Очередь Transform.
/// </summary>
public class ArrayPool
{
    Transform[] pool = null;

    /// <summary>
    /// Получить первый элемент очереди.
    /// </summary>
    public Transform GetFirst()
    {
        if (pool == null) return null;

        var newPool = new Transform[pool.Length - 1];
        
        for (int i = 0; i < pool.Length - 1; i++)
        {
            newPool[i] = pool[i + 1];
        }

        var top = pool[0];
        pool = newPool;
        
        return top;
    }

    /// <summary>
    /// Добавить элемент в конец очередь.
    /// </summary>
    /// <param name="element">Элемент.</param>
    public void AddElement(Transform element)
    {
        var newPool = new Transform[pool == null ? 1 : pool.Length + 1] ;

        for (int i = 0; i < newPool.Length - 1; i++)
        {
            newPool[i] = pool[i];
        }

        newPool[newPool.Length - 1] = element;
        pool = newPool;
    }
}
