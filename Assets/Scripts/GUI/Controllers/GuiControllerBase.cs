using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Базовый контроллер для управления списком gui-элементов
public abstract class GuiControllerBase {

    protected List<GuiControl> controls = new List<GuiControl>(); //контролы
	
    // инициализация контроллера
	public abstract void initialize();

    //обновление контролов
    public void update()
    {
        foreach (GuiControl control in this.controls)
        {
            control.update();
        }
    }
}
