using UnityEngine;

public class SpellFactory : MonoBehaviour
{
    const string fireballResourceLocation = "Prefabs/fireball";

    int fireballOffset=3;
    public void SpawnFireball(Vector3 casterLocation)
    {
        GameObject spell = Resources.Load<GameObject>(fireballResourceLocation);
        Instantiate(spell,new Vector3(casterLocation.x + fireballOffset, casterLocation.y, casterLocation.z), Quaternion.identity);
    }
}
