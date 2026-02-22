using UnityEngine;

public class TestScript02 : MonoBehaviour
{
    [SerializeField] GameObject _squareParent;
    [SerializeField] GameObject _square;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            _squareParent.SetActive(false);
        }
    }
}
