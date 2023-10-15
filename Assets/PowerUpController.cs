using UnityEngine;
public class PowerUpController : MonoBehaviour
{
    public PowerUp speedPowerUp; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            speedPowerUp.Apply(other.gameObject);
            gameObject.SetActive(false);
        }
    }
}
