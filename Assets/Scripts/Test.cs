using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //moving
    Rigidbody2D _rb;

    float _walkSpeed;
    float _inputHorizontal;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();

        _walkSpeed = 5.5f;

    }

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        }
    }
}