using UnityEngine;

/// <summary>
/// Изменение размера дырки объекта Obstacles в режиме Edit.
/// </summary>
public class HoleResizer : MonoBehaviour
{
    [SerializeField]
    Transform upperBox = null;

    [SerializeField]
    Transform downerBox = null;

    [SerializeField]
    BoxCollider2D hole = null;

    [Space, SerializeField, Range(1,5)]
    float holeSize = 2.0f;

    private void OnValidate()
    {
        resize();
    }

    [ExecuteInEditMode]
    void resize()
    {
        hole.size = new Vector2(hole.size.x, holeSize);
        upperBox.transform.localPosition = new Vector3(0, 0.38f + holeSize/2, 0);
        downerBox.transform.localPosition = -upperBox.transform.localPosition;
    }
}
