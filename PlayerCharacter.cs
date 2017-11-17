using UnityEngine;
using System.Collections;
public class PlayerCharacter : MonoBehaviour {
	private int _health;						//1

	void Start() {								//1
		_health = 5;							//1
	}

	public void Hurt(int damage) {				//1
		_health -= damage;						//1
		Debug.Log("Health: " + _health);		//1
	}
}