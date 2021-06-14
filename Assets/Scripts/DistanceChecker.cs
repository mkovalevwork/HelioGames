using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    private dataNpcV dataNpc;
    private GameObject npcTracker;
    
    void Start()
    {
        dataNpc = GetComponent<dataNpcV>();
        npcTracker = GameObject.Find("NpcTracker");
    }



    /*private void OnTriggerEnter(Collider other)
    {
        npcTracker.GetComponent<NpcTracker>().onCollisionNpc[npcTracker.GetComponent<NpcTracker>().onCollisionNpc.Length] = gameObject;
        Debug.Log("trigger");
       
    }*/
    /*private void OnTriggerEnter(Collider other)
    {
        
        int luck_sum = dataNpc.pLuck + other.GetComponent<dataNpcV>().pLuck;
        int luck_random = Random.Range(0, luck_sum);
        if (luck_random >= dataNpc.pLuck)
        {

            Destroy(gameObject);

        }
        else
        {
            Destroy(other.gameObject);
        }
    }*/


}
