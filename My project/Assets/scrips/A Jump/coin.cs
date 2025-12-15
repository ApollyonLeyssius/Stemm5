using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerMovement player = collision.GetComponent<playerMovement>();
            player.coins += 1;
            Destroy(gameObject);
        }
    }
}
