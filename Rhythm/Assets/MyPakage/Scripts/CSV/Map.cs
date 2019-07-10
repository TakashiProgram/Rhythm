using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    private CSVWriter m_CsvWriter = new CSVWriter();
    private List<List<string>> csv = new List<List<string>>();
    int a;
    int s;
    int d;
    int f;
    int g;

    private float m_Time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_Time += Time.deltaTime;

        if (a+s+d+f+g != 0)
        {
            List<string> line = new List<string>();
            line.Add(m_Time.ToString());
            line.Add(a.ToString());
            line.Add(s.ToString());
            line.Add(d.ToString());
            line.Add(f.ToString());
            line.Add(g.ToString());

            csv.Add(line);
            a = s = d = f = g = 0;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            a = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            s = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            d = 1;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            f = 1;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            g = 1;
        }
    }

    private void OnApplicationQuit()
    {
        m_CsvWriter.WriteCSV(csv, "Turkey");
    }
}
