using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogMono : MonoBehaviour
{
    public void LogMessages(string message)
    {
        Debug.Log(message);
    }

    public void LogWarning(string message) 
    { 
        Debug.LogWarning(message,this.gameObject); 
    }

    public void logErrror(string message)
    {
        Debug.LogError(message, this.gameObject);
    }

}
