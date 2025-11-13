using UnityEngine;

public static class Constants
{

    //OUR WIZARD
    public const int GoodWizardMaxHealth = 5;
    public const int GoodWizardMinHealth = 1;
    public const int GoodWizardMaxMana = 100;
    public const float GoodWizardRechargeRate = 10;

    // OUR  SPELLS
    public const int FireballDamage = 10;
    public const int FireballVelocity = 25;
    public const int FireballManaCost = 10;
    public const int FireballHorizontalOffset = 1;
    public const string FireballPrefabLocation = "Prefabs/Fireball";

    // ENEMY WIZARD
    public const int EnemyMaxHealth = 300;
    public const int EnemyMinHealth = 1;
    public const int EnemySpellDamage = 1;
    public const int EnemyManaCost = 10;
    public const int EnemyMaxMana = 10;

    // ENEMY WIZARD SPELLS
    public static readonly Vector3 InitialSpikePosition = new Vector3(-7f, 0f, 0f);
    public const int SpikeHorizontalInterval = 4;
    public const int PossibleSpikeLocations = 3;
    public const float SpikeLifespan = 3f;
    public const float SpikeCooldown = 2f;
    public const string SpikePrefabLocation = "Prefabs/Spike";

    public const string SpikeWarningPrefabLocation = "Prefabs/SpikeWarning";
    public const int SpikeWarningHeight = -5;
    public const float SpikeWarningLifespan = 1f;
    // 
}
