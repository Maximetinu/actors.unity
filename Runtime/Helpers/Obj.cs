//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	public static class Obj
	{
		public static void Release(this GameObject o, int poolID = 0)
		{
			if (poolID <= 0)
				GameObject.Destroy(o);
			else HandlePool.Despawn(poolID, o);
		}

		//===============================//
		// By GameObject ID
		//===============================//

		// Default
		public static Transform Spawn(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(prefab).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(prefab, parent).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefab, parent, startPosition, startRotation).GetComponent<T>();
		}

		public static T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefab, startPosition, startRotation).GetComponent<T>();
		}
		
		//Pooled
		public static Transform Spawn(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefab, parent, startPosition, startRotation).GetComponent<T>();
		}

		public static T Spawn<T>(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID , prefab, startPosition, startRotation).GetComponent<T>();
		}
		
		public static Transform Spawn(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = HandlePool.pools[poolID].Spawn(prefab).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		//===============================//
		// By String ID
		//===============================//

		// Default
		public static Transform Spawn(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(Box.Get<GameObject>(prefabID)).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(Box.Get<GameObject>(prefabID), parent).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefabID, parent, startPosition, startRotation).GetComponent<T>();
		}
		public static T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefabID, startPosition, startRotation).GetComponent<T>();
		}
		
		
		// Pooled
		public static Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = HandlePool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID)).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = HandlePool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), parent).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static T Spawn<T>(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponent<T>();
		}

		public static T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefabID, startPosition, startRotation).GetComponent<T>();
		}
	}
}