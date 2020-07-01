using UnityEngine;

public class CameraFolowing : CachedComponent<Transform>
{
    /// <summary>
    /// Объект для слежения.
    /// </summary>
    [SerializeField]
    Transform targetTransform = null;

    /// <summary>
    /// Отступ по горизонтальной оси;
    /// </summary>
    [SerializeField]
    float offsetX = -4;

   
    private void Awake()
    {
        if (targetTransform == null)
        {
            targetTransform = GameObject.FindWithTag("Player").transform;
        }
    }

    private void Update()
    {
        Component.position = new Vector3(targetTransform.position.x + offsetX, 0, -10);
    }
}
