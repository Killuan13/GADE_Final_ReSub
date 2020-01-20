using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class unit : MonoBehaviour {
    [SerializeField] protected Image healthBar;
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

	// Update is called once per frame
	void Update () {
		if (!IsInRange(GetClosestUnit()))
        {    
            transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);
        }
        healthBar.fillAmount = (float)hp / maxHp;
        Attack();
	}

    protected bool IsInRange(GameObject Enemy)
    {
        bool returnVal = false;
        if (Vector3.Distance(transform.position, Enemy.transform.position) <= range)
        {
            returnVal = true;
        }
        else returnVal = false;
        return returnVal;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        GameObject[] wizards = null;

        switch (team)
        {
            case 1:
                units = GameObject.FindGameObjectsWithTag("team 2");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                int tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }

                break;
            case 2:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;
            case 3:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 2");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
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
    protected void Attack()
    {
        if (IsInRange(GetClosestUnit()))
        {
            if (GetClosestUnit().GetComponent<unit>())
            {
                GetClosestUnit().GetComponent<unit>().hp -= atk;
            }

            if (GetClosestUnit().GetComponent<building>())
            {
                GetClosestUnit().GetComponent<building>().Hp -= atk;
            }
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
