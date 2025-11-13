using UnityEngine;

public class Fireball : PhysicalSpell
{ 
    void Update()
    {
         body.velocityX = Constants.FireballVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Damage(collision.gameObject,Constants.FireballDamage);
        Destroy(this.gameObject);
    }

}
