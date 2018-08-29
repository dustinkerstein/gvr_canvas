using P7.CanvasFlow;
using UnityEngine;

public class TEFadeTransitionCanvasController : CanvasController
{
    #region Back Button Callback

    public void OnBackButtonPressed()
    {
        DismissCanvasController();
    }

    #endregion
}