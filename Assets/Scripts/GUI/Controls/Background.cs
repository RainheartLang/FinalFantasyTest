using UnityEngine;
using System.Collections;

public class Background : GuiControl {
    
    private const string TEXTURE_NAME = "white-background";
    private Color color;
    private Texture2D texture;
    private static GUIStyle style = null;
    private static Rect backgroundRectangle;

    public Background(Color c)
    {
        this.color = c;
        this.texture = Core.getResourcesManager().getTexture(TEXTURE_NAME);
        if (style == null)
        {
            style = new GUIStyle();
            style.normal.background = texture;
        }
        backgroundRectangle = new Rect(0, 0, Screen.width, Screen.height);
    }

    protected override void graphicUpdate()
    {
        Color bufColor = GUI.backgroundColor;
        GUI.backgroundColor = this.color;
        GUI.Box(backgroundRectangle, "", style);        
    }
}
