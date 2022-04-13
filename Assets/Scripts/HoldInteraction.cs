using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEditor;

#if UNITY_EDITOR
[InitializeOnLoad]
#endif

//Helped with figuring this out: https://www.youtube.com/watch?v=rMlcwtoui4I

public class HoldInteraction : IInputInteraction
{
    static HoldInteraction()
    {
        InputSystem.RegisterInteraction<HoldInteraction>();
    }

    void IInputInteraction.Process(ref InputInteractionContext context)
    {
        switch(context.phase)
        {
            case InputActionPhase.Started:
                //we've started holding down the thing
                context.Performed();
                break;

            case InputActionPhase.Performed:
                //we are holding down the thing, move to finished holdign down the thing
                context.Canceled();
                break;
        }
    }

    void IInputInteraction.Reset()
    {
        
    }
}
