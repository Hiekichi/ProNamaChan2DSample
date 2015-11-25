using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 他のオブジェクトと衝突した時に呼び出される関数
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Box") {
			Destroy (this.gameObject);  // 消滅
		}
	}

}
