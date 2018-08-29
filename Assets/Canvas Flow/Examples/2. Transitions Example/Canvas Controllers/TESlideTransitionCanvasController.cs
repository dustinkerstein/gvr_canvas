using P7.CanvasFlow;
using UnityEngine;

public class TESlideTransitionCanvasController : CanvasController
{
    #region Back Button Callback

    public void OnBackButtonPressed()
    {
        DismissCanvasController();
    }

    #endregion
}