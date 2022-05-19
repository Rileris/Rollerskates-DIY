using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour
{
    public bool isPressed;
    public GameObject PRESS;
    public GameObject IDLE;

    private void Update()
    { 

            PRESS.gameObject.transform.position = Input.mousePosition;

            IDLE.gameObject.transform.position = Input.mousePosition;
            
            
            if (Input.GetMouseButtonDown(0))
            {
                IDLE.SetActive(false);
                PRESS.SetActive(true);
            }

             if (Input.GetMouseButtonUp(0))
            {
                IDLE.SetActive(true);
                PRESS.SetActive(false);
            }

    }


}
