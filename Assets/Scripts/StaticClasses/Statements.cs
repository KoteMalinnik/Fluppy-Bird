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
            Log.Message("Пазуа: " + pause);
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
            Log.Message("Проигрыш: " + gameOver);
        }
    }
}
