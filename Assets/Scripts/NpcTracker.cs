using UnityEngine;

public class NpcTracker : MonoBehaviour
{
    public GameObject[] allNpc;
    
    private float distanceFromLoop;
    public float radius;
    private int yToDestroy,iToDestroy;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        allNpc = GameObject.FindGameObjectsWithTag("NPC");
        testForLoop();
    }

    

    void testForLoop()
    {
        for (int y = 0; y < allNpc.Length; y++)
        {
            for (int i = 0; i < allNpc.Length; i++)
            {
                float distance = Vector3.Distance(allNpc[i].transform.position, allNpc[y].transform.position);
                
                distanceFromLoop = distance;
                if (distance < radius && distance != 0)
                {
                    iToDestroy = i;
                    Debug.Log(distance);
                    break;
                }
                
            }

            if (distanceFromLoop < radius && distanceFromLoop != 0)
            {
                yToDestroy = y;
                Calculated();
                break;
            }
        }
    }

    void Calculated()
    {
        int luckY = allNpc[yToDestroy].GetComponent<dataNpcV>().pLuck;
        int luckI = allNpc[iToDestroy].GetComponent<dataNpcV>().pLuck;

        int luckSum = luckI + luckY;

        if (Random.Range(0,luckSum) >= luckY)
        {
            Destroy(allNpc[yToDestroy].gameObject);
        }
        else
        {
            Destroy(allNpc[iToDestroy].gameObject);
        }      
        Debug.Log("Calculated");

    }
}
