using UnityEngine;

public class doormesage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject canopen;
    public moveDoors moveDoors;
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (moveDoors.keyInsert == true)
            {
                canopen.SetActive(false);

            }
            else
            {
                canopen.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

        canopen.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
