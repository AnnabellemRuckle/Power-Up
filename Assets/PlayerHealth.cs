using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int initialHealth = 100;
    private int currentHealth;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        currentHealth = initialHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, initialHealth);
        UpdateHealthUI();
    }

    public void Heal(int healAmount)
    {
        currentHealth -= healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, initialHealth);
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "HEALTH: " + currentHealth.ToString();
        }
    }
}

