using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    // Texts
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI startText;
    public TextMeshProUGUI bestEducationText;
    public Image logo;

    // Sound Effects
    public AudioClip coinSound;
    public AudioClip heartSound;
    public AudioClip crushSound;
    public AudioClip deathSound;


    private float upAndDOwnSpeed = 10.0f;

    private bool gameStarted = false;
    public bool isDead = false;

    // Score and Lives at the start of the game
    public int score = 0;
    public int lives = 1;


    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Time.timeScale = 0f;
        gameStarted = false;
        audioSource = GetComponent<AudioSource>();
    }

    void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space)) {
            Time.timeScale = 1f;
            gameStarted = true;
            startText.text = "";
            bestEducationText.text = "";
            logo.enabled = false;
        } 
        
        if (isDead && Input.GetKeyDown(KeyCode.Space)) {
            Time.timeScale = 1f;
            gameStarted = true;
            startText.text = "";
        }

        if (score == 25)
        {
            gameOverText.text = "YOU WON!";
            Time.timeScale = 0;
        }

        if (!gameStarted || isDead) {
            return;
        }

        // Plane movement up and down
        
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.up * upAndDOwnSpeed * verticalInput);

        // Player dies if the plane flies too high or too low

        float maxHeight = 8.0f;
        float minHeight = -7.0f;

        if (transform.position.y > maxHeight)
        {
            lives = 0;
            Die("High");
            Debug.Log("Player tried to fly too high!");
        } else if (transform.position.y < minHeight) 
        {
            lives = 0;
            Die("Low");
            Debug.Log("Player tried to fly too low!");
        }

    }

    // Death Function
    private void Die(string cause)
    {
        isDead = true;
        gameStarted = false;
        playSound(deathSound);
        Destroy(gameObject, 3f);

        // Different cases how the plauer might die
        switch (cause)
        {
            case "High":
                gameOverText.text = "Player tried to fly too high!";
                break;
            case "Low":
                gameOverText.text = "Player tried to fly too low!";
                break;
            case "Skull":
                gameOverText.text = "Player crushed to a skull and is dead!";
                break;
            case "Rock":
                gameOverText.text = "Player got crushed by a rock!";
                break;
            default:
                gameOverText.text = "Game Over!";
                break;
        }   
            gameOverText.text += "\nPress SPACE to restart!";

    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    // Colliding Functies
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Gold")) // What happens if the player hits the gold
        {
            Destroy(other.gameObject);
            score ++;
            Debug.Log("Score: " + score);
            scoreText.text = "Score: " + score;
            playSound(coinSound);
        } else if (other.gameObject.CompareTag("Skull")) // What happens if the player hits the skull
        {
            lives = 0;
            Die("Skull");
            Debug.Log("Player crushed to a skull and is dead!");
        } else if (other.gameObject.CompareTag("Rock")) // What happens if the player hits the rock
        {
            Destroy(other.gameObject);
            lives--;
            playSound(crushSound);

            // If else statement for dying in case you have 1 life left
            if (lives <= 0)
            {
                Die("Rock");
                Debug.Log("Player is dead!");
            } else
            {
            livesText.text = "Lives: " + lives;
            }
        } else if (other.gameObject.CompareTag("Heal")) // What happens if the player hits heal
        {
            Destroy(other.gameObject);
            lives++;
            Debug.Log("Lives: " + lives);
            livesText.text = "Lives: " + lives;
            playSound(heartSound);
        }
    }
}
