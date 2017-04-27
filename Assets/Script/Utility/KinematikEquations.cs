using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public static class KinematikEquations {

//public class JumpArc
//{
//    public  Suvat up, down, right;
//    public Vector3 InitialVelocity;
        
//    public Vector3 ComputeInitialVelocity(float jumpHeight, float gravity, float distance, float finalHeight = 0)
//    {
//        up = new Suvat(jumpHeight, Mathf.Sqrt(-2 * gravity * jumpHeight), 0, gravity, Mathf.Sqrt(-(2 * jumpHeight / gravity)));

//        down = new Suvat(finalHeight - jumpHeight, 0, 0, gravity, Mathf.Sqrt(2 * (finalHeight - jumpHeight) / gravity));

//        right = new Suvat(distance, distance / (up.t + down.t), 0, 0, up.t + down.t);

//        InitialVelocity = new Vector3(right.u, up.u, 0);

//        return InitialVelocity;
//    }

//    public struct Suvat
//    {
//        public float s, u, v, a, t;

//        public Suvat(float s, float u, float v, float a, float t)
//        {
//            // Distance/Displacement
//            this.s = s;
//            // Initial Velocity
//            this.u = u;
//            // Final Velocity
//            this.v = v;
//            // Acceleration
//            this.a = a;
//            // Time
//            this.t = t;
//        }
//    }
//}

    
//}
