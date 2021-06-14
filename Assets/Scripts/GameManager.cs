using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera cam;
    public GameObject npc;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Ground"))
            {               
                Instantiate(npc, hit.point, transform.rotation);               
            }
        }
    }
}
