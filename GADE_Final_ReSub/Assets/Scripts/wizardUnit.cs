using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizardUnit : unit {

	// Use this for initialization
	void Start () {
        hp = 10;
        maxHp = hp;
        atk = 2;
        range = 3;
        spd = 1;
        team = 3;
        GetComponent<MeshRenderer>().material = mat[team - 1];
        gameObject.tag = "team 3";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
