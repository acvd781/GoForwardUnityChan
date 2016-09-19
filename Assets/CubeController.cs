using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    //キューブの移動速度
    private float speed = -0.2f;
    //消滅位置
    private float deadLine = -10;
    //効果音変数作成
    private AudioSource syoutotuSE;

	// Use this for initialization
	void Start () {
        //効果音入れ込み
        syoutotuSE = GetComponent<AudioSource>();
 	
	}
	
	// Update is called once per frame
	void Update () {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);
        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine){
            Destroy(gameObject);
        }
	
	}
    //衝突した対象がUnityChanタグ以外のときにSEを鳴らす
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag != "UnityChan") {
            syoutotuSE.PlayOneShot(syoutotuSE.clip);
        }
    }
}
