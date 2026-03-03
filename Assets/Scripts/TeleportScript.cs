using System.Collections;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    PlayerController _playerController;
    [SerializeField] GameObject _teleportLocation;

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //gameObject.transform.position = _teleportLocation.transform.position; 
            StartCoroutine(TeleportDelay());
        }
    }

    IEnumerator TeleportDelay() // skipping frames
    {
        _playerController._disableMovement = true;
        yield return null;
        gameObject.transform.position = _teleportLocation.transform.position;
        Debug.Log("The object was teleported!");
        yield return new WaitForSeconds(1f); //timer
        _playerController._disableMovement = false;
    }
}
