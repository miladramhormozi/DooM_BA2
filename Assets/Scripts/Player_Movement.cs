using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    CharacterController controller;
    Vector3 movementVector;
    public float WalkSpeed;
    public float RunSpeed;
    public float Gravity;
    public float JumpHeight;
    public int JumpCount = 2;

    float movementX;
    float movementY;
    float movementZ;
    float localSpeed;
    int jumpRemained;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        localSpeed = WalkSpeed;
    }


    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        movementZ = Input.GetAxis("Vertical");


        if (controller.isGrounded)
        {
            movementY = -0.1f;
            jumpRemained = JumpCount;

        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpRemained > 0)
        {
            movementY = Mathf.Sqrt(JumpHeight * 2 * Gravity);
            jumpRemained--;

        }


        movementVector = transform.right * movementX + transform.forward * movementZ;
        if (movementVector.magnitude > 1)
        {
            movementVector.Normalize();
        }


        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            localSpeed = Mathf.Lerp(localSpeed, RunSpeed, 0.05f);
        }
        else
        {
            localSpeed = Mathf.Lerp(localSpeed, WalkSpeed, 0.05f);
        }

        movementVector = movementVector * localSpeed;

        movementVector += (transform.up * movementY);

        controller.Move(movementVector * Time.deltaTime);

        movementY -= Gravity * Time.deltaTime;


    }
}
