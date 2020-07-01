using UnityEngine;
using System.Collections;

public class HolePassChecker: MonoBehaviour
{
    [ExecuteInEditMode]
    private void OnTriggerExit2D(Collider2D collision)
    {
        Log.Message("Успешное прохождение дырки.");
    }
}
