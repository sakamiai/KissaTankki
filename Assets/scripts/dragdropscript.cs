using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]

public class dragdropscript : MonoBehaviour
{

 	private float mouseClickYPos;
	private float objectInitialYPos = 0 ;
	private Vector3 objectPostion;
	public float sensivity =100 ;
	public bool releaded = false ;

	public float threshold = 3f;
	public float movement = 0;

	
	public delegate void ReloadAction ();
	public static event ReloadAction ReloadDone;
	
	//private Vector3 screenPoint;
	//private Vector3 offset;
	void Start () 
	{
		objectInitialYPos = transform.localPosition.y;
	}
 
	
	public void ReturnToStart()
	{
		transform.localPosition = new Vector3(transform.localPosition.x, objectInitialYPos ,transform.localPosition.z);

	}
	
	
	void OnMouseDown ()
	{
		mouseClickYPos =  Input.mousePosition.y;
		objectPostion = gameObject.transform.localPosition;
		
//		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
// 
//		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
 
	}
 
	void OnMouseDrag ()
	{

		float mouseDelta =  Input.mousePosition.y - mouseClickYPos;
		float objectMovement = objectInitialYPos + mouseDelta / sensivity;

		movement = objectMovement ;
		if(objectMovement > threshold) 
		transform.localPosition = new Vector3(transform.localPosition.x, objectMovement , transform.localPosition.z);
		if(objectMovement <= threshold) {
			if(releaded )
				return ;
			Debug.LogWarning("reload");
			releaded = true ;

			if(ReloadDone != null){

				ReloadDone();

		}
		}
	}

	void OnMouseUp() {
		releaded = false ;
		movement = 0 ;
		ReturnToStart();
	}
 

}