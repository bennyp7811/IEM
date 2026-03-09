using UnityEngine;

public class platform : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
