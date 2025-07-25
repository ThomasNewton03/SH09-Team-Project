﻿namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Utils;
	using Mapbox.Unity.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.Utilities;
	using System.Collections.Generic;
	using Mapbox.Examples;

	public class SpawnOnMap : MonoBehaviour {
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		[Geocode]
		string[] _locationStrings;
		Vector2d[] _locations;

		[SerializeField]
		float _spawnScale = 100f;

		[SerializeField]
		GameObject _markerPrefab;

		[SerializeField]
		GameObject _buttonPrefab;

		GameObject canvas;

		List<GameObject> _spawnedObjects;

		void Start()
		{
			
			_locations = new Vector2d[_locationStrings.Length];
			_spawnedObjects = new List<GameObject>();
			canvas = GameObject.FindGameObjectWithTag("Canvas");

			// Make instance of prefab button on the canvas 
			var button = Instantiate(_buttonPrefab);
			button.transform.SetParent(canvas.transform);
			button.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
			button.transform.localPosition = _map.GeoToWorldPosition(_locations[0], true);

			// For every model...
			for (int i = 0; i < _locationStrings.Length; i++)
			{
				// ...make the model on the map in unity at correct positions and scale 
				var locationString = _locationStrings[i];
				_locations[i] = Conversions.StringToLatLon(locationString);
				var instance = Instantiate(_markerPrefab);
				instance.GetComponent<EventPointer>().eventPose = _locations[i];
				instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
				instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);

				// and add a script to check if it can be collected
				var distanceScript = instance.AddComponent<CheckModelDistance>();
				distanceScript.button = button;

				// 
				var mapManager = button.AddComponent<MapManager>();
				distanceScript.mapManager = mapManager;
				
				// button.GetComponentInChildren<TMPPro>().text += i;

				_spawnedObjects.Add(instance);
			}
		}

		private void Update()
		{
			int count = _spawnedObjects.Count;
			for (int i = 0; i < count; i++)
			{
				var spawnedObject = _spawnedObjects[i];
				var location = _locations[i];
				spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
				spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			}
		}
	}
}