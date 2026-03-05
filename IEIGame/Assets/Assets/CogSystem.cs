using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

public class CogSystem : MonoBehaviour
{
    public CogManager manager;
    public bool HasPower = true;
    public bool Source = true;
    public bool odd = false;
    public float rotationSpeed = 100f;

    private void Start()
    {
         if (odd)
        {
            rotationSpeed = rotationSpeed * -1;
        }
            
    }
    void OnTriggerStay(Collider other)
    {
        CogSystem adjacent = other.GetComponentInParent<CogSystem>();


        if (adjacent != null && adjacent.HasPower)
        {
            HasPower = true;
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        HasPower = false;

    }
    void Update()
    {
        if (manager != null && manager.finnished)
        {
            
            transform.parent.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            HasPower = true;
        }

        GetComponentInParent<Renderer>().materials[1].color = HasPower ? new Color(0f, 1f, 0.68344f) : new Color(0f, 0.3459118f, 0.236034f);

        if (Source == true)
        {
            HasPower = true;
        }
    }
}
