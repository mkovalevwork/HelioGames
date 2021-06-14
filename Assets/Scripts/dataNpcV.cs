using UnityEngine;
using UnityEngine.AI;

public class dataNpcV : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float spawnRadius;
    [SerializeField] float whaitTime;
    [SerializeField] int luck;
    public int pLuck;
    

    private Vector3 movePoint;
    private NavMeshAgent agent;   
       
    public GameObject moveP;
      
    [SerializeField] private bool onWay;
    [SerializeField] private bool readyOnWay;
    [SerializeField] private bool readyOnSleep;

    void Start()
    {
        SaveHandler saveHandler = GameObject.Find("SaveHandler").GetComponent<SaveHandler>();
        speed = Random.Range(saveHandler.actminSpeed, saveHandler.actmaxSpeed);
        spawnRadius = saveHandler.actspawnRadius;
        whaitTime = Random.Range(saveHandler.actminWhaitTime, saveHandler.actmaxWhaitTime);
        luck = Random.Range(saveHandler.actminLuck, saveHandler.actmaxLuck);
        pLuck = luck;
               
        agent = GetComponent<NavMeshAgent>();
        
        Patroling();
    }


    void Update()
    {
        if (onWay)
        {
            float distance = Vector3.Distance(transform.position, movePoint);
            //Debug.Log(distance);
            if (distance < 0.05f)
            {
                onWay = false;
                //Debug.Log("randomplay");
                RandomPlay();
            }
        }

        if (readyOnWay)
        {
            readyOnWay = false;
            Patroling();
        }

        if (readyOnSleep)
        {
            readyOnSleep = false;
            //sleepParticle.Play();
            Invoke("RandomPlay", whaitTime);
        }
        
        
    }



    //works
    void Patroling()
    {
        onWay = true;
        RandomPosittion(spawnRadius);
        agent.speed = speed;
        agent.SetDestination(movePoint);
        

    }

    //works
    void RandomPosittion(float radius)
    {
        Vector3 centerOfRadius = transform.position;
        Vector3 insideCircle = radius * Random.insideUnitCircle;
        insideCircle = new Vector3(insideCircle.x, transform.position.y, insideCircle.y);
        movePoint = centerOfRadius + insideCircle;
        movePoint.y = 1f;
        

        if (movePoint.x > -12.5f && movePoint.x < 12.5f && movePoint.z > -12.5f && movePoint.z < 12.5f)
        {
            //used to visualise waypoints
            //Instantiate(moveP, movePoint, transform.rotation);
        }
        else
        {
            RandomPosittion(spawnRadius);
        }
    }

    void RandomPlay()
    {
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            readyOnSleep = true;
        }
        else if (random == 1)
        {
            readyOnWay = true;
        }
        //Debug.Log(random);
    }

}
