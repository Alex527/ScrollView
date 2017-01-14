using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewManager : MonoBehaviour
{

    public LoadableButton buttonPrefab;
    public Transform dummyTransform;
    public Transform buttonsParent;
    public Text selectedObjectTitle;

    private bool isAnimationPlaying;
    private LoadableObject selectedObject;
    private LoadableObject[] objects;
    
    void Start()
    {
        objects = Resources.LoadAll<LoadableObject>("");
        CreateButtons();
    }

    private void CreateButtons()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonsParent);
            button.transform.localPosition = Vector3.zero;
            button.transform.localRotation = new Quaternion(0,0,0,0);
            button.Init(this, objects[i]);

        }
    }

    public void SetSelectedObject(LoadableObject loadableObject)
    {
        isAnimationPlaying = false;
        if (selectedObject != null)
        {
            Destroy(selectedObject.gameObject);
        }

        selectedObject = Instantiate(loadableObject);
        selectedObject.transform.SetParent(dummyTransform);
        selectedObjectTitle.text = selectedObject.objectName;
    }

    public void OnAnimationButtonPressed()
    {
        if (selectedObject == null)
        {
            return;
        }
        isAnimationPlaying = !isAnimationPlaying;
        if (isAnimationPlaying)
        {
            selectedObject.PlayAnimation();
        }
        else
        {
            selectedObject.StopAnimation();
        }
    }
}
