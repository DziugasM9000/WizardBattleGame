using UnityEngine;

public class GoodWizard : Wizard
{
    private int currentMana;
    private int maxMana;

    private void Start()
    {
        currentHealth = Constants.GoodWizardMaxHealth;
        currentMana = Constants.GoodWizardMaxMana;
        maxMana = Constants.GoodWizardMaxMana;
    }

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (currentMana > Constants.FireballManaCost)
            {
                SpellFactory.instance.SpawnFireball(this.gameObject.transform.position);
                currentMana -= Constants.FireballManaCost;
            }

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentMana++;
        }
    }

    private void OnDestroy()
    {
        SceneSwitcher.instance.Win();
    }
}
