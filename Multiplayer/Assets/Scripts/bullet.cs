using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private string target;

     public delegate void PlayerKill();
     public static PlayerKill OnPlayerKill;
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag(target))
        {
            Destroy( c.gameObject);
            OnPlayerKill?.Invoke();
          
        }
    }
}
