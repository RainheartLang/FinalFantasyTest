using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class GuiControllerBase {

    public List<GuiControl> controls = new List<GuiControl>();
	
	public abstract void initialize();

    public void update()
    {
        foreach (GuiControl control in this.controls)
        {
            control.update();
        }
    }
}
