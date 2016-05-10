using UnityEngine;
using System.Collections;

public class CharacterClass : MonoBehaviour {
	public float Speed = 0.25f;

	Animator anim;
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	
	}

	void ChoosePosition(string dir )
	{
		switch (dir) {
		case "left":
			gameObject.transform.Translate (-Speed, 0, 0);
			anim.SetTrigger ("MovieSide");
			if (gameObject.transform.localScale.x > 0)
			 gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y,gameObject.transform.localScale.z);

			break;
		case "right":
			gameObject.transform.Translate (Speed, 0, 0);
			anim.SetTrigger ("MovieSide");
			if (gameObject.transform.localScale.x < 0)
				gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y,gameObject.transform.localScale.z);
			
			break;
		case "up":
			gameObject.transform.Translate (0, Speed, 0);
			anim.SetTrigger ("MoveUp");
			break;
		case "down":
			gameObject.transform.Translate (0, -Speed, 0);
			anim.SetTrigger ("MoveDown");
			break;
		}
	}
//	void AnimateChar(string dir)
//	{
//
//		switch (dir)
//		{
//		case "down":
//			anim.SetTrigger ("MoveDown");
//			break;
//		case "up":
//			anim.SetTrigger ("MoveUp");
//			break;
//		case "right":
//			anim.SetTrigger ("MovieSide");
//			break;
		

//		}

//	}
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKey (KeyCode.A)&& gameObject.transform.position.x>-4.8f )
			ChoosePosition("left");
		if (Input.GetKey (KeyCode.D)&& gameObject.transform.position.x<4.8f)
			ChoosePosition("right");
		if (Input.GetKey (KeyCode.W)&& gameObject.transform.position.y<4.8f)
			ChoosePosition("up");
		if (Input.GetKey (KeyCode.S)&& gameObject.transform.position.y>-4.8f)
			ChoosePosition("down"); 
		
//		if (Input.GetKeyDown (KeyCode.S)&& gameObject.transform.position.y>-4.8f)
//			AnimateChar("down");
//	
//
//		if (Input.GetKeyUp(KeyCode.S)&& gameObject.transform.position.y>-4.8f)
//			anim.SetTrigger("StopMovement");
//		
//		if (Input.GetKeyDown (KeyCode.W)&& gameObject.transform.position.y<4.8f)
//			AnimateChar("up");
//
//
//		if (Input.GetKeyUp(KeyCode.W)&& gameObject.transform.position.y<4.8f)
//			anim.SetTrigger("StopMovement");
//		
//		if (Input.GetKeyDown (KeyCode.A) && gameObject.transform.position.x > -4.8f) {
//			
//			AnimateChar ("left");
//			gameObject.transform.localScale = new Vector3 (-3.5f, 3.5f, 1);
//		}
//
//		if (Input.GetKeyUp(KeyCode.A)&& gameObject.transform.position.x>-4.8f)
//			anim.SetTrigger("StopMovement");
//		
//		if (Input.GetKeyDown (KeyCode.D) && gameObject.transform.position.x < 4.8f) {
//			
//			AnimateChar ("right");
//		}
//
//
//		//if (Input.GetKeyUp(KeyCode.D)&& gameObject.transform.position.x<4.8f)
			//anim.SetTrigger("StopMovement");
	}
}
