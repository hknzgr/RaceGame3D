using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RTWL_Controller : MonoBehaviour {
    public Text r1Text;
    public Text r2Text;
    public Text r3Text;

    public Text r1time;
    public Text r2time;
    public Text r3time;    
    
    public Text r1wl;
    public Text r2wl;
    public Text r3wl;

	// Use this for initialization
	void Start () {
		RTWLSituation();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void RTWLSituation()
    {
        r1Text.GetComponent<Text>().text="Forest";
        r2Text.GetComponent<Text>().text="Desert";
        r3Text.GetComponent<Text>().text="Mountain";

        r1time.GetComponent<Text>().text="" + PlayerPrefs.GetFloat("r1time",0);
        r2time.GetComponent<Text>().text="" + PlayerPrefs.GetFloat("r2time",0);
        r3time.GetComponent<Text>().text="" + PlayerPrefs.GetFloat("r3time",0);

        r1wl.GetComponent<Text>().text="" + PlayerPrefs.GetString("r1wl","");
        r2wl.GetComponent<Text>().text="" + PlayerPrefs.GetString("r2wl","");
        r3wl.GetComponent<Text>().text="" + PlayerPrefs.GetString("r3wl","");
        
    }
}
