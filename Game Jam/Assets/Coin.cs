using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool isGold = false;

        private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        if (isGold)
        {
            FindObjectOfType<GameManager>().WinGame(); // Call the WinGame method.
        }
        else
        {
            Debug.Log("Silver Coin Collected!");
        }

        Destroy(gameObject); // Remove the coin after collection.
    }
}


}
