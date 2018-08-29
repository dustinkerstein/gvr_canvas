using P7.CanvasFlow;
using UnityEngine;

public class WSPassDataFromWorldToUI : MonoBehaviour
{
    public WSCube cube;

    public void OnStoryboardWillPerformTransition(StoryboardTransition transition)
    {
        // Is the transition downstream (a presentation)?
        if (transition.direction == StoryboardTransitionDirection.Downstream)
        {
            // Is the destination a subclass of the control panel base canvas controller?
            var destinationCanvasController =
                transition.DestinationCanvasController<WSControlPanelBaseCanvasController>();
            if (destinationCanvasController != null)
            {
                // Initialize it with the cube to be controlled.
                destinationCanvasController.InitWithCube(cube);
            }
        }
    }
}
