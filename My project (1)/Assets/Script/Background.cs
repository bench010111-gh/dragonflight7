using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    private Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // load
        Vector2 newOffset = myMaterial.mainTextureOffset;

        // set new offset (applying time and speed)
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        // update offset of texture
        myMaterial.mainTextureOffset = newOffset;
    }
}
