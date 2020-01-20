using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wizardUnit : unit {

	// Use this for initialization
	void Start () {
        hp = 40;
        maxHp = hp;
        atk = 5;
        range = 3;
        spd = 1;
        team = 3;
        GetComponent<MeshRenderer>().material = mat[team - 1];
        gameObject.tag = "team 3";
        healthBar = GetComponentsInChildren<Image>()[1];
    }
}
