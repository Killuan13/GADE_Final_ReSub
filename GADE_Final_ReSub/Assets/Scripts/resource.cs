using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resource : MonoBehaviour {
    [SerializeField] int nResource;

    public int numResource
    {
        get
        {
            return nResource;
        }
    }
	// Use this for initialization
	void Start () {
        nResource = Random.Range(0, 101);
	}
	
	// Update is called once per frame
	void Update () {
        int resourceTotal = 0;
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Resource");
        foreach (GameObject o in resources)
        {
            resourceTotal += o.GetComponent<resource>().numResource;
        }
        Text resourceBox1 = GameObject.Find("ResourceText").GetComponent<Text>();
        resourceBox1.text = "Resources: " + resourceTotal;
	}
}
