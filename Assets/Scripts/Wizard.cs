using UnityEngine;

public class Wizard : MonoBehaviour
{
    protected int currentHealth;
    protected int maxHealth;
    protected int minHealth;

    public void changeHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < minHealth)
            Destroy(this.gameObject);
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

}
