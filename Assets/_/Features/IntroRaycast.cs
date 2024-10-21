using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroRaycast : MonoBehaviour
{
    private Ray _ray;

    private void Update()
    {
        if(!Input.GetKeyDown(KeyCode.Mouse0)) return;
        Debug.Log(GetGameObjectByRaycast().name);
    }

    private GameObject GetGameObjectByRaycast()
    {
        _ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(_ray, out RaycastHit hit))
        {
            return hit.collider.gameObject;
        }
        return null;    
        
  

        }

        private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(_ray.origin, _ray.direction *10f);
    }
}
