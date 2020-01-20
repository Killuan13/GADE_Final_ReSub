using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceBuilding : building {

	// Use this for initialization
	void Start () {
        hp = 10;
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
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
