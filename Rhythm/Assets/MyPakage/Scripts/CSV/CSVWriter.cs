using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CSVWriter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WriteCSV(List<List<string>>csv,string path)
    {
        string file_path = Application.dataPath + "/"+ path+ ".csv";
        FileInfo file = new FileInfo(file_path);
        StreamWriter sw = null;
        try
        {
             sw = file.AppendText();

            for (int i = 0; i < csv.Count; i++)
            {
                string list = "";
                for (int j = 0; j < csv[i].Count; j++)
                {
                    if (list == "")
                    {
                        list += csv[i][j];
                    }
                    else
                    {
                        list += "," + csv[i][j];
                    }
                }
                sw.WriteLine(list);
            }
        }catch(Exception e)
        {
            Debug.LogError(e);
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
            }
           
        }
    }
}
