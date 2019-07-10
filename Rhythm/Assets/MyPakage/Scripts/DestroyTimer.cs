using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("DestroyTime");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
   
}
