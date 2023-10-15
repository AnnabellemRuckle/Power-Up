using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/SpeedPowerUp")]
public class SpeedPowerUp : PowerUp
{
    public float speedBoost = 2.0f;

    public override void Apply(GameObject target)
    {
        PlayerMovement playerMovement = target.GetComponent<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.ApplySpeedBoost(speedBoost);
        }
    }
}