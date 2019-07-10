using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {
    [SerializeField]
    private RayCast m_Raycast;
    [SerializeField]
    private EffectManager m_EffectManager;

    [SerializeField]
    private LoadScene m_LoadScene;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = m_Raycast.RayerHitObject();
            LoadScene load_scene = obj.GetComponent<LoadScene>();
            if (null != load_scene)
            {
                load_scene.ChangeScene();
            }

            Vector3 tap = Input.mousePosition;
            tap.z = 8;
            m_EffectManager.TapEffect(Camera.main.ScreenToWorldPoint(tap));
        }
    }
}
