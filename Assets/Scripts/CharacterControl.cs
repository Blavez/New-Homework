using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private float jumpSpeed = 8.0f;
    [SerializeField] private float gravity = 20.0f;
    private Vector3 moveDir = Vector3.zero;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && (controller.isGrounded)&&(!Input.GetKey(KeyCode.LeftShift)))
        {
            moveDir.y = jumpSpeed;
        }
        if (Input.GetKey(KeyCode.LeftShift) && controller.isGrounded)
        {
            moveDir *= speed*1.1f;
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
}