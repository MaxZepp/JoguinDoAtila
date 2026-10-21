using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimentação : MonoBehaviour
{
    private float velocidade = 5f;
    private Rigidbody2D rb;
    private Vector2 entradaMovimento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        entradaMovimento = new Vector2(horizontal, vertical);

        if (entradaMovimento.sqrMagnitude > 1)
        {
            entradaMovimento.Normalize();
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = entradaMovimento * velocidade;
    }
}
