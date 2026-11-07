using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ReceiveDamage : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI HealthText;
    public Image healthbar;
    public Animator enemyAnimator;
    public NavMeshAgent agent;
    public float totalhealth = 100f;
    void Start()
    {
        enemyAnimator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
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
            healthbar.fillAmount = health/totalhealth;
            if (health <= 0)
            {
                StartCoroutine(Death());
            }
        }
    }
    public IEnumerator Death()
    {
        agent.speed = 0;
        enemyAnimator.SetBool("IsDead", true);
        yield return new WaitForSecondsRealtime(3f);
        Destroy(gameObject);
    }
}
