using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
	public List<Shot> WS = new List<Shot>();
	public List<Shot> BS = new List<Shot>();
	public bool OnOff = true;
    // Start is called before the first frame update
    void Start()
    {
		for ( int counter = 0; counter < 8; counter++)
		{
			BS[counter].enabled=!OnOff;
		}
    }

    // Update is called once per frame
    void OnMouceUp()
    {
		OnOff=!OnOff;
		for ( int counter = 0; counter < 8; counter++)
		{
			BS[counter].enabled=!OnOff;
			WS[counter].enabled=OnOff;
		}
    }
}
