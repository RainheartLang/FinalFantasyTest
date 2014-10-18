using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
//Стандартный менеджер ресурсов
public class ResourcesManager {

    private const string TEXTURES_PATH = "Textures/";

    private Dictionary<Type, ResourceContainer> resourceContainers;  //список контейнеров ресурсов

    //инициализация, здесь добавляем все нужные контейнеры
    public void initialize()
    {
        this.resourceContainers = new Dictionary<Type, ResourceContainer>();

        this.resourceContainers.Add(typeof(Texture2D), new ResourceContainer(typeof(Texture2D)));
    }

    //Общий метод загрузки ресурса
    private T loadResource<T>(string path) where T: UnityEngine.Object
    {
        //сначала ищем контейнер по типу дженерика
        Type resourceType = typeof(T);
        ResourceContainer container = resourceContainers[resourceType];
        if (container == null)
        {
            Debug.Log("Попытка обратиться к несуществующему контейнеру ресурсов типа " + resourceType);
            return null;
        }

        //Пробуем найти ресурс в наших контейнерах
        T resource = (T)container.find(path);

        if (resource != null)
        {
            return resource;
        }
        //Если не нашли - пытаемся загрузить через стандартный загрузчик
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

    //получение ресурса-текстуры
    public Texture2D getTexture(String fileName)
    {
        return loadResource<Texture2D>(TEXTURES_PATH + fileName);
    }

}
