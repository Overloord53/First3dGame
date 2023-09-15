using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
   private PlayerController playerControlls;

   public Vector2 movementInput;

   private void OnEnable()
   {
      if (playerControlls == null)
      {
          playerControlls = new PlayerController();

          playerControlls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
      }
      
      playerControlls.Enable();
   }

   private void OnDisable()
   {
       playerControlls.Disable();
   }
}
