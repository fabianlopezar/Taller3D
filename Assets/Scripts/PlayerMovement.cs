//https://youtu.be/RCKogZqlgDk
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _runSpeed = 7;
    public float _rotationSpeed = 250;
    public Animator animator;
    public float x, y;


    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * _rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * _runSpeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}
