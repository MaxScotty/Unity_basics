using UnityEngine;

public class TestScript01 : MonoBehaviour
{
    BoxCollider2D _col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _col = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            _col.enabled = false; 
        }
    }
}
