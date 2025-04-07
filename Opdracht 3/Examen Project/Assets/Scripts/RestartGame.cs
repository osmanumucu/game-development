using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public PlayerMovement player; // PlayerController scriptine erişim

    void Update()
    {
        if (player.isDead && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Restart triggered!");
            // Sahneyi yeniden yükle
            SceneManager.LoadScene("JetgoldGame");
        }
    }
}
