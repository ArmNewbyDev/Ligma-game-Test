using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private int playerSpeed = 10;
    [SerializeField] private int bentSpeed = 5;
    private Vector2 movementNewInput;

    
    
    void Start()
    {
        //Application.targetFrameRate = 0;
    }

   

    void OnMove(InputValue moveValue)
    {
        movementNewInput = moveValue.Get<Vector2>();
        //Debug.Log(movementNewInput);
    }
    
    void Update()
    {
        
        
            MoveNewInput();
        
        
    }

    void MoveNewInput()
    {
        //Debug.Log( "Movement vector = " + movementNewInput + ", Magnitude = " + movementNewInput.magnitude);
        
        
            transform.position += (Vector3) movementNewInput * playerSpeed * Time.deltaTime;

    }

    

    
}
