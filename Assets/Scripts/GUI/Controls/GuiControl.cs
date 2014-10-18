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

    protected void setPosition(float x,float y, float width, float height)
    {
        position = new Rect(x * Screen.width, y * Screen.height, width * Screen.width, height * Screen.height);
    }
}
