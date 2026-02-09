using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HotfixBusiness.UI
{
	public partial class UIHomeForm
	{
		private UIButtonSuper m_Btn_Start;
		private TextMeshProUGUI m_TxtM_Sure;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();

			m_Btn_Start = autoBindTool.GetBindComponent<UIButtonSuper>(0);
			m_TxtM_Sure = autoBindTool.GetBindComponent<TextMeshProUGUI>(1);
		}
	}
}
