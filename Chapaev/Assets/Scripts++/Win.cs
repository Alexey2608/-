using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	public List<GameObject> White = new List<GameObject>();
	public List<GameObject> Black = new List<GameObject>();
	public GameObject Label1;
	public GameObject Label2;
    // Start is called before the first frame update
    void Start()
    {
		Label1.SetActive(false); 
		Label2.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
		if ((Black[0].activeInHierarchy==false) & (Black[1].activeInHierarchy==false) & (Black[2].activeInHierarchy==false) & (Black[3].activeInHierarchy==false) & (Black[4].activeInHierarchy==false) & (Black[5].activeInHierarchy==false) & (Black[6].activeInHierarchy==false) & (Black[7].activeInHierarchy==false) & (Label1.activeInHierarchy==false))
		{
			Label2.SetActive(true);     
		}
        if ((White[0].activeInHierarchy==false) & (White[1].activeInHierarchy==false) & (White[2].activeInHierarchy==false) & (White[3].activeInHierarchy==false) & (White[4].activeInHierarchy==false) & (White[5].activeInHierarchy==false) & (White[6].activeInHierarchy==false) & (White[7].activeInHierarchy==false) & (Label2.activeInHierarchy==false))
		{
			Label1.SetActive(true);     
		}
    }
}
