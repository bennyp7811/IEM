using UnityEngine;
using TMPro;
public class taskscomplete : MonoBehaviour
{

    public GameObject controls;

    public TMP_Text tasksText;
    public static int tasks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controls.SetActive(false);
        tasks = 0;
        tasksText.text = (tasks + "/4 tasks complete");
        
    }
    void OnTriggerEnter(Collider other)
    {
       tasks++;
    }

    public void tasksDone()
    {
               tasks++;
    }
    // Update is called once per frame
    void Update()
    {
        

        if (tasks >= 1)
        {

            tasksText.text = (tasks + "/4 tasks complete");

        }
        if (tasks >= 4)
        {
            controls.SetActive(true);

        }

    }

}
