using UnityEngine;
using System.Collections;

public class AsteroidCol : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public GameObject lava;
    public int scoreValue;
    public bool divisible;
    public GameObject smaller;
    //private Done_GameController gameController;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }


        

        if (explosion != null)
        {

            Instantiate(explosion, transform.position, transform.rotation);


        }

        if (other.tag == "Player")
        {

            //Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            other.SendMessage("Die");
            GameMaster.GameOver();
            /*gameController.death();
            Destroy(gameObject);
            if (gameController.gameOver)
            {
                Destroy(other.gameObject);
                
            }*/
            Destroy(gameObject);    
            return;
        }

        //gameController.AddScore(scoreValue);
        //Destroy(other.gameObject);
        print("pop");
        Destroy(gameObject);
        Instantiate(lava, transform.position, Quaternion.identity);
    }
}