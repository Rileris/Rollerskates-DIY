using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSkies : MonoBehaviour
{
public GameObject Skies;
public Transform Location;

    void Update()
    {
        Skies.transform.position = Location.transform.localPosition;
        Skies.transform.rotation = Location.transform.localRotation;
    }
}
