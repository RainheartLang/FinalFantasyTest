using UnityEngine;
using System.Collections;

public class Icon : GuiControl {

    private Texture2D iconTexture;

    public Icon(Texture2D texture, int x, int y, int width, int height)
    {
        this.iconTexture = texture;
        this.position = new Rect(x, y, width, height);
    }

    public Icon(string path)
    {
    }

    protected override void graphicUpdate()
    {
        GUI.Label(this.position, iconTexture, StylesList.LABEL_STYLE);
    }
}
