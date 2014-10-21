using UnityEngine;
using System.Collections;
using System;
//База для кастомных объектов-контролов (графический интерфейс)
public abstract class GuiControl : IComparable
{
    protected int? id;
    protected Rect position;
    public bool isVisible;
    public bool isActive;
    public int zIndex;

    public int CompareTo(object other)
    {
        if (other.GetType() == typeof(GuiControl))
        {
            GuiControl otherCasted = (GuiControl)other;
            return this.zIndex - otherCasted.zIndex;
        }
        return 1000;
    }

    //обновляем
    public void update()
    {
        logicUpdate();
        graphicUpdate();
    }

    protected void initialize()
    {
        this.isVisible = false;
        this.isActive = true;
    }

    //Графическая обработка контроллеров
    protected abstract void graphicUpdate();

    //Дополнительная обработка
    protected void logicUpdate()
    { }

    protected virtual void setPosition(float x,float y, float width, float height)
    {
        position = new Rect(x * Screen.width, y * Screen.height, width * Screen.width, height * Screen.height);
    }

    protected virtual void setPositionCentral(float x, float y, float width, float height)
    {
        setPosition(x - (width / 2), y - (height / 2), width, height);
    }

    public void setPosition(float x, float y, float width, float height, GUIControlPositioning positioning)
    {
        if (positioning == GUIControlPositioning.NORMAL)
        {
            setPosition(x, y, width, height);
        }
        else if (positioning == GUIControlPositioning.CENTRAL)
            setPositionCentral(x, y, width, height);
    }


    public int? getId()
    {
        return this.id;
    }

    public void setId(int id)
    {
        if (this.id != null)
        {
            Debug.Log("Попытка присвоить новый идентификатор контролу интерфейса, у которого он уже присутствует");
            return;
        }
        this.id = id;
    }

    public void setVisible()
    {
        this.isVisible = true;
    }

    public void setInvisible()
    {
        this.isVisible = false;
    }

    public void setActive()
    {
        this.isActive = true;
    }

    public void setInactive()
    {
        this.isActive = false;
    }
}
