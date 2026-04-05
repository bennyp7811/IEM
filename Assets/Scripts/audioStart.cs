using UnityEngine;
using System.Collections;
using static UnityEngine.Rendering.DebugUI;

public class audioStart : MonoBehaviour
{
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip clip3;
    [SerializeField] AudioClip clip4;
    [SerializeField] AudioClip clip5;

    private AudioSource audioSource;

    public Transform boxtransform;
    public Vector3 boxStart;
    public Transform playertransform;
    public bool hasMoved = false;
    public Vector3 start;

    void Start()
    {
        boxStart = boxtransform.position;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playertransform = player.transform;
        start = playertransform.position;

        audioSource = GetComponent<AudioSource>();
        StartCoroutine(gameStart());
    }

    IEnumerator gameStart()
    {
        yield return new WaitForSeconds(2);
        audioSource.clip = clip1;
        audioSource.Play();
        StartCoroutine(playerStart());
       
    }

    IEnumerator checkMovement()
    {
        yield return new WaitForSeconds(40);

        if (!hasMoved && playertransform.position != start)
        {
            hasMoved = true;
            audioSource.clip = clip3;
            audioSource.Play();
            StartCoroutine(checkBox());



        }
        else
        {
            playerStartShort();

        }
    }
    IEnumerator checkBox()
    {
        yield return new WaitForSeconds(25);

        if ( boxtransform.position != boxStart)
        {
           
            audioSource.clip = clip4;
            audioSource.Play();
            StartCoroutine(FinalMessage());



        }
        else
        {
            checkBoxquick();

        }
    }

    IEnumerator FinalMessage()
    {
        yield return new WaitForSeconds(35);
        audioSource.clip = clip5;
        audioSource.Play();

    }

        public void checkBoxquick()
    {
        audioSource.clip = clip3;
        audioSource.Play();
        StartCoroutine(checkBox());


    }
    public void playerStartShort()
    {
        audioSource.clip = clip2;
        audioSource.Play();
        StartCoroutine(checkMovement());

    }

    IEnumerator playerStart()
    {
        yield return new WaitForSeconds(12);
        audioSource.clip = clip2;
        audioSource.Play();
        StartCoroutine(checkMovement());


    }
    // Update is called once per frame
    void Update()
    {


    }
}
