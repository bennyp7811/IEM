using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class OutsideSpace : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sideSpeed;

    [SerializeField] private XRLever lever;
    [SerializeField] private XRKnob knob;

    void Start()
    {
        
    }

    void Update()
    {

        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0);
        float sideVelocity = sideSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1,1, knob.value);

        Vector3 velocity = new Vector3(sideVelocity,0,forwardVelocity);  

        transform.position += velocity * Time.deltaTime;
        
    }
}
