using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveDamage : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI HealthText;
    public Image healthbar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Received Damage");
            Destroy(collision.gameObject);
            health -= 10;
            HealthText.text = health.ToString();
            healthbar.fillAmount = health/100f;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
