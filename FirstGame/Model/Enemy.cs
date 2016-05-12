using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FirstGame.View;

namespace FirstGame
{
	public class Enemy
	{
		public Enemy ()
		{
		}

		// Animation representing the enemy
		private Animation enemyAnimation;
		public Animation EnemyAnimation 
		{
			get { return enemyAnimation; }
			set { enemyAnimation = value; }
		}

		// The position of the enemy ship relative to the top left corner of thescreen
		private Vector2 position;
		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}

		// The state of the Enemy Ship
		private bool active;
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		// The hit points of the enemy, if this goes to zero the enemy dies
		private int health;
		public int Health 
		{
			get { return health; }
			set { health = value; }
		}

		// The amount of damage the enemy inflicts on the player ship
		private int damage;
		public int Damage 
		{
			get { return damage; }
			set { damage = value; }
		}

		// The amount of score the enemy will give to the player
		private int value;
		public int Value
		{
			get { return value; }
			set { value = value; }
		}

		// Get the width of the enemy ship
		public int Width
		{
			get { return EnemyAnimation.FrameWidth; } 
		}

		// Get the height of the enemy ship
		public int Height
		{
			get { return EnemyAnimation.FrameHeight; } 
		}

		// The speed at which the enemy moves
		float enemyMoveSpeed;

		public void Initialize(Animation animation,Vector2 position)
		{
			
			// Load the enemy ship texture
			this.EnemyAnimation = animation;


			// Set the position of the enemy
			this.Position = position;

			// We initialize the enemy to be active so it will be update in the game
			this.Active = true;


			// Set the health of the enemy
			this.health = 10;

			// Set the amount of damage the enemy can do
			this.damage = 10;

			// Set how fast the enemy moves
			this.enemyMoveSpeed = 6f;


			// Set the score value of the enemy
			this.value = 100;

		}

		public void Update()
		{
		}

		public void Draw()
		{
		}

	}
}

