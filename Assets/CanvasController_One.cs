using P7.CanvasFlow;
using UnityEngine;

public class CanvasController_One : CanvasController
{
    #region Mono Behaviour Lifecycle

    protected override void Start()
    {
        base.Start();

        // Configure your canvas controller.
    }

    #endregion

	public void colorChange () {
		backgroundImage.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
	}

    /*
    #region Storyboard Transition

    // An opportunity to pass data between canvas controllers when using Storyboards.
    public override void PrepareForStoryboardTransition(StoryboardTransition transition)
    {
        //var source = transition.SourceCanvasController<YourSourceCanvasControllerType>();
        //var destination = transition.DestinationCanvasController<YourDestinationCanvasControllerType>();
    }

    #endregion
    */
}