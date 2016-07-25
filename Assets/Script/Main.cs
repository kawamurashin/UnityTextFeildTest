using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Main : MonoBehaviour {
    public GameObject canvasObject;
    public ScoreText scoreText;
    // Use this for initialization
    void Start() {
        //scoreText.text = "Score: 0"; //初期スコアを代入して画面に表示
        GameObject gameObject = (GameObject)Resources.Load("prefab/MainText");
        GameObject prefab = (GameObject)Instantiate(gameObject);
        GameObject canvas = GameObject.Find("Canvas");
        prefab.transform.SetParent(canvas.transform);
        prefab.transform.position = new Vector3(200, 0, 0);
    }

	// Update is called once per frame
	void Update () {
        scoreText.score++;

    }
}
