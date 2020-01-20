using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEngine : MonoBehaviour {

    [SerializeField] GameObject[] options = new GameObject[4];
    [SerializeField] static int MIN_X = -10, MAX_X = 10, MIN_Z = -10, MAX_Z = 10, UNITS = 10;
	
    // Use this for initialization
	void Start () {
		for (int i = 0; i < UNITS; i++)
        {
            CreateUnit();
        }
	}
	
	void CreateUnit()
    {
        GameObject unit = Instantiate(options[Random.Range(0, 4)]);
        unit.transform.position = new Vector3(Random.Range(MIN_X, MAX_X), 0, Random.Range(MIN_Z, MAX_Z));
    }
}
