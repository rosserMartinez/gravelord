﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelScript : MonoBehaviour {


	public bool spinning;

	public float spinTimer;
	public float spinMaxTimer;
	public float spinSpeed;

	public int shovelNum;

	CapsuleCollider2D hitbox;

	// Use this for initialization
	void Start () {
		spinning = false;

		hitbox = GetComponent<CapsuleCollider2D>();
		shovelNum = GetComponentInParent<PlayerScript> ().playerNum;

	}
	
	// Update is called once per frame
	void Update () {

		if (spinTimer < spinMaxTimer && spinning)
		{
			transform.Rotate (0, 0, spinSpeed * Time.deltaTime);
			spinTimer += Time.deltaTime;

			if (spinTimer > spinMaxTimer)
			{
				spinning = false;
				transform.localRotation = Quaternion.identity;
			}
		}
	}

	public void spinShovel()
	{
		//transform.localRotation = Quaternion.identity;
		spinning = true;
		spinTimer = 0f;
	}

	//private void OnCollisionStay2D(Collision2D collision)
	//{
 //       Debug.Log("colliding once");

 //       if (collision.gameObject.tag == "player" && collision.gameObject.GetComponent<PlayerScript>().playerNum != shovelNum)
 //       {
 //           Debug.Log("colliding in if statement");

 //           Vector2 hitVec = new Vector2(collision.transform.position.x - transform.position.x,
 //               collision.transform.position.y - transform.position.y);

 //           collision.gameObject.GetComponent<PlayerScript>().addForce(hitVec * 10);

 //       }
 //   }

}