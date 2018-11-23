using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int scorevalue = 0;
    public Text scoring;


	void Start () {
        scoring = GetComponent<Text>();
	}
	
	void Update () {
        scoring.text = "Score: " + scorevalue;
        if (RotacionaPedra.scorepedra == 1)
        {
            scorevalue += 100;
            RotacionaPedra.scorepedra = 0;
        }
        if (RotacionaPedra2.scorepedra2 == 1)
        {
            scorevalue += 300;
            scorevalue += (10 * (int)Timecounter.timeLeft);
            Timecounter.timeLeft = 0f;
            RotacionaPedra2.scorepedra2 = 0;
        }
        if (Trap1.lives == 1 ||Trap1.lives == 0)
        {
            scorevalue = 0;
        }
    }
}
