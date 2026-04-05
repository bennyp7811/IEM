using UnityEngine;
using System.Collections;
public class moveDoors : MonoBehaviour
{

    public AudioClip doorMovement;

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
        AudioSource.PlayClipAtPoint(doorMovement,startPOS, 0.8f);
        
    }
    public void moveLeft()
    {
        keyInsert = true;
        targetPOS += Vector3.forward  * moveDistace;
        AudioSource.PlayClipAtPoint(doorMovement, startPOS, 0.8f);
        StartCoroutine(waitToClose());
    }


    IEnumerator waitToClose()
    {
        yield return new WaitForSeconds(3);
        goBack();

    }

    public void goBack()
    {
        keyInsert = false;
        AudioSource.PlayClipAtPoint(doorMovement, startPOS, 0.8f);
        targetPOS = startPOS;

    }
}
