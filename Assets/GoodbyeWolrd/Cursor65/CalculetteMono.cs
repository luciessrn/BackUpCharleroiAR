using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculetteMono : MonoBehaviour
{
    public float a;
    public float b;
    public float addition;
    public float soustraction;
    public float multiplication;
    public float division;
    public float modulo;
    public float hypothenus;
    public float sinus;

    private void OnValidate()
    {
        addition = a + b;
        soustraction = a - b;
        multiplication = a * b;
        division = a / b;
        modulo = a % b;
        hypothenus= Mathf.Sqrt((a*a)+(b*b));
        sinus = Mathf.Sin(a);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
