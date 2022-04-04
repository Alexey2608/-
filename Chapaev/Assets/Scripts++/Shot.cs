using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour 
{
    private Vector3 offset;
	public Rigidbody2D rb;
	void Start () 
	{
	rb = GetComponent<Rigidbody2D>();
	}
	
    void OnMouseDown()
    {
        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}
	
    void OnMouseUp()
    {
        rb.AddForce(offset*0.575f,ForceMode2D.Force);
    }
 
}