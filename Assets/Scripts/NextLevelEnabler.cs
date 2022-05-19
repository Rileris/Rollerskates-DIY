using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelEnabler : MonoBehaviour
{
    public GameObject ButtonNext;
    public float timefloat;

void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(timefloat);
        ButtonNext.SetActive(true);
    }
}