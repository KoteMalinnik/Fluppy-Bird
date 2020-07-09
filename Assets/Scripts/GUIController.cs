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

    /// <summary>
    /// Обновит очки на GUI.
    /// </summary>
    public void UpdateScoreGUI(int val)
    {
        text_Score.text = val.ToString();
    }

    [SerializeField]
    Text text_bestScoreValue = null;

    public void UpdateBestScoreGUI(int val)
    {
        text_bestScoreValue.text = val.ToString();
    }

    /// <summary>
    /// Изменит состояние паузы на обратное.
    /// </summary>
    public void ChangePauseStatement()
    {
        Statements.Pause = !Statements.Pause;
    }

    [SerializeField]
    GameObject panel_MainMenuGUI = null;

    [SerializeField]
    GameObject button_Pause = null;

    /// <summary>
    /// Переключит видимость объектов panel_MainMenuGUI и button_Pause.
    /// </summary>
    /// <param name="state"></param>
    public void ChangeMainMenuGUIVisibility(bool state)
    {
        panel_MainMenuGUI.SetActive(state);
        button_Pause.SetActive(!state);
    }

    /// <summary>
    /// Перезагрузит сцену, если игрок проиграл.
    /// </summary>
    public void Restart()
    {
        if (Statements.GameOver)
        {
            SceneManager.LoadScene(0);
        }
    }

    [SerializeField]
    Toggle sound = null;

    /// <summary>
    /// Присвоит значению звука значение переключателя sound.
    /// </summary>
    public void ChangeSoundToggle()
    {
        SoundController.Sound = !sound.isOn;
    }

    private void Start()
    {
        sound.isOn = !Serialization.Load("sound", true);
        ChangeSoundToggle();
    }
}
