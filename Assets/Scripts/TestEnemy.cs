using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    [SerializeField] Transform _target;
    Vector2 _lastRotation;

    void Update()
    {
        Vector2 direction = _target.position - transform.position;
        if( _lastRotation != direction)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
            Debug.Log("Test");
        }
        _lastRotation = direction;
    }
}
