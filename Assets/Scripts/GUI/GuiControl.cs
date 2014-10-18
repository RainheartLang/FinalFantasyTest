using UnityEngine;
using System.Collections;

public abstract class GuiControl
{
    protected Rect position;

    public void update()
    {
        logicUpdate();
        graphicUpdate();
    }

    protected abstract void graphicUpdate();

    protected void logicUpdate()
    { }
}
