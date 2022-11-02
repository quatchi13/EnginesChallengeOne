using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreatorCommands : ICommand
{

    Transform position;

    GameObject prefab;

   public void Undo()
   {
        ItemCreator.CreateItem(prefab, position.position);
   }

   public void SetValues(Transform newPosition, GameObject newObjct)
   {
    
    position = newPosition;
    prefab = newObjct;

    }
}
