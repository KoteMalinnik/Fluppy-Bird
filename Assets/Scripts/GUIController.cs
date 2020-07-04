using UnityEngine.UI;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public static GUIController instance = null;

    private void Awake()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        instance = null;
    }

    [SerializeField]
    Text text_Score = null;

    public void UpdateScoreGUI()
    {
        text_Score.text = ScoreController.score.ToString();
    }
}
