using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
  
    public Material[] on;
    public Material[] off;


    public void ON()
    {
        Debug.Log("ON");
        this.GetComponent<MeshRenderer>().materials = on;
    }

    public void OFF()
    {
        Debug.Log("OFF");
        this.GetComponent<MeshRenderer>().materials = off;
    }
}
