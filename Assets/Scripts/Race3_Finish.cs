using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Race3_Finish : MonoBehaviour {
    public float timeStart;
    public float timeStop;
    public float timePassed;
	// Use this for initialization
	void Start () {
        timeStart=Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Finish_Sign")
        {
            timeStop=Time.time;
            timePassed=timeStop-timeStart;
            Debug.Log(timePassed);
            PlayerPrefs.SetFloat("r3time",timePassed);

            //yield return new WaitForSeconds(3);
            //System.Threading.Thread.Sleep(3000);
            Invoke("Wait",3);
        }
    }
    void Wait()
    {
        SceneManager.LoadScene("Outro");

    }
}
