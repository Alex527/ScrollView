using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadableButton : MonoBehaviour {

    public Text buttonName;
    public RawImage previewImage;

    private ViewManager viewManager;
    private LoadableObject loadableObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        viewManager.SetSelectedObject(loadableObject);
    }

    public void Init(ViewManager viewManager, LoadableObject loadableObject)
    {
        this.viewManager = viewManager;
        this.loadableObject = loadableObject;

        buttonName.text = loadableObject.objectName;
        previewImage.texture = loadableObject.previewImage;
    }
}
