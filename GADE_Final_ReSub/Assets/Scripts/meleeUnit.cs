using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meleeUnit : unit {

	// Use this for initialization
	void Start () {
        hp = 40;
        maxHp = hp;
        atk = 2;
        range = 1;
        spd = 1;
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
        healthBar = GetComponentsInChildren<Image>()[1];
	}
}
