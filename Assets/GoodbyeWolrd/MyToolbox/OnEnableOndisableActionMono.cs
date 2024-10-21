using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableOndisableActionMono : MonoBehaviour
{  public UnityEvent m_onEnable;
    public UnityEvent m_onDisable;

    // Start is called before the first frame update
    void OnEnable()
    {
        m_onEnable.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        m_onDisable.Invoke();
    }
}
