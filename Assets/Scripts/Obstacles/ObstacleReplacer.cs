using System;
using UnityEngine;

/// <summary>
/// Перемещение преград.
/// </summary>
public class ObstacleReplacer : MonoBehaviour
{
    /// <summary>
    /// Промежуток между преградами.
    /// </summary>
    [SerializeField, Range(1, 50)]
    float deltaPositionX = 2.0f;

    /// <summary>
    /// Максимальная высота, на которой может быть расположена дырка.
    /// </summary>
    [Space, SerializeField, Range(0, 30)]
    float holeHeight = 0f;

    /// <summary>
    /// Отступ позиции для следующего перемещения.
    /// </summary>
    [SerializeField]
    float offsetX = 0f;

    /// <summary>
    /// Перемещение Transform-а преграды.
    /// </summary>
    /// <param name="obstacle"></param>
    public void Replace(Transform obstacle)
    {
        Log.Message($"Перемещение объекта -{obstacle.name}-.");

        offsetX += deltaPositionX;
        var positionY = UnityEngine.Random.Range(-holeHeight, holeHeight);
        obstacle.position = new Vector3(offsetX, positionY, 0);
    }

    ArrayPool pool = new ArrayPool();
    /// <summary>
    /// Целевой transform, относительно которого будет просматриваться позиция и происходить перемещение преград.
    /// </summary>
    Transform target = null;

    /// <summary>
    /// Инициализация очереди и целевого Transform.
    /// </summary>
    /// <param name="pool">Очередь с объектами преград.</param>
    public void Initialize(ArrayPool pool)
    {
        this.pool = pool ?? throw new ArgumentNullException();
        target = Camera.main.transform;
    }
	
	[SerializeField, Range(1,10)]
	float obstacleReplaceOffsetX = 10;
    
    private void Update()
    {
        if (pool.CheckFirst().position.x < target.position.x - obstacleReplaceOffsetX) //если за пределами видимости камеры.
        {
            var obstacleToReplace = pool.GetFirst();
            Replace(obstacleToReplace);
            pool.AddElement(obstacleToReplace);
        }
    }
}
