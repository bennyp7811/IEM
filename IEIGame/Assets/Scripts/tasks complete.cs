using UnityEngine;
using TMPro;
public class taskscomplete : MonoBehaviour
{

    public TMP_Text tasksText;
    public static int tasks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tasks = 0;
        tasksText.text = (tasks + "/3 tasks complete");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (tasks >= 1)
        {

            tasksText.text = (tasks + "/3 tasks complete");

        }

    }

}
