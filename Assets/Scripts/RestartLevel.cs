using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartLevel : MonoBehaviour
{

    public void RestartLevelButton()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                StartCoroutine(RespawnTimer2());
            }
    }


    IEnumerator RespawnTimer2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    }

}
