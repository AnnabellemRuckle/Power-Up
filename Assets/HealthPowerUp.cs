using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/HealthPowerUp")]
public class HealthPowerUp : PowerUp
{
    public int healthIncrease = 25;

    public override void Apply(GameObject target)
    {
        PlayerHealth playerHealth = target.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.Heal(healthIncrease);
        }
    }
}