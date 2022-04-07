using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            Debug.Log("choco");
        }
    }
}
