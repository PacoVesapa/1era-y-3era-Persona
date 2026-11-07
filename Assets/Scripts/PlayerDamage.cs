using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public int vida = 100;
    public Image BarraVida;
    public Image BarraVidaFondo;
    public float totalhealth = 100f;
    public float tiempoinmune = 2f;
    public bool esInmune = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy") && !esInmune)
        {
            Debug.Log("Received Damage");
            vida -= 10;
            StartCoroutine(BarrasDeVida());
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && !esInmune)
        {
            Debug.Log("Received Damage");
            vida -= 10;
            StartCoroutine(BarrasDeVida());
        }
    }
    public IEnumerator BarrasDeVida()
    {
        BarraVida.fillAmount = vida / totalhealth;
        esInmune = true;
        yield return new WaitForSeconds(tiempoinmune);
        yield return StartCoroutine(FondoVida());
        esInmune = false;
        yield return null;
    }
    public IEnumerator FondoVida()
    {
        while (BarraVidaFondo.fillAmount > BarraVida.fillAmount)
        {
            BarraVidaFondo.fillAmount -= 0.01f;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
