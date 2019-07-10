using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeCreater : MonoBehaviour {

    [SerializeField]
    private GameObject m_Node;
    [SerializeField]
    private Transform m_Destination;
    private GameObject m_LostPostion;
    private CSVReader m_CsvRender = new CSVReader();
    private List<List<string>> m_Map = new List<List<string>>();
    private int m_Line = 0;

    private float m_Time = 0;
    [SerializeField]
    private int m_Selector = 0;
    [SerializeField]
    private GameObject m_NodeParent;

    private void Awake()
    {
        m_Map = m_CsvRender.ReadCSV("Turkey");
    }
    
	void Update () {
        m_Time += Time.deltaTime;
        if (m_Time >= float.Parse(m_Map[m_Line][0]))
        {
            if (int.Parse(m_Map[m_Line][m_Selector]) == 1)
            {
                NodeCreate();
            }
            m_Line++;
        }

    }
    private void NodeCreate()
    {
        GameObject node = Instantiate(m_Node,m_NodeParent.transform);
       node.transform.position = this.transform.position;
        node.GetComponent<NodeMove>().SetDestinationPos(m_Destination.position);

    }
}
