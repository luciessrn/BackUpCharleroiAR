using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineInvokRepeatMono : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent m_doSomething;
    public float m_interval = 1;
    public string m_errorHappened;
    private void OnEnable()
    {
        StartCoroutine(RunForever());
    }
    IEnumerator RunForever()
    {
        while (true)
        {
            yield return new WaitForSeconds(m_interval);
            if (m_interval <= 0) 
            {
                yield return new WaitForEndOfFrame();
            }
            try
            {
                m_doSomething.Invoke();
            }
            catch (System.Exception e) 
            {
                m_errorHappened = e.Message;
            }

            

            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
