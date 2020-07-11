using UnityEngine;

/// <summary>
/// Подготовка уровня к игре.
/// </summary>
public class OnLevelBegin : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;

        Statements.Pause = !Statements.GameOver;
        Statements.GameOver = false;

        ScoreController.LoadBestScore();
        ScoreController.ClearScore();
        
        GUIController.instance.UpdateScoreGUI(0);
        GUIController.instance.UpdateBestScoreGUI(ScoreController.bestScore);

        Destroy(gameObject);
    }
}
