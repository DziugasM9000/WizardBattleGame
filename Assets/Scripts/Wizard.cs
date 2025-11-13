using UnityEngine;

public class Wizard : MonoBehaviour
{
    protected int maxHealth;
    protected int currentHealth;
    
    public void loseHealth(int damage)
    {
        this.currentHealth -= damage;
    }

    public void spawnFireball()
    {

    }
}
