using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharController : MonoBehaviour
{
    [SerializeField] private float maxRunSpeed = 5f;

    //components
    private Rigidbody2D _playerRigidBody2D;
    private Animator _animator;

    //inputs
    private float horizontalInput = 0;
    private float verticalInput = 0;
    private ControlMapping playerInput;


    private void Awake()
    {
        playerInput = new ControlMapping();
        _playerRigidBody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        playerInput.PlayerCharacter.Enable();
        playerInput.PlayerCharacter.HorizontalMovement.performed += HorizontalMovementOnperformed;
        playerInput.PlayerCharacter.HorizontalMovement.canceled += HorizontalMovementOncanceled;
        playerInput.PlayerCharacter.VerticalMovement.performed += VerticalMovementOnperformed;
        playerInput.PlayerCharacter.VerticalMovement.canceled += VerticalMovementtOncanceled;
    }

    private void OnDisable()
    {
        playerInput.PlayerCharacter.Disable();
        playerInput.PlayerCharacter.HorizontalMovement.performed -= HorizontalMovementOnperformed;
        playerInput.PlayerCharacter.HorizontalMovement.canceled -= HorizontalMovementOncanceled;
        playerInput.PlayerCharacter.VerticalMovement.performed -= VerticalMovementOnperformed;
        playerInput.PlayerCharacter.VerticalMovement.canceled -= VerticalMovementtOncanceled;
    }

    private void Update()
    {
        _animator.SetFloat("horizontalInput", horizontalInput);
        _animator.SetFloat("verticalInput", verticalInput);
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(horizontalInput) > Mathf.Abs(verticalInput))
        {
            _playerRigidBody2D.velocity = new Vector2(maxRunSpeed * horizontalInput, 0f);
        }
        else if (Mathf.Abs(verticalInput) > Mathf.Abs(horizontalInput))
        {
            _playerRigidBody2D.velocity = new Vector2(0f, maxRunSpeed * verticalInput);
        }
        else
        {
            _playerRigidBody2D.velocity = Vector2.zero;
        }
    }

    private void HorizontalMovementOncanceled(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<float>();
    }

    void HorizontalMovementOnperformed(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<float>();
        verticalInput = 0;

      //  if (IsFacingBackwards())
       //   FlipCharacter();
    }

    private void VerticalMovementtOncanceled(InputAction.CallbackContext context)
    {
        verticalInput = context.ReadValue<float>();
    }

    private void VerticalMovementOnperformed(InputAction.CallbackContext context)
    {
        verticalInput = context.ReadValue<float>();
        horizontalInput = 0;
    }

    private bool IsFacingBackwards()
    {
        return transform.right.x < 0f && horizontalInput > 0f || transform.right.x > 0f && horizontalInput < 0f;
    }

    private void FlipCharacter()
    {
        print("Flipped");
        transform.right = -transform.right;
    }
}
