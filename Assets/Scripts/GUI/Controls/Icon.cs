using UnityEngine;
using System.Collections;

//Объект-текстура, отображаемый на слое интерфейса
public class Icon : GuiControl {

    private Texture2D iconTexture;

    public Icon(Texture2D texture, float x, float y, float width, float height)
    {
        initialize();
        this.iconTexture = texture;
       setPosition(x, y, width, height);
    }

    public Icon(string path, float x, float y, float width, float height)
    {
        initialize();
        this.iconTexture = Core.getResourcesManager().getTexture(path);
        setPositionCentral(x, y, width, height);
    }

    protected override void setPositionCentral(float x, float y, float width, float height)
    {
        float widthScale = (width) / iconTexture.width;
        float heightScale = (height) / iconTexture.height;
        float scale = Mathf.Min(widthScale, heightScale);
        base.setPositionCentral(x, y, iconTexture.width * scale, iconTexture.height * scale);
    }

    protected override void graphicUpdate()
    {
        GUISkin skin = Core.getResourcesManager().getSkin("CustomSkin");
        GUI.Box(this.position, iconTexture, skin.box);
    }
}
