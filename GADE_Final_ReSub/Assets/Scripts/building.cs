using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int bTeam;
    [SerializeField] protected Material[] bMat;


    public int Hp 
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    public int MaxHp
    {
        get
        {
            return maxHp;
        }
    }
    public int BTeam
    {
        get
        {
            return bTeam;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
