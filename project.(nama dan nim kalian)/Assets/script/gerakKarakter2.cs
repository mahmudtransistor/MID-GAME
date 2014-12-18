using UnityEngine;
using System.Collections;

public class gerakKarakter2 : MonoBehaviour {
	
		public float kecepatan;
		public float lompatan;
		
		

		bool Tanah = false;
		public Transform tanahCheck; 
		float radiusTanah = 0.2f;
		public LayerMask tanahApa;
		

		bool menghadapKanan = true;
		float pindah = 1;
		
		
		Animator anim;

		//-->
		private Vector2 mulai;
		public bool kenaMusuh = false;
		//<--
		public int nyawa;


		void Start () 
		{

		anim = GetComponent<Animator>();
		mulai = transform.position;//<--
		}
		

		void Update () 
		{

		if (nyawa == 0) {
			Destroy(gameObject);		
		}

		if (kenaMusuh == true) {
			transform.position = mulai;
			kenaMusuh = false;
		}



		Tanah = Physics2D.OverlapCircle (tanahCheck.position, radiusTanah, tanahApa);

		if (Tanah == true) {
			anim.SetBool ("tanah", true);
		}
		else {
			anim.SetBool ("tanah", false);
		}

				if ((Tanah == true) && (Input.GetKeyDown (KeyCode.Mouse0))) {
						rigidbody2D.AddForce (new Vector2 (0, lompatan));
				}

				if (Input.GetKey (KeyCode.D)) {
					transform.Translate (Vector2.right * kecepatan * Time.deltaTime);
					pindah = -1;
					anim.SetFloat ("jalan", Mathf.Abs (kecepatan));
				}				
				else if (Input.GetKey (KeyCode.A)) {
					transform.Translate (Vector2.right * -kecepatan * Time.deltaTime);
					pindah = 1;
					anim.SetFloat("jalan", Mathf.Abs (kecepatan));
				}
				else {
					anim.SetFloat ("jalan", Mathf.Abs (0));
				}



			if(pindah > 0 && !menghadapKanan)
			{
				balikBadan();
			}
			else if(pindah < 0 && menghadapKanan)
			{
				balikBadan();
			} 


		}
		
		void balikBadan()
		{
			menghadapKanan = !menghadapKanan;
			Vector3 charScale = transform.localScale;
			charScale.x *= -1;
			transform.localScale = charScale;
		}

	}
