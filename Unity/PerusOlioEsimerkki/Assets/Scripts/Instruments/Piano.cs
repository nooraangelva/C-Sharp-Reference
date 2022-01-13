using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MusicInstruments
{
  private int numberOfKeys;

  public int NumberOfKeys
    {
        set
        {
            this.numberOfKeys = value;
        }
        get
        {
            return this.numberOfKeys;
        }
    }
}
