using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class ResourcesManager {

    private const string TEXTURES_PATH = "Textures/";

    private int a;

    private Dictionary<Type, ResourceContainer> resourceContainers;
    private List<Texture2D> textures = new List<Texture2D>();

    public void initialize()
    {
        this.resourceContainers = new Dictionary<Type, ResourceContainer>();

        this.resourceContainers.Add(typeof(Texture2D), new ResourceContainer(typeof(Texture2D)));
    }


    private T loadResource<T>(string path) where T: UnityEngine.Object
    {
        Type resourceType = typeof(T);
        ResourceContainer container = resourceContainers[resourceType];
        if (container == null)
        {
            Debug.Log("Попытка обратиться к несуществующему контейнеру ресурсов типа " + resourceType);
            return null;
        }

        T resource = (T)container.find(path);

        if (resource != null)
        {
            return resource;
        }

        resource = Resources.Load<T>(path);

        if (resource == null)
        {
            Debug.Log("Не удалось загрузить ресурс " + path);
        }
        else
        {
            container.add(path, resource);
        }

        return resource;
    }

    public Texture2D getTexture(String fileName)
    {
        return loadResource<Texture2D>(TEXTURES_PATH + fileName);
    }

}
