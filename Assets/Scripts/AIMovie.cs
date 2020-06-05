using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovie : MonoBehaviour
{
   public Transform[] WayPoints;
   public Transform Bird;

   public float Speed = 0.25f;
   public float SpeedRotate = 5f;

   private int _count = 0;

   private void Update()
   {
      Bird.position = Vector3.MoveTowards(Bird.position, WayPoints[_count].position, Time.deltaTime * Speed);
      Bird.rotation = Quaternion.RotateTowards(Bird.rotation, WayPoints[_count].rotation, Time.deltaTime * SpeedRotate);

      if (Bird.position == WayPoints[_count].position && Bird.rotation == WayPoints[_count].rotation)
         _count++;
   }
}
