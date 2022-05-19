using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour
{

    public GameObject OldScene;
    public GameObject NewScene;
    public Animator FadeAnimator;

public void FadeToScene()
    {
        StartCoroutine(ExampleCoroutine());
        FadeAnimator.Play("FadeIn");
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.60f);
        OldScene.SetActive(false);
        NewScene.SetActive(true);
    }
}
