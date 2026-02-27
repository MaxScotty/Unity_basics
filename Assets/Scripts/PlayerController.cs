using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;

    float _moveHorizontal;
    float _moveSpd = 10f;
    Vector2 _currentVelocity;

    bool _canInteract = false;

    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        _currentVelocity = new Vector2(_moveHorizontal, 0) * _moveSpd;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_canInteract == true)
            {
                Debug.Log("Turn on light switch!");
            }
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (_moveHorizontal != 0) 
            _rb.linearVelocity = _currentVelocity;
        else
        {
            _currentVelocity = new Vector2(0f, 0f);
            _rb.linearVelocity = _currentVelocity;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Ground")
        {
            Debug.Log("Enter");
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Ground")
            Debug.Log("Exit");
    }
}
