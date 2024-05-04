using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JumpsIncrease : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI moreText;
    public int timesJumped;
    public bool moreThan10Times;

    private void Start()
    {
        timesJumped = 0;
        if (PlayerPrefs.GetInt("scoreInt") != 0)
        {
            timesJumped = PlayerPrefs.GetInt("scoreInt");
        }

        scoreText.text = "Times jumped: " + timesJumped;
        moreText.text = "Has jumped more than 10 times? No";

        moreThan10Times = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timesJumped++;
            scoreText.text = "Times jumped: " + timesJumped;
            PlayerPrefs.SetInt("scoreInt", timesJumped);
        }

        if (timesJumped <= 10) {
            moreThan10Times = false;
        } else if (timesJumped > 10)
        {
            moreThan10Times = true;
        }
        else
        {
            moreThan10Times = false;
        }

        if (moreThan10Times = true)
        {
            moreText.text = "Has jumped more than 10 times? Yes";
        }

    }
}
