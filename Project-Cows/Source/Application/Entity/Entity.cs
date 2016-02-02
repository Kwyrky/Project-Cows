﻿// Project Cows -- GearShift Games
// Written by D. Sinclair, 2016
// ================
// Entity.cs

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Project_Cows.Source.System.Graphics.Sprites;

namespace Project_Cows.Source.Application.Entity {
    class Entity {
        // Class to base all game objects upon
        // ================

        // Variables
        protected Sprite m_sprite;                  // Sprite for the entity
        protected EntityCollider m_collider;        // Physics collider for the entity
        protected Vector2 m_position;               // Position of the entity
        protected float m_rotation;                 // Rotation of the entity, in degrees
        protected bool m_collidable;                // Whether the entity is collidable

        // Methods
        public Entity(Texture2D texture_, Vector2 position_, float rotation_) {
            // Entity constructor
            // ================

            m_position = position_;
            m_rotation = rotation_;
            m_sprite = new Sprite(texture_, m_position, m_rotation, 1.0f);
            m_collider = new EntityCollider(new Rectangle((int)m_position.X, (int)m_position.Y, (int)m_sprite.GetWidth(), (int)m_sprite.GetHeight()), m_rotation);
            m_collidable = true;

        }

		public void UpdateSprite() {
			// Updates the position and rotation of the entity's sprite
			m_sprite.SetPosition(m_position);
			m_sprite.SetRotationDegrees(m_rotation);
		}

        // Getters
        public Sprite GetSprite() { return m_sprite; }

		public EntityCollider GetCollider() { return m_collider; }

		public Vector2 GetPosition() { return m_position; }

		public float GetRotationDegrees() {
			return m_rotation;
		}

		public float GetRotationRadians() {
			// Returns the entity's rotation, in radians
			float rad = m_rotation * (3.1415f / 180);
			return rad;
		}

		public bool GetCollidable() { return m_collidable; }

        // Setters
        public void SetSprite(Sprite sprite_) { m_sprite = sprite_; }

		public void SetPosition(Vector2 position_) { m_position = position_; }

		public void SetRotationDegrees(float degrees_) {
			m_rotation = degrees_;
		}

		public void SetRotationRadians(float radians_) {
			m_rotation = radians_ * (180 / 3.1415f);
		}

    }
}