using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLoseState2 : MonoBehaviour {
    public Text winlosetext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene("Race2");
        }
        if (Input.GetKeyDown(KeyCode.T)){
            SceneManager.LoadScene("Intro");
        }
	}

    void OnTriggerEnter(Collider other)
    {
      
        if (this.gameObject.name == "CarWaypointBased" && other.tag=="WLC")
        {
            Debug.Log("Lose");
            Destroy(other.gameObject);
            PlayerPrefs.SetString("r2wl","LOSE");
            winlosetext.GetComponent<Text>().text=" YOU LOSE ";
            winlosetext.GetComponent<Text>().color=Color.red;
        }
        if (this.gameObject.name=="Car2" && other.tag=="WLC")
        {
            Debug.Log("Win");
            Destroy(other.gameObject);
            PlayerPrefs.SetString("r2wl","WIN");
            winlosetext.GetComponent<Text>().text=" YOU WIN ";
            winlosetext.GetComponent<Text>().color=Color.green;
        }
    }

}
