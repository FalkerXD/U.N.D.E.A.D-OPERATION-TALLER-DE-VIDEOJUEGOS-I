using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb.gravityScale = 0;  // Asegurarse de que la gravedad est� desactivada
    }

    void Update()
    {
        // Capturamos la entrada del teclado
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Invertimos el sprite del personaje seg�n la direcci�n del movimiento
        if (movement.x > 0)
        {
            spriteRenderer.flipX = false; // Mirando a la derecha
        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true; // Mirando a la izquierda
        }
    }

    void FixedUpdate()
    {
        // Movemos el personaje
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
