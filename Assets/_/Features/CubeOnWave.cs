using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOnWave : MonoBehaviour
{

    [SerializeField] private float _amplitude;
    [SerializeField] private float _frequency;
    [SerializeField] private float _speed;

    
    


    private Transform _transform;
    private float _currentTime;
    private float _startPos;
    private float _endPos;

    private CustomAnchorPointWave _anchorPointWave;

    private void Awake()
    {
        _transform = transform;

        _anchorPointWave = CustomAnchorPointWave.Instance;
        _startPos = transform.position.z - _amplitude * 0.5f;
        _endPos = transform.position.z + _amplitude * 0.5f;

    }

    private void Start()
    {
        _anchorPointWave = CustomAnchorPointWave.Instance;
        _currentTime =Vector3.Distance(_anchorPointWave.GetPosition(), transform.position) * _frequency;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime*_speed;

        float positionOnSin = Mathf.Sin(_currentTime) * 0.5f + 0.5f;


        Vector3 newPos = new Vector3(_transform.position.x,
            _transform.position.y,
            Mathf.Lerp(_startPos, _endPos, positionOnSin));

        _transform.position= newPos;
   
    }

}
