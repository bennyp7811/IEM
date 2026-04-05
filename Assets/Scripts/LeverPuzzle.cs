using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Content.Interaction;

public class LeverPuzzle : MonoBehaviour
{
    public GameObject lever1;
    public GameObject lever2;
    public GameObject lever3;
    public GameObject lever4;
    public GameObject lever5;
    public GameObject lever6;
    public GameObject tasks;


    public bool win;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tasks.GetComponent<taskscomplete>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       if (lever6.GetComponent<XRLever>().value == false)
       {
            lever1.GetComponent<XRLever>().value = false;
            lever5.GetComponent<XRLever>().value = false;
       }

        if (lever6.GetComponent<XRLever>().value == true)
        {
            lever1.GetComponent<XRLever>().value = true;
            lever5.GetComponent<XRLever>().value = true;
        }

        if (lever3.GetComponent<XRLever>().value == true)
        {

            lever2.GetComponent<XRLever>().value = true;
            lever4.GetComponent<XRLever>().value = true;
       }

        if (lever3.GetComponent<XRLever>().value == false)
        {

            lever2.GetComponent<XRLever>().value = false;
            lever4.GetComponent<XRLever>().value = false;
        }

        if (lever1.GetComponent<XRLever>().value == true && lever2.GetComponent<XRLever>().value == true && lever3.GetComponent<XRLever>().value == true && lever4.GetComponent<XRLever>().value == true && lever5.GetComponent<XRLever>().value == true && lever6.GetComponent<XRLever>().value == true)
        {
            if (win == false)
            {
                taskscomplete.tasks++;
            }
            win = true;
           
        }
       


    }
}
