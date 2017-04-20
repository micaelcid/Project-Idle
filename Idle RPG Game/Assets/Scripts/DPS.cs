using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour {

    public UnityEngine.UI.Text dpsDisplay;
    public ClickSystem User;
    public MonsterSystem Monster;
    public Party[] Members;

    void Start()
    {
        StartCoroutine(AutoTick());
    }
    void Update()
    {
        dpsDisplay.text = DealDamagePerSec() + " damage/sec"; 
    }
    public int DealDamagePerSec()
    {
        int tick = 0;
        foreach(Party Member in Members)
        {
            tick += Member.MEMBERLEVEL * Member.tickValue;
        }return tick;
    }

    public void AutoDamagePerSec()
    {
        Monster.CURRENTLIFE -= DealDamagePerSec();
        
    }
    IEnumerator AutoTick()
    {
        while(true)
        {
            AutoDamagePerSec();
            yield return new WaitForSeconds(1);
           
        }
    }
   
	
}
