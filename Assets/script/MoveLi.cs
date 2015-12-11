using UnityEngine;
using System.Collections;

public class MoveLi : MonoBehaviour {
	public Transform[] transform;

	public Transform left_center;
	public Transform right_center;
	public Transform up_center;
	public Transform down_center;
	public Transform forward_center;
	public Transform back_center;

	private bool isF;
	private bool isB;
	private bool isL;
	private bool isR;
	private bool isU;
	private bool isD;
	private bool isf;
	private bool isb;
	private bool isl;
	private bool isr;
	private bool isu;
	private bool isd;

	private float temp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.A)) {
			isR = true;
			temp = right_center.eulerAngles.x;
			Debug.Log("aaaa");
		}

		if (isR) {
			Debug.Log(temp);
			for(int i = 0; i < 20; ++i){
				if(transform[i].position.x == right_center.position.x){
					transform[i].parent = right_center; 
				}
			}
			right_center.Rotate(new Vector3(1, 0, 0) * 180 * Time.deltaTime);

			if(right_center.eulerAngles.x >= temp + 90){
				isR = false;
			}
		}
	}
}
