using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovements : MonoBehaviour {
    [SerializeField] float spd = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cameraMove();
        cameraZoom();
	}

    void cameraZoom()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += new Vector3(0, spd * Time.deltaTime * 10, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0, spd * Time.deltaTime * (-10), 0);
        }
    }

    void cameraMove()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(spd * Time.deltaTime * horizontal, 0, spd * Time.deltaTime * vertical);
    }
}
