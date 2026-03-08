using UnityEngine;

public class CogManager : MonoBehaviour
{
    public CogSystem end;
    public bool finnished = false;
    void Update()
    {
        if (end != null && end.HasPower)
        {
            finnished = true;
            
        }
      /* else 
        { 
            finnished = false;
        }
      */         
    }
}
