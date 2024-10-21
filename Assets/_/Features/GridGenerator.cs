using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToSpawn;

    [Space]
    [SerializeField] public Vector2Int _gridSize;
    [SerializeField] private float _offset;

    public GameObject[] GameObjectArray;
    private Transform _transform;


    private void Awake()
    {
        _transform = GetComponent<Transform>();
        SpawnGrid();
    }
    private void SpawnGrid()
    {
        uint index = 0;
        GameObjectArray = new GameObject[_gridSize.x * _gridSize.y];



        for (int y = 0; y < _gridSize.y; y++)
        {
            for (int x = 0; x < _gridSize.x; x++)
            {
                GameObjectArray[index] = Instantiate(_prefabToSpawn,
                    new Vector3(x * _offset, y * _offset, 0),
                    Quaternion.identity,
                    transform);

                index++;
            }
        }
        ColorOutline();
    }

    private void ColorOutline()
    {
        for (int i = 0; i < GameObjectArray.Length; i++)
        {
            if (i % _gridSize.x == 0)
            {
                GameObjectArray[i].GetComponentInChildren<MeshRenderer>().material.color = Color.white;
            }

        }
        for (int i = 0; i < GameObjectArray.Length; i++)
        {
            if (i % _gridSize.x == 4)
            {
                GameObjectArray[i].GetComponentInChildren<MeshRenderer>().material.color = Color.white;
            }

        }
        for (int i = 0; i < _gridSize.x; i++) 
        { 
        
            GameObjectArray[i].GetComponentInChildren<MeshRenderer>().material.color = Color.white;
        
        }

        int lastIndex = GameObjectArray.Length - 1;
        int indexTopLeft = lastIndex - _gridSize.x;
        for (int i = lastIndex; i > indexTopLeft; i--)
        {
            GameObjectArray[i].GetComponentInChildren<MeshRenderer>().material.color = Color.white;

        }

    }


}  
