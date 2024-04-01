using System.IO;
using UnityEngine;

public class Logger : MonoBehaviour
{
    private string logFilePath;

    private void Start()
    {
        string logFolderPath = Path.Combine(Application.dataPath, "Logs");
        if (!Directory.Exists(logFolderPath))
        {
            Directory.CreateDirectory(logFolderPath);
        }

        string logFileName = "log_" + System.DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".txt";
        logFilePath = Path.Combine(logFolderPath, logFileName);

        WriteLog($"Game open.");
    }

    private void OnApplicationQuit()
    {
        WriteLog("Game close.");
    }

    public void WriteLog(string logMessage)
    {
        using(StreamWriter writer = new StreamWriter(logFilePath, true)) 
        {
           writer.WriteLine($"[{ System.DateTime.Now.ToString()}]" + logMessage);       
        }
    }

}
