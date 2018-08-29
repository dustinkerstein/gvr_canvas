using UnityEngine;

public class WSColorControlCanvasController : WSControlPanelBaseCanvasController
{
    public Color[] colors;

    #region Control

    public void SetLeftColor(int colorIndex)
    {
        if (cube != null)
        {
            Color color = colors[colorIndex];
            cube.SetLeftColor(color);
        }
    }

    public void SetRightColor(int colorIndex)
    {
        if (cube != null)
        {
            Color color = colors[colorIndex];
            cube.SetRightColor(color);
        }
    }

    #endregion
}