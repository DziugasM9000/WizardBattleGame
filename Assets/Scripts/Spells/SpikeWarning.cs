using UnityEngine;
using System.Collections;

public class SpikeWarning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LifespanCoroutine(1f));
    }

    IEnumerator LifespanCoroutine(float lifespan)
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }
}
