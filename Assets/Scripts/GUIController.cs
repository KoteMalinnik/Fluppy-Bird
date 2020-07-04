using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void ChangePauseStatement()
    {
        Statements.Pause = !Statements.Pause;
    }

    [SerializeField]
    GameObject panel_MainMenuGUI = null;

    [SerializeField]
    GameObject button_Pause = null;

    public void ChangeMainMenuGUIVisibility(bool state)
    {
        panel_MainMenuGUI.SetActive(state);
        button_Pause.SetActive(!state);
    }

    public void Play()
    {
        if (Statements.GameOver)
        {
            SceneManager.LoadScene(0);
        }
    }
}
