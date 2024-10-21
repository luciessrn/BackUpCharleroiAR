using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPhysicMoveExo06 : MonoBehaviour
{
    private Vector3 movementVector;
    private Rigidbody rb;

    [SerializeField] private int speed = 8;


    public void HandleMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        movementVector = new Vector3(input.x, 0, input.y);
    }
    private void Update()
    {
        transform.Translate(movementVector * Time.deltaTime * speed);
    }
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        rb.AddForce(movementVector * speed);
    }
}
