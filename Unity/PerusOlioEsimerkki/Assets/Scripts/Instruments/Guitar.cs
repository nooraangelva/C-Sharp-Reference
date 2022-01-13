using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : MusicInstruments
{
   private int numberOfStrings;

  public int NumberOfStrings
    {
        set
        {
            this.numberOfStrings = value;
        }
        get
        {
            return this.numberOfStrings;
        }
    }
}
