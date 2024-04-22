using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] float _moveSpeed = 12f;
    [SerializeField] float _turnSpeed = 3f;

    Rigidbody _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MovePlayer();
        TurnPlayer();
    }

    void MovePlayer()
    {
        // S/Down = -1, W/Up = 1, None = 0. Scale by moveSpeed
        float moveAmountThisFrame = Input.GetAxisRaw("Vertical") * _moveSpeed;

        //Combine our direction with our calculatd amount
        Vector3 moveDirection = transform.forward * moveAmountThisFrame;

        //apply the movement to the physic object
        _rb.AddForce(moveDirection);

        _rb.drag = 2;

        _rb.angularDrag = 7;

    }

    void TurnPlayer()
    {
        //A/Left = -1. D/Right = 1. None = 0,. Scale by turnSpeed
        float turnAmountThisFrame = Input.GetAxisRaw("Horizontal") * _turnSpeed;

        //specifiy an axis to apply our turn amount (x,y,z) as a rotation
        Quaternion turnOffset = Quaternion.Euler(0, turnAmountThisFrame, 0);

        //spin the rigidbody
        _rb.MoveRotation(_rb.rotation * turnOffset);

    }

}
