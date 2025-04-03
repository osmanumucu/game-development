using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    private float upAndDOwnSpeed = 10.0f;
    public int score = 0;
    public int lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // Plane movement up and down
        
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.up * upAndDOwnSpeed * verticalInput);

        // Player dies if the plane flies too high or too low

        float maxHeight = 8.0f;
        float minHeight = -6.0f;

        if (transform.position.y > maxHeight)
        {
            lives = 0;
            Die();
            Debug.Log("Player tried to fly too high!");
        } else if (transform.position.y < minHeight) 
        {
            lives = 0;
            Die();
            Debug.Log("Player tried to fly too low!");
        }



    }

    private void Die()
    {
        Destroy(gameObject);
        Time.timeScale = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Gold"))
        {
            Destroy(other.gameObject);
            score ++;
            Debug.Log("Score: " + score);
        } else if (other.gameObject.CompareTag("Skull"))
        {
            lives = 0;
            Die();
            Debug.Log("Player crushed to a skull and is dead!");
        } else if (other.gameObject.CompareTag("Rock"))
        {
            Destroy(other.gameObject);
            lives--;

            if (lives <= 0)
            {
                Die();
                Debug.Log("Player is dead!");
            } else
            {
                Debug.Log("Lives: " + lives);
            }
        }
    }
}
