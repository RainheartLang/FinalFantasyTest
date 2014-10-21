using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Базовый контроллер для управления списком gui-элементов
public abstract class GuiControllerBase {

    Dictionary<int?, GuiControl> controls = new Dictionary<int?, GuiControl>(); //контролы
	
    // инициализация контроллера
	public abstract void initialize();

    //обновление контролов
    public void update()
    {
        List<int?> keys = new List<int?>(this.controls.Keys);
        foreach (int id in keys)
        {
            GuiControl control = this.controls[id];
            if (control.isVisible)
                control.update();
            if (!control.isActive)
                this.controls.Remove(id);
        }
    }

    protected void add(int? id, GuiControl control)
    {
        if (id == null)
        {
            Debug.Log("Ошибка: попытка добавить в контроллер контрол с null-идентификатором.");
            return;
        }
        if (this.controls.ContainsKey(id))
        {
            Debug.Log("Ошибка: попытка добавить в контроллер контрол с идентификатором " + id
                + " который уже присутствует.");
            return;
        }
        this.controls.Add(id, control);
    }

}
