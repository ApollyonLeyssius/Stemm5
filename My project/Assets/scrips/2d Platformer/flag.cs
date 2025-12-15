using UnityEngine;
using UnityEngine.SceneManagement;

public class flag : MonoBehaviour
{
    public GameObject winui;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winui.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void restartlevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
