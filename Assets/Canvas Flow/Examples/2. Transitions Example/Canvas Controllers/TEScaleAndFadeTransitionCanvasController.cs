using P7.CanvasFlow;
using UnityEngine;

public class TEScaleAndFadeTransitionCanvasController : CanvasController
{
    [Header("TEScaleAndFadeTransitionCanvasController")]
    public RectTransform mainContent;

    #region Back Button Callback

    public void OnBackButtonPressed()
    {
        DismissCanvasController();
    }

    #endregion
}