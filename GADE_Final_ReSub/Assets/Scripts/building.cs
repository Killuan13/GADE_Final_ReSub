using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class building : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int bTeam;
    [SerializeField] protected Material[] bMat;
    [SerializeField] protected Image healthBar;

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
        healthBar.fillAmount = (float)hp / maxHp;
        hp -= GetComponent<unit>().Atk;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
	}
}
