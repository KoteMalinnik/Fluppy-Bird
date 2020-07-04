/// <summary>
/// Управление счетом.
/// </summary>
public static class ScoreController
{
    /// <summary>
    /// Текущий счет.
    /// </summary>
    public static int score { get; private set; } = 0;
    
    /// <summary>
    /// Лучший счет.
    /// </summary>
    public static int bestScore { get; private set; } = 0;

    /// <summary>
    /// Добавить одно очко к счету.
    /// </summary>
    public static void AddCurrentScore()
    {
        if (Statements.GameOver) return;

        score++;
        Log.Message("Текущий счет: " + score);
        GUIController.instance.UpdateScoreGUI(score);

        if (score > bestScore)
        {
            bestScore = score;
            Log.Message("Лучший счет: " + score);
            GUIController.instance.UpdateBestScoreGUI(bestScore);
            Serialization.Save("bestScore", bestScore);
        }
    }

    /// <summary>
    /// Сделает текущий счет равным 0.
    /// </summary>
    public static void ClearScore()
    {
        score = 0;
    }

    public static void LoadBestScore()
    {
        bestScore = Serialization.Load("bestScore", 0);
    }
}
