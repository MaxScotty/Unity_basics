using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    float _moveSpeed = 10f;
    float _rotationSpeed = 100f;
    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, -_moveSpeed) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector2(-_moveSpeed, 0f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector2(_moveSpeed, 0f) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotationSpeed) * Time.deltaTime, Space.Self);
        }
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

 [SerializeField] GameObject _item;

    private void Start()
    {
        int itemCount = 8;

        for(int i = 0;  i < itemCount; i++)
        {
            SpawnItem();
        }
  
    }

    void SpawnItem()
    {
        Instantiate(_item, new Vector2(Random.Range(6.5f, - 6.5f), Random.Range(3.5f, -3.5f)),Quaternion.identity);
    }
*/