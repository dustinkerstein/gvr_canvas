using P7.CanvasFlow;
using UnityEngine;

public class TEMenuCanvasController : CanvasController, ICanvasControllerTransitioningAnimatorVendor
{
    [Header("TEMenuCanvasController")]
    public CanvasControllerTransitioningAnimator[] animators;

    #region Button Callbacks

    public void OnDefaultTransitionButtonPressed()
    {
        PresentCanvasController<TEDefaultTransitionCanvasController>(
            configuration: (descriptionCanvasController) =>
        {
            // In the configuration handler set the canvas controller's
            // transitioning animator vendor to be us so we can vend the
            // relevant animator.

            descriptionCanvasController.transitioningAnimatorVendor = this;
        });
    }

    public void OnFadeTransitionButtonPressed()
    {
        PresentCanvasController<TEFadeTransitionCanvasController>(
            configuration: (descriptionCanvasController) =>
        {
            descriptionCanvasController.transitioningAnimatorVendor = this;
        });
    }

    public void OnSlideTransitionButtonPressed()
    {
        PresentCanvasController<TESlideTransitionCanvasController>(
            configuration: (descriptionCanvasController) =>
        {
            descriptionCanvasController.transitioningAnimatorVendor = this;
        });
    }

    public void OnScaleTransitionButtonPressed()
    {
        PresentCanvasController<TEScaleTransitionCanvasController>(
            configuration: (descriptionCanvasController) =>
        {
            descriptionCanvasController.transitioningAnimatorVendor = this;
        });
    }

    public void OnScaleAndFadeTransitionButtonPressed()
    {
        PresentCanvasController<TEScaleAndFadeTransitionCanvasController>(
            configuration: (descriptionCanvasController) =>
        {
            descriptionCanvasController.transitioningAnimatorVendor = this;
        });
    }

    #endregion

    #region ICanvasControllerTransitioningAnimatorVendor

    public ICanvasControllerTransitioningAnimator TransitioningAnimatorForContext(
        CanvasControllerTransitionContext transitionContext)
    {
        // The transitioning canvas controller will ask its transitioning animator
        // vendor (us) for an animator before transitioning. We can give it the
        // correct one depending on what canvas controller is transitioning.

        // The presented canvas controller is the destination on downstream transitions (Present)
        // and the source on upstream transitions (Dismiss).
        CanvasController presentedCanvasController = (transitionContext.isUpstream) ?
            transitionContext.sourceCanvasController : transitionContext.destinationCanvasController;

        int animatorIndex = 0;
        if (presentedCanvasController is TEDefaultTransitionCanvasController)
        {
            animatorIndex = 0;
        }
        else if (presentedCanvasController is TEFadeTransitionCanvasController)
        {
            animatorIndex = 1;
        } 
        else if (presentedCanvasController is TESlideTransitionCanvasController)
        {
            animatorIndex = 2;
        } 
        else if (presentedCanvasController is TEScaleTransitionCanvasController)
        {
            animatorIndex = 3;
        } 
        else if (presentedCanvasController is TEScaleAndFadeTransitionCanvasController)
        {
            animatorIndex = 4;
        }

        var animator = animators[animatorIndex];
        return animator;
    }

    #endregion
}