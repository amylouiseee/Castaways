using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ActivateChest : MonoBehaviour {

	public Transform lid, lidOpen, lidClose;	// Lid, Lid open rotation, Lid close rotation
	public float openSpeed = 5F;				// Opening speed
	public bool canClose;                       // Can the chest be closed
    public GameObject ShowText;
	[HideInInspector]
	public bool _open;							// Is the chest opened

	void Update () {
		if(_open){
			ChestClicked(lidOpen.rotation);
		}
		else{
			ChestClicked(lidClose.rotation);
		}
	}
	
	// Rotate the lid to the requested rotation
	void ChestClicked(Quaternion toRot){
		if(lid.rotation != toRot){
			lid.rotation = Quaternion.Lerp(lid.rotation, toRot, Time.deltaTime * openSpeed);
		}
	}
	
	void OnMouseDown(){
      //  if (canClose) _open = !_open;
        if(!_open)
        {
            _open = true;
            ShowText .SetActive(true);
            ShowText.GetComponent<Text>().text = "恭喜获得" + Random.Range(5, 20).ToString() + "金币";
            Destroy(this.gameObject,3);
        } 
	}
}
