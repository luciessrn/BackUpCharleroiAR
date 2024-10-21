//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.Rendering.LookDev;
//using UnityEngine;

//public class PlayerManager : MonoBehaviour
//{
//    [SerializeField] private GridGenerator _gridGenerator;
//    [SerializeField] private Transform _playerPrefab;
//    [SerializeField] private float _zOffset;

//    private Transform _playerTransform;
//    private int _playerIndex;


//    private void Start()
//    {
//        _playerTransform = Instantiate(_playerPrefab,
//            _gridGenerator.GameObjectArray[_playerIndex].transform.position,
//            Quaternion.identity);

//        AddPlayerOffset();
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.UpArrow))
//        {
//            int newIndex = _playerIndex + _gridGenerator._gridSize.x;
//            if (newIndex < _gridGenerator.GameObjectArray.Length)
//            {
//                _playerIndex = newIndex;
//                _playerTransform.position = _gridGenerator.GameObjectArray[_playerIndex].transform.position;
//                AddPlayerOffset();
//            }

//        }

//        if (Input.GetKeyDown(KeyCode.DownArrow))
//        {
//            int newIndex = _playerIndex - _gridGenerator._gridSize.x;
//            if (newIndex >= 0)
//            {
//                _playerIndex = newIndex;
//                _playerTransform.position = _gridGenerator.GameObjectArray[_playerIndex].transform.position;
//                AddPlayerOffset();
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.LeftArrow))
//        {
//            int newIndex = _playerIndex - 1;
//            if (newIndex >= 0)
//            {
//                _playerIndex = newIndex;
//                _playerTransform.position = _gridGenerator.GameObjectArray[_playerIndex].transform.position;
//                AddPlayerOffset();
//            }
//        }

//        if (Input.GetKeyDown(KeyCode.RightArrow))
//        {
//            int newIndex = _playerIndex + 1;
//            if (newIndex < _gridGenerator.GameObjectArray.Length)
//            {
//                _playerIndex = newIndex;
//                _playerTransform.position = _gridGenerator.GameObjectArray[_playerIndex].transform.position;
//                AddPlayerOffset();
//            }
//        }
//    }
//    private void AddPlayerOffset()
//    { _playerTransform.position += new Vector3(0, 0, -_zOffset); }
//} >>> C'est le même scripte mais celui du bas est plus otpimisé




using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GridGenerator _gridGenerator;
    [SerializeField] private Transform _playerPrefab;

    [Space]
    [SerializeField] private float _zOffset;

    private Transform _playerTransform;
    private int _playerIndex;


    private void Start()
    {
        _playerTransform = Instantiate(_playerPrefab);

        MovePlayerOnGrid(0, true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            int newIndex = _playerIndex + _gridGenerator._gridSize.x;
            if (newIndex < _gridGenerator.GameObjectArray.Length)
            {
                _playerIndex = newIndex;
                MovePlayerOnGrid(_playerIndex, true);
            }
        }
    }

    private void MovePlayerOnGrid(int gameObjectIndex, bool withOffset = false)
    {
        MovePlayerTo(_gridGenerator.GameObjectArray[gameObjectIndex].transform.position, withOffset);
    }

    private void MovePlayerTo(Vector3 newPosition, bool withOffset = false)
    {
        _playerTransform.position = newPosition;

        if (withOffset)
        {
            _playerTransform.position += new Vector3(0, 0, -_zOffset);
        }
    }
}





