using UnityEngine;

public class SpellFactory : MonoBehaviour
{
    static public SpellFactory instance;

    public void Awake()
    {
        instance = this;
    }

    public void SpawnFireball(Vector3 wizardLocation)
    {
        GameObject spell = Resources.Load<GameObject>(Constants.FireballPrefabLocation);
        Instantiate(spell,new Vector3(wizardLocation.x + Constants.FireballHorizontalOffset, wizardLocation.y, wizardLocation.z), Quaternion.identity);
    }

    public void SpawnSpike(Vector3 spikeLocation)
    {
        GameObject spell = Resources.Load<GameObject>(Constants.SpikePrefabLocation);
        Instantiate(spell, spikeLocation,  Quaternion.identity);
    }

    public void SpawnSpikeWarning(Vector3 spikeLocation)
    {
        GameObject spell = Resources.Load<GameObject>(Constants.SpikeWarningPrefabLocation);
        Instantiate(spell, spikeLocation, Quaternion.identity);
    }
}
