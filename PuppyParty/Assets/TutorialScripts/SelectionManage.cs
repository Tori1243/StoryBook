using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManage : MonoBehaviour
{
	[SerializeField] private string selectableTag = "Selectable";
	[SerializeField] private Material highlightMaterail;
	[SerializeField] private Material defaultMaterial;

	private Transform _selection;
	
	private void Update()
	{
		if (_selection != null)
		{
			var selectionRender = _selection.GetComponent<Renderer>();
			selectionRender.material = defaultMaterial;
			_selection = null;
		}
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			var selection = hit.transform;
			if (selection.CompareTag(selectableTag))
			{
				var selectionRenderer = selection.GetComponent<Renderer>();
				if (selectionRenderer != null)
				{
					selectionRenderer.material = highlightMaterail;
				}

				_selection = selection; 
			}
		}
	}
}
