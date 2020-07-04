using UnityEngine;

/// <summary>
/// Управление звуком.
/// </summary>
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioListener))]
public class SoundController : MonoBehaviour
{
    /// <summary>
    /// Переменная звука. True, если звук включен.
    /// </summary>
    static bool sound = true;

    /// <summary>
    /// Переменная звука. True, если звук включен. Сохраняет новое значение в PlayerPrefs.
    /// </summary>
    public static bool Sound
    {
        get
        {
            if (Statements.GameOver) return false;
            if (Statements.Pause) return false;
            return sound;
        }
        set
        {
            sound = value;
            Serialization.Save("sound", sound);
        }
    }

    /// <summary>
    /// Источник звука.
    /// </summary>
    static AudioSource aSource = null;

    private void Awake()
    {
        aSource = GetComponent<AudioSource>();
        Destroy(this);
    }

    /// <summary>
    /// Проиграть звук.
    /// </summary>
    public static void PlaySound()
    {
        if (Sound) aSource.Play();
    }
}
