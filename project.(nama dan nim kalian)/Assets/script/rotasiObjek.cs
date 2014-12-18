using UnityEngine;
using System.Collections;

public class rotasiObjek : MonoBehaviour {


	public float kecRotasiX;
	public float kecRotasiY;
	public float kecRotasiZ;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (kecRotasiX , kecRotasiY , kecRotasiZ);

	}
}
