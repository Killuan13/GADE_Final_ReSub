using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class unit : MonoBehaviour {
    [SerializeField] protected int team;
    [SerializeField] protected float spd;
    [SerializeField] protected Material[] mat;
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int atk;
    [SerializeField] protected int range;

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
    public int Atk
    {
        get
        {
            return atk;
        }
    }
    public int Range
    {
        get
        {
            return range;
        }
        set
        {
            range = value;
        }
    }
    public int Team
    {
        get
        {
            return team;
        }
    }
    public float Spd
    {
        get
        {
            return spd;
        }
    }
    public Material[] Mat
    {
        get
        {
            return mat;
        }
    }

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsInRange(GetClosestUnit()))
        {
            transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);
        }
	}

    protected bool IsInRange(GameObject Enemy)
    {
        bool returnVal = false;
        if (Vector3.Distance(transform.position, Enemy.transform.position) <= range)
        {
            return true;
        }
        else return returnVal;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        switch (team)
        {
            case 1:
                GameObject.FindGameObjectsWithTag("team 2");
                break;
            case 2:
                GameObject.FindGameObjectsWithTag("team 1");
                break;
        }
        float distance = 9999;
        foreach (GameObject temp in units)
        {
            float tempDist = Vector3.Distance(transform.position, temp.transform.position);
            if (tempDist <= distance)
            {
                distance = tempDist;
                unit = temp;
            }
        }
        return unit;
    } 
}
