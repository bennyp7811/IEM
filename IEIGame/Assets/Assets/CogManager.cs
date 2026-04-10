using UnityEngine;

public class CogManager : MonoBehaviour
{
    public CogSystem end;
    public bool finnished = false;
    GameObject Player;

    void Update()
    {
        if (end != null && end.HasPower)
        {
            

            finnished = true;
            
        }
        if (Player == null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
         if (finnished && Player != null)
        {
            Player.GetComponent<Player>().Heal(100);
            
        }
       


    }






}
