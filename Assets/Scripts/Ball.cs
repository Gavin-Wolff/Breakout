
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 originalScale;
    public GameManager gameManager;
    public Rigidbody2D rb;
    public float maxInitialAngle = .67f; // Maximum angle in degrees for the initial direction
    public float movementSpeed = 1f; // Speed of the ball's movement

    public AudioSource audioSource; 
    public AudioClip BrickSound;
    public AudioClip BallSound;
    public AudioClip LoseSound;
    private void Start()
{

    originalScale = transform.localScale;

    float x = Random.Range(0.3f, 0.7f);

    if (Random.value < 0.5f)
    {
        x = -x;
    }

    Vector2 dir = new Vector2(x, 1).normalized;

    rb.linearVelocity = dir * movementSpeed;
}

   private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Tiles"))
    {
        Debug.Log("Ball hit a tile!");

        float chance = Random.value;

        // 10% chance: tile does not break
        if (chance < 0.10f)
        {
            Debug.Log("Tile survived!");
            return;
        }

        // 5% chance: double ball speed
        if (chance < 0.15f)
        {
            rb.linearVelocity *= 2f;
            Debug.Log("Ball speed doubled!");
        }

        // 5% chance: double ball size
        if (chance < 0.20f)
        {
            transform.localScale *= 2f;
            Debug.Log("Ball size doubled!");
        }

        audioSource.PlayOneShot(BrickSound);

        Destroy(collision.gameObject);

        gameManager.AddScore(1);
    
    }
    if (collision.gameObject.CompareTag("Paddle") || collision.gameObject.CompareTag("Walls"))
    {
        audioSource.PlayOneShot(BallSound);
    }
    MaintainSpeed();
}



    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("LoseArea"))
    {
        audioSource.PlayOneShot(LoseSound);
        Debug.Log("Ball entered the lose area. Game Over!");
        gameManager.LoseGame();
    }
}


public void ResetBall()
{
    transform.position = Vector3.zero;
    transform.localScale = originalScale;
    

    float x = Random.Range(0.3f, 0.7f);

    if (Random.value < 0.5f)
    {
        x = -x;
    }

    Vector2 dir = new Vector2(x, 1).normalized;

    rb.linearVelocity = dir * movementSpeed;
}

private void MaintainSpeed()
{
    float minimumSpeed = movementSpeed * 0.5f;

    if (rb.linearVelocity.magnitude < minimumSpeed)
    {
        rb.linearVelocity = rb.linearVelocity.normalized * minimumSpeed;
    }
}
}