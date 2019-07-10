using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public GameObject RayerHitObject()
    {
        Ray ray = this.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit))
        {
            return hit.collider.gameObject;
        }
        return this.gameObject;
    }

    public Vector3 MousePos()
    {
        return Input.mousePosition;
    }
}
