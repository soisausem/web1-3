using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {

        //変数作成
        int HP, ATK;
        int age, n1 = 3, n2 = 2, n3 = 10;
        int[] answer = new int[7];
        float height1 = 160.5f;
        float height2;
        string name;
        string str = " Lemone";

        //変数代入、計算
        age = 30;
        name = "Tomaten";
        answer[0] = 32 + 53;
        answer[1] = 20 / 5;
        answer[2] = 3 * 3;
        answer[3] = 10 - 11;
        answer[4] = n1 + n2;
        n3 += 5;
        answer[5] += n3;
        n1++;
        answer[6] = n1;

        //変数同士のやり取り
        height2 = height1;

        //文字の出力
        Debug.Log("Hello, World");
        Debug.Log(age);
        Debug.Log(height2);
        Debug.Log(name);

        name += str;
        str += n2;

        Debug.Log(name);
        Debug.Log(str);

        for (int i = 0; i < 7; i++)
        {
            Debug.Log(answer[i]);
        }

        //if文用

        HP = 350;
        ATK = 20;

        if (HP < 300)
        {
            Debug.Log("しにそうです！");
        }
        else if (HP >= 300)
        {
            Debug.Log("余裕っすね");
        }

        if (ATK < 10)
        {
            Debug.Log("刃が折れている…");
        }
        else if (ATK >= 10)
        {
            Debug.Log("今こそ攻撃の時！");
        }

        //for文用
        for(int j = 3; j >= 0; j--)
        {
            Debug.Log(j);
        }
        int sum = 0;

        for(int r = 1; r <= 10; r++)
        {
            sum += r;
        }
        Debug.Log(sum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
