using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {


    float size = 20f;
    int seconds = 1;
    public GameObject asteroid;
    public Text score;
    public Text restart;
    static bool gameOver;


	// Use this for initialization
	void Start () {
        InvokeRepeating("Eruption", 2.0f, 0.25f);
        score.text = "";
        restart.text = "";
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown("r"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }

            return;
        }
    }


    public static void GameOver()
    {
        gameOver = true;
    }

    void Eruption()
    {
        
            seconds++;
            Vector3 spawn = new Vector3(Random.Range(-size, size), Random.Range(10, 50), Random.Range(-size, size));
            Instantiate(asteroid, spawn, Quaternion.identity);
            if (gameOver)
            {
                score.text = "You survived " + seconds / 4 + " seconds.";
                restart.text = "Olot is a Dangerous place.Press R to restart";
                CancelInvoke();
            }
        
        
    }
    
}
