using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //health
    [SerializeField] int _playerHealth = 100; //changing inside Unity
    float _playerSpeed = 0.5f;
    bool _isGrounded = true;
    string _playerName = "Hero";
    Vector2 _playerPos = new Vector2(-5f, 0f);

    Rigidbody2D _rb;

    private void Start()
    {
        //gameObject.transform.position = _playerPos;
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;

    }

    private void Update()
    {
        
    }

    //moving horizontally
    /*
    Rigidbody2D _rb;

    float _walkSpeed;
    float _inputHorizontal;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();

        _walkSpeed = 0.5f;

    }

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        }
    }
    */
}