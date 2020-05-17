using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cntDown : MonoBehaviour
{
    public static float currentTime = 0f, startTime = 30f;
    [SerializeField]
    Text countDownText;
    

    public Text lostText; 
    public Button restartButton;
    public Button quitButton;
  
    void Start()
    {
        currentTime = startTime;
    }

   
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime >= 0)
        {
            countDownText.text = currentTime.ToString("00");
        }
        else
        {
            countDownText.text = "00"; //currentTime.ToString("00");
        }

        countDownText.color = Color.green;

        if (currentTime <= 5)
        { countDownText.color = Color.red; countDownText.fontSize = 18; }

        if (currentTime <= 0 && collisionScript.score<4)
        {
            lostText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
            currentTime = 0;
            //Application.Quit(); currentTime = 0; 
        }
    }
}
