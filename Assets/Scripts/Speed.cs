using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour {
    public Text speedText;
    public GameObject car2;
    private Rigidbody m_Rigidbody;
	// Use this for initialization
	void Start () {
    m_Rigidbody = car2.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		float speed = m_Rigidbody.velocity.magnitude;
        speed *= 2.23f;
        speedText.GetComponent<Text>().text = speed.ToString();
	}
}
