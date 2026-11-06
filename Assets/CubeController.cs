using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCube : MonoBehaviour
{
    public Animator animator_;
    private bool mueve = false;
    void Start()
    {
        animator_ = GetComponent<Animator>();
    }
    void Update()
    {

    }
    public void MoveCube(InputValue value)
    {
        animator_.SetBool("Move", true);
    }
}
