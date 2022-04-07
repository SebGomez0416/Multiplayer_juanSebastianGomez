using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform spwanPoint;

    [SerializeField] private float shootforce;
    [SerializeField]private float shootRate;
    [SerializeField]private float shootRateTime;
    [SerializeField] private bool keyboard;

    private void Update()
    {
        if (keyboard)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Shoot();
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
                Shoot();
        }
    }

    private void Shoot()
    {
        if (Time.time > shootRateTime)
        {
            GameObject newBullet;
            newBullet = Instantiate(_bullet, spwanPoint.position, spwanPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spwanPoint.forward * shootforce);

            shootRateTime = Time.time + shootRate;
            Destroy(newBullet, 2);

        }
    }
}
