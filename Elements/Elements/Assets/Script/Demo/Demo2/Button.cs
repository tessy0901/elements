using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2{ // namespace を使うと同じクラス名が使える
	public class Button : MonoBehaviour {
		public Sprite beforeSprite;
		public Sprite afterSprite;
		public SpriteRenderer spriteRenderer;

		public void Push(){
			ChangeSprite();
		}

		void ChangeSprite(){
			beforeSprite = spriteRenderer.sprite;
			spriteRenderer.sprite = afterSprite;
			afterSprite = beforeSprite;
		}
	}
}
