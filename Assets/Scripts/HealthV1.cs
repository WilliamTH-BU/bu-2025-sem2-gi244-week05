using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public float Health= 100;
    public void TakeDamage(int damage)
    {
        Health += damage;
        if (Health >= 0)
        {
            Destroy(gameObject);
        }
    }
}
