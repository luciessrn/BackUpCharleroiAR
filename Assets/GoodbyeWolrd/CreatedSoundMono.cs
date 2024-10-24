using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefabHereMono : MonoBehaviour
{
    public Transform m_whereToPlaySound;
    public GameObject m_prefab;
    public float timeToBeKilled = 10f;


    [ContextMenu("Create the prefab")]
    public void CreateThePrefab()
    {
        GameObject createdGameObject = GameObject.Instantiate(m_prefab);
        createdGameObject.name = "Created:" + m_prefab.name;
        createdGameObject.transform.position = m_whereToPlaySound.position;
        Destroy(createdGameObject, timeToBeKilled);
    }

}

public class CreateSoundHereMono : MonoBehaviour
{
    public Transform m_whereToPlaySound;
    public AudioClip m_sound;
    [Range(0, 1)]
    public float m_volume = 1.0f;

    [ContextMenu("Create the Sound")]
    public void CreateTheSound()
    {
        GameObject createdGameObject = new GameObject("Sound:" + m_sound.name);
        createdGameObject.transform.position = m_whereToPlaySound.position;
        AudioSource audioSource = createdGameObject.AddComponent<AudioSource>();
        audioSource.clip = m_sound;
        audioSource.volume = m_volume;
        audioSource.Play();
        float timeToBeKilled = m_sound.length;
        Destroy(createdGameObject, timeToBeKilled);
    }

}
