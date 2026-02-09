// ================================================
//描 述:
//作 者:AlanDu
//创建时间:2026-02-09 22-43-02
//修改作者:AlanDu
//修改时间:2026-02-09 22-43-02
//版 本:0.1 
// ===============================================

using HotfixFramework.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotfixBusiness.UI
{
	/// <summary>
	/// Please modify the description.
	/// </summary>
	public partial class UIHomeForm : UIFixBaseForm
	{
		protected override void OnInit(object userData) {
			 base.OnInit(userData);
			 GetBindComponents(gameObject);

/*--------------------Auto generate start button listener.Do not modify!--------------------*/
			m_Btn_Start.onClick.AddListener(Btn_StartEvent);
/*--------------------Auto generate end button listener.Do not modify!----------------------*/
		}

		private void Btn_StartEvent(){}
/*--------------------Auto generate footer.Do not add anything below the footer!------------*/
	}
}
