using UnityEngine;

/// <summary>
/// Обработка события столкновения игрока с объектом Obstacle.
/// </summary>
public class CollisionHandling: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Statements.GameOver) return;

        Log.Message("Столкновение . Конец игры.");
        Statements.GameOver = true;
        Statements.Pause = true;
    }
}
