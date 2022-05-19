using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public float Distance;
    public ParticleSystem ParticlesSpraY;
    public AudioSource SoundEfefct;
     void Start () {
     
     }
 
     // Update is called once per frame
     void Update()
     {
         Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Distance));
         RaycastHit hit;
         if(Physics.Raycast(ray, out hit))
         {
             Vector3 newPos = hit.point;
             transform.position = newPos;
         }
         if (Input.GetMouseButtonDown(0))
         {
            ParticlesSpraY.Play();
            SoundEfefct.Play();
         }  


         if (Input.GetMouseButtonUp(0))
         {
            SoundEfefct.Pause();
            ParticlesSpraY.Stop();
         }   


     }
 }