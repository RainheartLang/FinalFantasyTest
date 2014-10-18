using UnityEngine;
using System.Collections;

//Объект-текстура, отображаемый на слое интерфейса
public class Icon : GuiControl {

    private Texture2D iconTexture;

    public Icon(Texture2D texture, int x, int y, int width, int height)
    {
        this.iconTexture = texture;
        this.position = new Rect(x, y, width, height);
    }

    public Icon(string path, int x, int y, int width, int height)
    {
        this.iconTexture = Core.getResourcesManager().getTexture(path);
        this.position = new Rect(x, y, width, height);
    }

    protected override void graphicUpdate()
    {
        GUI.Label(this.position, iconTexture, StylesList.LABEL_STYLE);
    }
}
