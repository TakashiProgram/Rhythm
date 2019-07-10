using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour {

    [SerializeField]
    private GameObject m_TapEffect;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TapEffect(Vector3 pos)
    {
        Instantiate(m_TapEffect, pos,Quaternion.identity);
    }
}
