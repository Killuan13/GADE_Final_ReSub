using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resourceBuilding : building {

	// Use this for initialization
	void Start () {
        hp = 40;
        maxHp = hp;
        bTeam = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = bMat[bTeam - 1];
        switch (bTeam)
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
