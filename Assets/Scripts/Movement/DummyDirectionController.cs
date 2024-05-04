﻿using UnityEngine;

namespace CasualGame.Movement
{
    public class DummyDirectionController : MonoBehaviour, IMovementDirectionSource
    {
        public Vector3 MovementDirection { get; private set; }

        protected void Awake()
        {
            MovementDirection = Vector3.zero;
        }
    }
}