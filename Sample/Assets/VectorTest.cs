using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 playerPos = new Vector2(8.0f, 2.0f);
        Vector2 startPos = new Vector2(1.8f, 3.5f);
        Vector2 endPos = new Vector2(8.8f, 5.5f);
        Vector2 dir = endPos - startPos;
        playerPos.x += 2.2f;
        playerPos.y -= 0.1f;
        Debug.Log(playerPos);
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
