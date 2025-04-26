using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed;
    private Vector2 movement;

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //this stays empty
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    public void playerMove()
    {
        Vector3 moving = new Vector3(movement.x, 0f, movement.y); //where player is moving

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moving), 0.1f); //player roatation, turns towards moving direction, last value is rotate speed
        transform.Translate(moving * playerSpeed * Time.deltaTime, Space.World); //player movement, makes the player move
    }
}
