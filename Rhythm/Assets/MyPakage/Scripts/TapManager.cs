using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour
{
    [SerializeField]
    private RayCast m_Raycast;

    [SerializeField]
    private ComboManager m_ComboManager;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)/* || Input.GetKeyDown(KeyCode.A)*/)
        {
            GameObject obj = m_Raycast.RayerHitObject();


            if (obj.gameObject.tag == "Tap")
            {
                HitManager hit_manager = obj.GetComponent<HitManager>();
                int count = hit_manager.GetJudgmentCount();
                GameObject node = hit_manager.GetNodeObject();
                if (null == node)
                {
                    return;
                }
                Destroy(node);
                m_ComboManager.SetComboCount(count);
                
            }
        }
    }
}
