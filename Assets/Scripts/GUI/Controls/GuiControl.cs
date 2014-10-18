using UnityEngine;
using System.Collections;

//База для кастомных объектов-контролов (графический интерфейс)
public abstract class GuiControl
{
    protected Rect position;

    //обновляем
    public void update()
    {
        logicUpdate();
        graphicUpdate();
    }

    //Графическая обработка контроллеров
    protected abstract void graphicUpdate();

    //Дополнительная обработка
    protected void logicUpdate()
    { }
}
