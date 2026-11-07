using UnityEngine;

public class DestruirBalas : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (! collision.gameObject.CompareTag("Enemy") || !collision.gameObject.CompareTag("BigEnemy"))
        {
            Destroy(gameObject);
        }
    }
}
