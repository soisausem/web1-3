using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob
{
    public string name = "モブ敵";
    public int hp = 200;
}

public class Player
{
    Mob youMob = new Mob();
    private string name = "勇者君";
    private int hp = 100;
    private int power = 50;

    public int Attack(int x)
    {
        youMob.hp -= this.power;
        Debug.Log(this.name + "の攻撃！");
        Debug.Log(this.power + "のダメージを与えた！");
        if (youMob.hp < 0)
        {
            Debug.Log(youMob.name + "を倒した！");
            return 3;
        }
        return x;
    }
    public int Damege(int damege,int x)
    {
        this.hp -= damege;

        Debug.Log(youMob.name + "の攻撃！");
            Debug.Log(damege + "のダメージを受けた");
        if (this.hp < 0) this.hp = 0;
            Debug.Log("残りHP" + this.hp);
        if (this.hp <= 0)
        {
            Debug.Log(this.name + "はしんでしまった・・・");
            return 4;
        }
        return x;
    }
    public void Power(int ATK)
    {
        if (ATK > this.power)
        {
            this.power = ATK;
            Debug.Log("武器を拾った.攻撃力が" + this.power + "になった");
        }
        else
        {
            Debug.Log("武器を拾ったけどなんか弱そうなので捨てた");
        }
    }
}
public class web4Test : MonoBehaviour {
    int Lulet(int x)
    {
        int y = x % 3;
        return y;
    }

    
	// Use this for initialization
	void Start () {

        Player myPlayer = new Player();
        int y;
        int[] lulet = { 21, 34, 72, 23, 66, 56, 12, 55, 200, 15 };

        for (int i = 0; i < lulet.Length; i++)
        {
            y = Lulet(lulet[i]);
            Debug.Log(i + 1 + "ターン目です");
            if (y == 0) y = myPlayer.Attack(y);
            else if (y == 1) y = myPlayer.Damege(lulet[i], y);
            else if (y == 2) myPlayer.Power(lulet[i]);
            if (y == 3)
            {
                Debug.Log("戦いは終わった！");
                break;
            }
            else if (y == 4)
            {
                Debug.Log("しんでしまうとはなさけない！");
                break;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
