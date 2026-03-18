using UnityEngine;
using System.Collections;
public class moveDoors : MonoBehaviour
{

    public float moveDistace = 5;
    public float speed = 5;

    public bool keyInsert;
    

    Vector3 startPOS;
    Vector3 targetPOS;

    void Start()
    {
        startPOS = transform.position;
        targetPOS = transform.position;
        keyInsert = false;
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPOS, speed * Time.deltaTime);
        
    }

    public void moveRight()
    {
        keyInsert = true;
        targetPOS += Vector3.back * moveDistace;
        StartCoroutine(waitToClose());
        
    }
    public void moveLeft()
    {
        keyInsert = true;
        targetPOS += Vector3.forward  * moveDistace;
        StartCoroutine(waitToClose());
    }


    IEnumerator waitToClose()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("done");
        goBack();

    }

    public void goBack()
    {
        keyInsert = false;

        targetPOS = startPOS;

    }
}
