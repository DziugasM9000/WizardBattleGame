using UnityEngine;
using System.Collections;

public class Spike : PhysicalSpell
{
    private void Start()
    {
        StartCoroutine(LifespanCoroutine(3f));  // Object lifespan of 5 seconds
    }
    private void OnTriggerEnter2D(Collider2D collision) // pakeist i ontriggerstay
    {
        Damage(collision.gameObject,Constants.EnemySpellDamage);
    }

    private IEnumerator LifespanCoroutine(float duration)
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject); 
    }
}
