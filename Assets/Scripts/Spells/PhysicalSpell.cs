using UnityEngine;

public class PhysicalSpell : MonoBehaviour
{
    protected Rigidbody2D body;
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    protected void Damage(GameObject target, int damage)
    {
        Wizard wiz = target.GetComponent<Wizard>();
        if (wiz != null)
            target.GetComponent<Wizard>().changeHealth(damage);
    }
}
