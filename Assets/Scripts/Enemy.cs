using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}