using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSystem : MonoBehaviour {
    public Heroes Hero;
    public MonsterSystem Monster;
    public UnityEngine.UI.Text monsterStats;
    public UnityEngine.UI.Text goldDisplay;
    public UnityEngine.UI.Text gpc;
	public float GOLD = 0;

	void Update()
	{
        goldDisplay.text = "Gold: " + GOLD;
        gpc.text = "GPC: " + Hero.CLICKPOWER;
        monsterStats.text = "Monster lvl " + Monster.LEVEL + "\nHP: " + Monster.CURRENTLIFE + "/" + Monster.MAXLIFE;
    }
	public void Clicked()
	{
        Monster.CURRENTLIFE -= Hero.CLICKPOWER;
        if (Monster.CURRENTLIFE <= 0)
        {
            Monster.LEVEL++;
            Monster.MAXLIFE = 10 * Monster.LEVEL;
            Monster.CURRENTLIFE = Monster.MAXLIFE;    
            Monster.GOLDDROP++;
            GOLD = Monster.GOLDDROP * Monster.LEVEL;
        }

    }
}
