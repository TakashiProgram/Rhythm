using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {
    [SerializeField]
    private RayCast m_Raycast;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)){
            GameObject obj = m_Raycast.RayerHitObject();
            Debug.Log(obj);
        }

    }
}
