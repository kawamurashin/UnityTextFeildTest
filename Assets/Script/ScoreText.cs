using UnityEngine;
using System.Collections;
using UnityEngine.UI;  ////ここを追加////
public class ScoreText : MonoBehaviour {
    public int score = 0;
    // Use this for initialization
    void Start()
    {
       // this.GetComponent<Text>().text = "Score :0";
    }
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "Score :" + score.ToString();
    }
}
