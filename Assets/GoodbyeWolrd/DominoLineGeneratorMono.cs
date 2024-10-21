

using UnityEngine;

public class DominoLineGeneratorMono : MonoBehaviour
{
    public GameObject m_kaplaDomino;
    public Transform m_whereToCreateLine;
    public Vector3 m_euleurRotationAtStart;

    // Nombre de Kaplas dans la ligne
    public int m_numberOfKaplas = 10;
    // Distance entre chaque Kapla
    public float m_spacing = 1.0f;

    void Start()
    {
        // Direction de la ligne (exemple : vers l'axe Z)
        Vector3 direction = m_whereToCreateLine.forward;

        for (int i = 0; i < m_numberOfKaplas; i++)
        {
            // Créer un nouveau Kapla
            GameObject created = GameObject.Instantiate(m_kaplaDomino);

            // Calculer la position du Kapla
            Vector3 positionOffset = direction * i * m_spacing;
            created.transform.position = m_whereToCreateLine.position + positionOffset;

            // Appliquer la rotation initiale
            created.transform.Rotate(m_euleurRotationAtStart, Space.Self);
        }
    }
}
