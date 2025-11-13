using UnityEngine;
using System.Collections;
public class BadWizard : Wizard
{
    int cooldown = 10;
    private void Start()
    {
        maxHealth = Constants.EnemyMaxHealth;
        currentHealth = maxHealth;
        minHealth = Constants.EnemyMinHealth;
        StartCoroutine(CastSpikes());  // Object lifespan of 5 seconds

    }

    private IEnumerator CastSpikes()
    {
        while(true)
        {
            int spikeNumber = Random.Range(0, Constants.PossibleSpikeLocations);
            Vector3 spikeLocation = Constants.InitialSpikePosition;
            spikeLocation.x += spikeNumber * Constants.SpikeHorizontalInterval;
            spikeLocation.y = Constants.SpikeWarningHeight;
            SpellFactory.instance.SpawnSpikeWarning(spikeLocation);
            yield return new WaitForSeconds(1f);
            spikeLocation.y = Constants.InitialSpikePosition.y;
            SpellFactory.instance.SpawnSpike(spikeLocation);
            yield return new WaitForSeconds(Constants.SpikeCooldown);
        }

    }

    private void OnDestroy()
    {
        SceneSwitcher.instance.Lose();
    }
}
