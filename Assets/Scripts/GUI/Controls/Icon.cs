using UnityEngine;
using System.Collections;

//Объект-текстура, отображаемый на слое интерфейса
public class Icon : GuiControl {

    private Texture2D iconTexture;

    public Icon(Texture2D texture, float x, float y, float width, float height)
    {
        this.iconTexture = texture;
       setPosition(x, y, width, height);
    }

    public Icon(string path, float x, float y, float width, float height)
    {
        this.iconTexture = Core.getResourcesManager().getTexture(path);
        setPosition(x, y, width, height);
    }

    protected override void graphicUpdate()
    {
        GUI.Label(this.position, iconTexture, StylesList.LABEL_STYLE);
    }
}
