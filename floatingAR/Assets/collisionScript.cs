using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour
{
    public AudioSource blast;
    public Text winText;
    public Button restartButton;
    public Button quitButton;
    public Text scoreText; public static float score = 0;

    void Start()
    {
     blast = GetComponent<AudioSource>();

    }

    void Update()
    {
        score = 4 - GameObject.FindGameObjectsWithTag("Player").Length;
        scoreText.text = score.ToString();
        if (score == 4)
        {
            winText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
            cntDown.currentTime = 0;
        }
        
    }

    

    void OnTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
       
        blast.Play();
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explosion, 2);

       /* score+=1;
        scoreText.text = score.ToString();
        


        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            winText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
          
        }

        if (score == 4)
        {
            winText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }*/

        Destroy(gameObject);


    }

}