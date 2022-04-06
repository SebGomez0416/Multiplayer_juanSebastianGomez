using UnityEngine;

public class movePlayer : MonoBehaviour
{   [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private KeyCode  left;
    [SerializeField] private KeyCode  right;
    [SerializeField] private KeyCode  up;
    [SerializeField] private KeyCode  down;
    private void Update()
    {
        if (Input.GetKey(up))
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (Input.GetKey(down))
            transform.Translate(Vector3.back * (speed * Time.deltaTime));

        if (Input.GetKey(left))
            transform.Rotate(Vector3.down * (rotateSpeed * Time.deltaTime));
        if (Input.GetKey(right))
            transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
    }
}
