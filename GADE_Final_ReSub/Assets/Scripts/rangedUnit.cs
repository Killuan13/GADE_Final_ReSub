using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedUnit : unit {

	// Use this for initialization
	void Start () {
        hp = 10;
        maxHp = hp;
        atk = 2;
        range = 2;
        spd = 0.5f;
        team = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = mat[team - 1];
        switch (team)
        {
            case 1:
                gameObject.tag = "team 1";
                break;
            case 2:
                gameObject.tag = "team 2";
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
