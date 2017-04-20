using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour {
    public UnityEngine.UI.Text partyInfo;
    public ClickSystem User;
    public float MEMBERCOST;
    public int tickValue;
    public int MEMBERLEVEL;
    public string memberName;
    private float baseCost;
	// Use this for initialization
	void Start () {
        baseCost = MEMBERCOST;
	}
	
	// Update is called once per frame
	void Update () {
        partyInfo.text = memberName + "\nCost: " + MEMBERCOST + "\nDamage: " + tickValue + "/s";
	}
    public void PurchasedMember()
    {
        if(User.GOLD >= MEMBERCOST)
        {
            User.GOLD -= MEMBERCOST;
            MEMBERLEVEL++;
            MEMBERCOST = Mathf.Round( baseCost * Mathf.Pow(1.15f, MEMBERLEVEL));
        }
    }
}
