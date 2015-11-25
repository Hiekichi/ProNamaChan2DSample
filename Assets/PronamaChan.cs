using UnityEngine;
using System.Collections;

public class PronamaChan : MonoBehaviour {
	// 進行方向（X方向、Y方向）
	private int dx;  // 1なら右移動、-1なら左移動、0なら左右の移動なし
	private int dy;  // 1なら上移動、-1なら下移動、0なら上下の移動なし
	
	
	// 最初に1度だけ実行される処理
	void Start () {
		ChangeDirection (1, 0);      // 右移動
		ChangeVisible ("PronamaR");  // 右移動アニメを表示
	}
	
	// フレーム処理ごとに実行される処理
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {     // 右矢印キー押された
			ChangeDirection (1, 0);      // 右移動に変更
			ChangeVisible ("PronamaR");  // 右移動アニメを表示
		} else if (Input.GetKey (KeyCode.DownArrow)) { // 下矢印キー押された
			ChangeDirection (0, -1);     // 下移動に変更
			ChangeVisible ("PronamaD");  // 下移動アニメを表示
		} else if (Input.GetKey (KeyCode.LeftArrow)) { // 左矢印キー押された
			ChangeDirection (-1, 0);     // 左移動に変更
			ChangeVisible ("PronamaL");  // 左移動アニメを表示
		} else if (Input.GetKey (KeyCode.UpArrow)) {   // 上矢印キー押された
			ChangeDirection (0, 1);      // 上移動に変更
			ChangeVisible ("PronamaU");  // 上移動アニメを表示
		} else if (Input.GetKey (KeyCode.A)) {
		
		}

		// このオブジェクトの表示位置をカッコ内の式で示した分だけ変更する（移動する）
		transform.Translate(dx * Time.deltaTime, dy * Time.deltaTime, 0);
	}

	// 他のオブジェクトと衝突した時に呼び出される関数
	void OnCollisionEnter2D(Collision2D coll){
		ChangeDirection (0, 0);  // 移動停止
	}

	// このオブジェクトの進行方向（X方向・y方向）を変更する関数
	void ChangeDirection(int x, int y) {
		dx = x;
		dy = y;
	}

	// 指定された子要素以外だけを表示する関数
	void ChangeVisible(string name) {
		transform.FindChild("PronamaR").gameObject.SetActive(false);
		transform.FindChild("PronamaD").gameObject.SetActive(false);
		transform.FindChild("PronamaL").gameObject.SetActive(false);
		transform.FindChild("PronamaU").gameObject.SetActive(false);
		transform.FindChild( name ).gameObject.SetActive(true);
	}
}