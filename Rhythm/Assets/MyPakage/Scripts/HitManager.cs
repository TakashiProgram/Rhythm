using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    private enum Judgment
    {
        None,
        Perfect,
        Great,
        Miss
    }
    private Judgment m_Judgment;

    private GameObject m_NodeObject;

    [SerializeField]
    private ComboManager m_ComboManager;
    
    private int m_JudgmentCount;

    private int m_NotCount = 0;

    void Start()
    {

    }
    
    void Update()
    {
        
    }

    public void SetObjectName(string name,GameObject node)
    {
        if (Judgment.Perfect.ToString() == name)
        {
            m_JudgmentCount = (int)Judgment.Perfect;
            
        }
        else if (Judgment.Great.ToString() == name)
        {
            m_JudgmentCount = (int)Judgment.Great;
        }
        else if ((Judgment.Miss.ToString() == name) || ("DestroyPos" == name))
        {
            m_JudgmentCount = (int)Judgment.Miss;
        }else
        {
            m_JudgmentCount = (int)Judgment.None;
        }
        m_NodeObject = node;

    }

    public void SetNotHit(int count)
    {
        m_ComboManager.SetComboCount(count);
    }

    public int GetJudgmentCount()
    {
        return m_JudgmentCount;
    }
    public GameObject GetNodeObject()
    {
        return m_NodeObject;
    }


}
