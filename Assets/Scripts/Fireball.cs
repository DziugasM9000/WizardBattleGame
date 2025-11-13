using UnityEngine;

public class Fireball : MonoBehaviour
{
    private Rigidbody2D body;
    private int damage = 1;
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        body.velocityX = 25;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        doDamage(collision.gameObject);
        Destroy(this.gameObject);
    }
    void doDamage(GameObject target)
    {
        Wizard wiz = target.GetComponent<Wizard>();
        if(wiz!=null)
            target.GetComponent<Wizard>().loseHealth(damage);
    }
}
