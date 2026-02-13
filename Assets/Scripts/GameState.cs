using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
        }
        if (hitCount >= 10)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
    }
}
