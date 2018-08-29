using UnityEngine;

public class WSCube : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private MaterialPropertyBlock propertyBlock;

    [Header("Movement")]
    public float moveSpeed;
    public Vector3 maximumMovement;

    [Header("Position")]
    public float minimumPosition;
    public float maximumPosition;

    [Header("Scale")]
    public float minimumHeight;
    public float maximumHeight;

    #region Mono Lifecycle

    private void Awake()
    {
        propertyBlock = new MaterialPropertyBlock();
        meshRenderer.GetPropertyBlock(propertyBlock);
    }

    #endregion

    #region Control

    public void SetLeftColor(Color color)
    {
        propertyBlock.SetColor("_Light0Color", color);
        meshRenderer.SetPropertyBlock(propertyBlock);
    }

    public void SetRightColor(Color color)
    {
        propertyBlock.SetColor("_Light1Color", color);
        meshRenderer.SetPropertyBlock(propertyBlock);
    }

    public void SetPosition01(float minimumPosition01)
    {
        Vector3 position = transform.position;
        position.x = Mathf.Lerp(minimumPosition, maximumPosition, minimumPosition01);
        transform.position = position;
    }

    public void SetHeight01(float height)
    {
        Vector3 scale = transform.localScale;
        scale.y = Mathf.Lerp(minimumHeight, maximumHeight, height);
        transform.localScale = scale;
    }

    #endregion
}