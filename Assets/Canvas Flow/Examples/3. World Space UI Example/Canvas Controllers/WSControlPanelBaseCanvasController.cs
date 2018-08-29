using P7.CanvasFlow;

// This base class provides a common constructor that can be subclassed on all
// control panel screens in order to pass them the cube that they should interact
// with.
public class WSControlPanelBaseCanvasController : CanvasController
{
    protected WSCube cube;

    public void InitWithCube(WSCube cube)
    {
        this.cube = cube;
    }
}
