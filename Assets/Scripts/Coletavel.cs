using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.GetComponent<PlayerMovement>() != null)
        {
            GameManager gameManager = FindAnyObjectByType<GameManager>();

            gameManager.ColetarBolinhas();

            Destroy(gameObject);
        }
    }
}