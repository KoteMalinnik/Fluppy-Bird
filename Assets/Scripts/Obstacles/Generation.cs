using UnityEngine;

/// <summary>
/// Генератор преград.
/// </summary>
[RequireComponent(typeof(ObstacleReplacer))]
public class Generation : MonoBehaviour
{
    /// <summary>
    /// Количество генерируемых объектов.
    /// </summary>
    [SerializeField, Range(1,10)]
    int ObstaclesCount = 1;

    [SerializeField]
    GameObject ObstaclePrefab = null;

    private void Awake()
    {
        if (ObstaclePrefab == null) Log.Error("Префаб преграды пуст.");

        Log.Message("Генерация преград в количестве: " + ObstaclesCount);

        ArrayPool pool = new ArrayPool();

        var replacer = GetComponent<ObstacleReplacer>();
        for (int i = 0; i < ObstaclesCount; i++)
        {
            var obstacle = Instantiate(ObstaclePrefab, Vector3.zero, Quaternion.identity, transform);
            obstacle.name = i.ToString();
            replacer.Replace(obstacle.transform);

            pool.AddElement(obstacle.transform);
        }

        replacer.Initialize(pool);

        Destroy(this);
    }
}