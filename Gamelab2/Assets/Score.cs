using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;
    private Text text;
    public static Score thisScript;

    void Start() {
        thisScript = this;
        text = GetComponent<Text>();
        text.text = "Score: 0";
    }

    public void AddScore(int addScore) {
        score += addScore;
        text.text = "Score: " + score.ToString();
    }
}
