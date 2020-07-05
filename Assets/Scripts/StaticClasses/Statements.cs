using UnityEngine;
///<summary>
/// Состояния игрового процесса.
///</summary>
public static class Statements
{
    static bool pause = true;

    ///<summary>
    /// Пауза.
    ///</summary>
    public static bool Pause
    {
        get
        {
            return pause;
        }
        set
        {
            pause = value;
            Time.timeScale = pause ? 0 : 1;

            GUIController.instance.ChangeMainMenuGUIVisibility(pause);
        }
    }

    static bool gameOver = false;

    ///<summary>
    /// Конец игры.
    ///</summary>
    public static bool GameOver
    {
        get
        {
            return gameOver;
        }
        set
        {
            gameOver = value;
        }
    }
}
