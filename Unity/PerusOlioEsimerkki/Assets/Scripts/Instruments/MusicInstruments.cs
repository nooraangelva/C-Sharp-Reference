using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInstruments 
{
    private string manufactor;

    public string Manufactor
    {
        set
        {
            this.manufactor = value;
        }
        get
        {
            return this.manufactor;
        }
    }
    public void Play()
    {
        Debug.Log("soitto");
    }
}
