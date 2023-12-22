using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForceCoefficient = 100f;
    [SerializeField] float maximumPressTime = 3f;
    [SerializeField] float minimumJumpForce = 60f;
    [SerializeField] Vector2 jumpDirection;

    private float maximumJumpForce => jumpForceCoefficient * maximumPressTime;
    private float jumpForce;
    private float startTime;
    private bool isPressing;
    private bool isJumping;

    private void Awake()
    {
        isJumping = false;
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, jumpDirection * 100f, Color.red);
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseButtonDown();
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnMouseButtonUp();
        }
    }

    private void OnMouseButtonDown()
    {
        if (!isJumping)
        {
            isPressing = true;
            startTime = Time.time;
        }
    }

    private void OnMouseButtonUp()
    {
        isJumping = true;
        float pressTime = Time.time - startTime;
        if (pressTime < maximumPressTime)
        {
            jumpForce = jumpForceCoefficient * pressTime;
        }
        else
        {
            jumpForce = maximumJumpForce;
        }

        if (jumpForce < minimumJumpForce)
        {
            jumpForce = minimumJumpForce;
        }

        rb.AddForce(jumpDirection * jumpForce);
        rb.AddRelativeForce(transform.right * -jumpForce);
    }
}
