﻿using UnityEngine;

/// <summary>
/// Подготовка уровня к игре.
/// </summary>
public class OnLevelBegin : MonoBehaviour
{
    private void Awake()
    {
        Statements.Pause = !Statements.GameOver;
        Statements.GameOver = false;

        ScoreController.ClearScore();
        GUIController.instance.UpdateScoreGUI();

        Destroy(gameObject);
    }
}