/// <summary>
/// Управление счетом.
/// </summary>
public static class ScoreController
{
    /// <summary>
    /// Текущий счет.
    /// </summary>
    public static ushort score { get; private set; } = 0;
    
    /// <summary>
    /// Лучший счет.
    /// </summary>
    public static ushort bestScore { get; private set; } = 0;

    /// <summary>
    /// Добавить одно очко к счету.
    /// </summary>
    public static void AddCurrentScore()
    {
        if (Statements.GameOver) return;

        score++;
        Log.Message("Текущий счет: " + score);

        if (score > bestScore)
        {
            bestScore = score;
            Log.Message("Лучший счет: " + score);
        }
    }

    /// <summary>
    /// Сделает текущий счет равным 0.
    /// </summary>
    public static void ClearScore()
    {
        score = 0;
    }
}
