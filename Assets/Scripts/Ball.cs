﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	
	private Vector3 paddleToBallVector; 
	public Rigidbody2D rb;
	public float thrust = 10;
	private bool GameInSession = false;
	
	
	void Start()
	{
		paddleToBallVector = this.transform.position - paddle.transform.position;	
		print(paddleToBallVector);
	}
	
	void Update()
	{
		if(!GameInSession)
		{
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
		
			if(Input.GetMouseButtonUp(0))
			{
				GameInSession = true;
				print("Mouse clicked!");
					
				float x, y;
				
				x = Random.Range(-2f,2f);
				y = Random.Range(10f,15f);
				
				rb.velocity = new Vector2 (x, y);
			
			}
		
		}
		
		
	}
	
}