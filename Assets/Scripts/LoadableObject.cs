using UnityEngine;

[RequireComponent(typeof (Animation), typeof (MeshRenderer))]

public class LoadableObject : MonoBehaviour
{
    public string objectName;
    public Texture2D previewImage;
    private MeshRenderer meshRenderer;
    private Animation animation;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        animation = GetComponent<Animation>();
    }

    public Bounds GetBounds()
    {
        return meshRenderer.bounds;
    }

    public void PlayAnimation ()
    {
        animation.Play();
    }

    public void StopAnimation()
    {
        animation.Stop();
        transform.localPosition = new Vector3();
    }

}
