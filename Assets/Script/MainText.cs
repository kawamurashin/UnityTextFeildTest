using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainText : MonoBehaviour {
    uint count;
    Text textField;
    // Use this for initialization
    void Start () {
        count = 0;
        textField = this.GetComponent<Text>();
        textField.text = "scusess!!";
    }
	
	// Update is called once per frame
	void Update () {
        count++;
        textField.text = "scusess!! " + count.ToString();
    }
}
