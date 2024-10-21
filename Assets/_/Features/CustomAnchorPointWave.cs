using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomAnchorPointWave : MonoBehaviour
{
    public static CustomAnchorPointWave Instance;

    private void Awake()
    {


        if (Instance != null) 
        {
            Destroy(gameObject);
            return;
        
        }
        Instance = this;

            
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
