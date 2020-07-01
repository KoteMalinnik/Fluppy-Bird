using System.Diagnostics;
using System.Text;

/// <summary>
/// Логирование в консоль Unity.
/// </summary>
public static class Log
{
	/// <summary>
	/// Вернет имя класса, который вызвал метод вне класса Log.
	/// </summary>
	/// <returns>The sender name.</returns>
	static string getSenderName()
	{
		var stackTrace = new StackTrace();
		var prevFrame = stackTrace.GetFrame(2);
		var method = prevFrame.GetMethod();
		return method.ReflectedType.Name;
	}

	/// <summary>
	/// Выведет сообщение message в консоль Unity в формате "[Вызвывший класс] message".
	/// </summary>
	/// <param name="message">Сообщение.</param>
	public static void Message(object message)
	{
		UnityEngine.Debug.Log($"<color=yellow>[{getSenderName()}]</color> {message}");
	}


	/// <summary>
	/// Выведет сообщения message в консоль Unity в формате "[Вызвывший класс] message".
	/// </summary>
	/// <param name="message">Сообщения.</param>
	public static void Message(object[] message)
	{
		StringBuilder newMessage = new StringBuilder(32);

        for (int i = 0; i < message.Length; i++)
        {
			newMessage.AppendLine(message[i].ToString());
        }

		Message(newMessage);
	}

	/// <summary>
	/// Выведет ошибку с сообщением message в консоль Unity в формате "[Вызвывший класс] message".
	/// </summary>
	/// <param name="message">Сообщение.</param>
	public static void Error(string message)
	{
		UnityEngine.Debug.LogError($"<color=yellow>[{getSenderName()}]</color> <color=red>{message}</color>");
	}
}
