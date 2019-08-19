using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool gameover = false;
    public Text gameOver;
    public Text scoreText;
    AudioSource tone;
    public int score = 0;
  
    void Start()
    {
        tone = GetComponent<AudioSource>();
    }

  
    void Update()
    {
      //  if(gameover==true&&Input.GetMouseButtonDown(0))
      //  {
     //       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     //   }
        
    }

    public void BirdDied()
    {
        gameOver.gameObject.SetActive(true);
        gameover = true;
        tone.Stop();
    }

    public void Score()
    {
        if (gameover)
            return;
        else
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
