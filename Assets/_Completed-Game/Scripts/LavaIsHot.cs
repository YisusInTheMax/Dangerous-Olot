using UnityEngine;
using System.Collections;

public class LavaIsHot : MonoBehaviour
{
    //private Done_GameController gameController;

    void Start()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("Die");
            GameMaster.GameOver();
            return;
        }
    }
}