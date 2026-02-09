using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]int _playerHealth = 100;
    int _playerShield = 50;

    public int PlayerHealth
    {
        get {return _playerHealth;}
        set {_playerHealth = value;}
    }

    public int PlayerShield
    {
        get { return _playerShield ; }
        set { _playerShield = value; }
    }

    private void Start()
    {
        Debug.Log("You took " + DamageTaken(80) + " in damage");
    }

    int DamageTaken(int damage)
    {
        int damageTaken;

        {
            Debug.Log("Shield is not destroyed!");
            damageTaken = 0;
        }

        return damageTaken;
    }
}


//moving horizontally
/*
float _playerSpeed = 0.5f;
bool _isGrounded = true;
string _playerName = "Hero";
Vector2 _playerPos = new Vector2(-5f, 0f);

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

if (damage < PlayerShield)
        {
            Debug.Log("Shield isn't destroyed!");
            damageTaken = 0;
        }
        else if (damage == PlayerShield)
        {
            Debug.Log("Shield destroyed!");
            damageTaken = 0;
        }
        else
        {
            Debug.Log("Shield destroyed and damage taken!");
            damageTaken = damage - PlayerShield;
        }
*/