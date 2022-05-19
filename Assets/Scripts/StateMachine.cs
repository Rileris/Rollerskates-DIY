using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PaintIn3D;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    //State machine enums
    public enum Stage
    {
        WaitingToStart,
        Cleaning,
        Painting,
        PlacingStickers,
    }

    //private references
    private Stage _stage;

    //serialized references
    [SerializeField] private Image _percentageCalc;
    [SerializeField] private P3dChangeCounterFill _counterFill;
    [SerializeField] private GameObject continueButton;


    //booleans
    private bool isDoneCleaning;

    private void Start()
    {
        StartCoroutine(EnableAfterDelay());
        StartNextStage();
    }


    private void Update()
    {
        if (!isDoneCleaning && _percentageCalc.fillAmount > 0.40f)
        {
            isDoneCleaning = true;
            StartNextStage();
        }
    }


    private void StartNextStage()
    {
        switch (_stage)
        {
            default:
            case Stage.WaitingToStart:
                _stage = Stage.Cleaning;
                break;
            case Stage.Cleaning:
                _stage = Stage.Painting;
                continueButton.SetActive(true);
                break;
            case Stage.Painting:
                _stage = Stage.PlacingStickers;
                break;
        }

        Debug.Log("Starting next stage: " + _stage);
    }

    private IEnumerator EnableAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);
        _counterFill.enabled = true;
    }
}
