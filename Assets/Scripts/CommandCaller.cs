using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandCaller : MonoBehaviour
{
   static List<ICommand> history = new List<ICommand>();


   private void Update() {
    if(Input.GetKeyDown(KeyCode.Backspace))
    {
        Undo();
    }
   }

   public void Undo()
   {
        if(history.Count > 0)
        {
            history[history.Count -1].Undo();
        }
        history.Remove(history[history.Count-1]);
   }

   public void AddCommand(ICommand command)
   {
        history.Add(command);
   }


}
