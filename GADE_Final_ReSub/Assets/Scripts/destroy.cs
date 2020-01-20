using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    [SerializeField] int duration = 5;
    [SerializeField] float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            Destroy(gameObject); 
        }
	}
}
