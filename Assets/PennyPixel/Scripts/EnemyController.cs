﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Transform Enemy;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Enemy.localPosition = new Vector3 (Mathf.Lerp(3, 5, Mathf.PingPong(Time.time * .5f, 1)),.5f,0f);

    }
}
