using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	// Code found in tutorial https://www.youtube.com/watch?v=jNiCEUisrRM&feature=youtu.be&t=31m21s
	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	//depending on input, it will change the direction of the sprite image
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			resetDirAnim(1);
			anim.SetBool("Left",true);
				}
		if (Input.GetKey (KeyCode.W)) {
			resetDirAnim(1);
			anim.SetBool("Up",true);
		}
		if (Input.GetKey (KeyCode.D)) {
			resetDirAnim(1);
			anim.SetBool("Right",true);
		}
		if (Input.GetKey (KeyCode.S)) {
			resetDirAnim(1);
			anim.SetBool("Down",true);
		}
	}
	//My own code
	void resetDirAnim(int i){
		if (i == 1) {
			anim.SetBool("Up",false);
			anim.SetBool("Right",false);
			anim.SetBool("Down",false);
			anim.SetBool("Left",false);
				}
		if (i == 2) {
			anim.SetBool("Up",false);
			anim.SetBool("Right",false);
			anim.SetBool("Down",false);
			anim.SetBool("Left",false);

			anim.SetBool("WalkLeft",false);
			anim.SetBool("WalkUp",false);
			anim.SetBool("WalkRight",false);
			anim.SetBool("WalkDown",false);
				}
		}
}
