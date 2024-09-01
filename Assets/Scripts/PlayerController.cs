using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float moveSpeed;
    public float jumpForce;
    public Vector3 moveDirection;
    public CharacterController characterController;
    public float gravityScale = 5f;
    private Camera theCam;
    public GameObject playerModal;
    public float rotateSpeed;
    public Animator anim;

    public bool isKnocking;
    public float knockBackLength = 0.5f;
    private float knockbackCounter;
    public Vector2 knockbackPower;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        theCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isKnocking)
        {
            float yStore = moveDirection.y;
            moveDirection = transform.forward * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal");
            moveDirection.Normalize();
            moveDirection *= moveSpeed;
            moveDirection.y = yStore;

            if (characterController.isGrounded)
            {
                moveDirection.y = -1f;
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                }
            }
            moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;

            characterController.Move(moveDirection * Time.deltaTime);

            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                transform.rotation = Quaternion.Euler(0f, theCam.transform.rotation.eulerAngles.y, 0f);
                Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z));
                playerModal.transform.rotation = Quaternion.Slerp(playerModal.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
            }
        }

        if(isKnocking)
        {
            knockbackCounter -= Time.deltaTime;

            float yStore = moveDirection.y;
            moveDirection = playerModal.transform.forward * -knockbackPower.x;
            moveDirection.y = yStore;

            if (characterController.isGrounded)
            {
                moveDirection.y = -1f;
                
            }

            moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;


            characterController.Move(moveDirection * Time.deltaTime);
            

            if (knockbackCounter <= 0)
            {
                isKnocking = false;
            }
        }

        anim.SetFloat("Speed", Math.Abs(moveDirection.x) + Math.Abs(moveDirection.z));
        anim.SetBool("Grounded", characterController.isGrounded);
    }

    public void knockback()
    {
        isKnocking = true;
        knockbackCounter = knockBackLength;
        Debug.Log("Knock back");
        moveDirection.y = knockbackPower.y;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
