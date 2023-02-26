using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoovementScript : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] private float speed = 6f;
    public float gravity = -70;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDustance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velosuty;
    private bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDustance, groundMask);
        if (isGrounded && velosuty.y < 0)
        {
            velosuty.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * (speed * Time.deltaTime));

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velosuty.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velosuty.y += gravity * Time.deltaTime;

        controller.Move(velosuty * Time.deltaTime);
    }
}