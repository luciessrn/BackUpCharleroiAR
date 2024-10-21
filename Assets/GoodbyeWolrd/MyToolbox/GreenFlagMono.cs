using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GreenFlagMono : MonoBehaviour
{


   
    public UnityEvent m_onGameStart;

    // Start is called before the first frame update
    void Start()
    {
        m_onGameStart.Invoke();
    }

    
    [ContextMenu("Reset the Game")]
    void restartTheGame()
    {
        m_onGameStart.Invoke();
    }

}
