using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public float health= 100;
    private float accumHealth = 0;
    public void TakeDamage(int damage)
    {
        accumHealth += damage;
        if (accumHealth >= 0)
        {
            Destroy(gameObject);
        }
    }
}
