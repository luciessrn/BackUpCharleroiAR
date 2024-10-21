using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    [SerializeField] private Material _material;
    private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;
    private Transform _transform;
    [SerializeField] private Vector3 _position;

    void Start()
    {
       
        _transform = GetComponent<Transform>();
        _transform.position = new Vector3(1, 1, 1);
        _meshRenderer = GetComponent<MeshRenderer>();
        //_meshRenderer.material = _material;
        _meshRenderer.material.color = _color;
        _position = transform.position = _position;


    }


}
