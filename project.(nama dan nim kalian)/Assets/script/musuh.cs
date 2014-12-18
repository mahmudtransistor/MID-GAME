using UnityEngine;
using System.Collections;

public class musuh : MonoBehaviour {

	private rotasiObjek komponenRotasiObjek;
	private gerakKarakter2 komponenGerakKarakter;


	void Start () {
	komponenRotasiObjek = GameObject.Find ("baling").GetComponent<rotasiObjek>();
	komponenGerakKarakter = GameObject.Find ("wadah karakter").GetComponent<gerakKarakter2>();

	}
	

	void Update () {	
	
	}
	//-->
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.tag == "Player") {
		print ("anda menyentuh musuh");
		komponenRotasiObjek.kecRotasiZ = 5;
		komponenGerakKarakter.nyawa--;
		komponenGerakKarakter.kenaMusuh=true;

		}//<--
	}

}
