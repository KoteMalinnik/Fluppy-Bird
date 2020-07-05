using UnityEngine;

/// <summary>
/// Проверка на успешное прохождение игроком дырки объекта Obstacle.
/// </summary>
public class HolePassChecker: MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Statements.GameOver) return;

        ScoreController.AddCurrentScore();
    }
}
