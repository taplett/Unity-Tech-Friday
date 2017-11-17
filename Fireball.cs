using UnityEngine;
using System.Collections;
public class Fireball : MonoBehaviour {										//1
	public float speed = 10.0f;												//1
	public int damage = 1;													//1

	void Update() {															//1
		transform.Translate(0, 0, speed * Time.deltaTime);					//1
	}

	void OnTriggerEnter(Collider other) {									//1
		PlayerCharacter player = other.GetComponent<PlayerCharacter>();		//1
		if (player != null) {												//1
			Debug.Log("Player hit");										//1
			//player.Hurt(damage);											//2
		}
		Destroy(this.gameObject);											//1
	}
}