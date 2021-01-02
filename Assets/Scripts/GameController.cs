using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text count;
    float scale=0.0f;
    public GameObject car;
    public GameObject otherCar;
	void Start ()
    {
        car.GetComponent<Rigidbody>().isKinematic =true;
        otherCar.GetComponent<Rigidbody>().isKinematic = true;
    }
	
	
	void Update ()
    {
        
        scale += Time.deltaTime;
        //Debug.Log(scale);

            if (scale>0f)
            {
                count.GetComponent<Text>().text = "3";
            }
            if (scale >1f)
            {
                count.GetComponent<Text>().text = "2";
            }
            if (scale >2f)
            {
                count.GetComponent<Text>().text = "1";
            }
            if (scale > 3f)
            {
                count.GetComponent<Text>().text = "GO!";
                car.GetComponent<Rigidbody>().isKinematic=false;
                otherCar.GetComponent<Rigidbody>().isKinematic = false;
            }

             if (scale > 4f)
            {
                
                count.GetComponent<Text>().text = "";
            }


    }
    
}