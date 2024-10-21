using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloLoopMono : MonoBehaviour
{

    public GameObject m_prefab;
    public Transform m_transform;
    public float m_distance = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = Vector3.up;
        for (int i = 0; i < 10; i++)
        {
            GameObject created = Instantiate(m_prefab);
            created.transform.position = m_transform.position;
            created.transform.position += direction * i * m_distance; ; 
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
