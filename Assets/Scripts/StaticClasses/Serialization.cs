using UnityEngine;

/// <summary>
/// Сериализация игровых данных.
/// </summary>
public static class Serialization
{
    /// <summary>
    /// Сохранение значения типа bool.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="value">Значение.</param>
    public static void Save(string key, bool value)
    {
        int val = value ? 1 : 0;
        Save(key, val);
    }

    /// <summary>
    /// Сохранение значения типа int.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="value">Значение.</param>
    public static void Save(string key, int value)
    {
        Log.Message($"Сохранения значения -{key}- = -{value}-.");
        PlayerPrefs.SetInt(key, value);
    }

    /// <summary>
    /// Загрузка значения типа int.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="defaultValue">Значение по умолчанию.</param>
    public static int Load(string key, int defaultValue = 0)
    {
        int value = defaultValue;
        if (PlayerPrefs.HasKey(key)) value = PlayerPrefs.GetInt(key);
       
        Log.Message($"Загрузка значения -{key}- = -{value}-.");

        return value;
    }

    /// <summary>
    /// Загрузка значения типа bool.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="defaultValue">Значение по умолчанию.</param>
    public static bool Load(string key, bool defaultValue = true)
    {
        bool value = defaultValue;
        if (PlayerPrefs.HasKey(key))
        {
            int val = PlayerPrefs.GetInt(key);
            value = val == 1;
        }
       
        Log.Message($"Загрузка значения -{key}- = -{value}-.");
       
        return value;
    }
}
