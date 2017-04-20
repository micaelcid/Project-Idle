using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroes : MonoBehaviour {

    // Use this for initialization
    public ClickSystem User;
    public UnityEngine.UI.Text itemInfo;
    public float UPGRADECOST = 10;
    public int QUANTITY = 1;
    public float CLICKPOWER = 1;
    public float IDLETEST = 0.1f;
    private float baseCost;

    // Update is called once per frame
    void Start()
    {
        baseCost = UPGRADECOST;
    } 

    void Update () {
        itemInfo.text = "Player " + " lvl " + QUANTITY + "\nCost: " + UPGRADECOST + "\nPower: " + CLICKPOWER;		
	}
    public void PurchasedUpgrade()
    {
        if(User.GOLD >= UPGRADECOST)
        {
            User.GOLD -= UPGRADECOST;
            QUANTITY++;
            CLICKPOWER += CLICKPOWER + 1;
            UPGRADECOST = Mathf.Round(baseCost * Mathf.Pow(1.15f,QUANTITY));
        }
    }
}
